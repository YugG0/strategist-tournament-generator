using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategist
{
    public partial class CreateTournament : Form
    {
        public CreateTournament(Home home, List<Player> playersData)
        {
            InitializeComponent();

            this.home = home;
            players = playersData;

            Start();
        }

        private Point mouseOffset;

        private void ClickDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(e.X, e.Y);
            }
        }

        private void Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point currentScreenPos = Cursor.Position;
                this.Location = new Point(currentScreenPos.X - mouseOffset.X, currentScreenPos.Y - mouseOffset.Y);
            }
        }

        private void CloseWindow(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private Home home;

        private List<Player> players = new List<Player>();

        private List<ParticipantControl> noParticipantControls = new List<ParticipantControl>();
        private List<ParticipantControl> participantControls = new List<ParticipantControl>();

        private Image plusImage;
        private Image minusImage;


        private void Start()
        {
            plusImage = Properties.Resources.Plus_Icon;
            minusImage = Properties.Resources.Minus_Icon;

            CreateParticipantsCells();
            UpdateNoParticipantCells();
            UpdateParticipantCells();
            UpdateParticipantsCount();
        }

        private void CreateParticipantsCells()
        {
            int sizeY = 30;
            int space = 10;

            for (int i = 0; i < players.Count; i++)
            {
                int posX = space;
                int posY = (sizeY + space / 2) * i + space;

                Player player = players[i];

                CreateParticipantControl(player, posX, posY, i);
            }
        }

        private void CreateParticipantControl(Player player, int posX, int posY, int index)
        {
            ParticipantControl participantControl = new ParticipantControl(this, player);

            participantControl.Nick = player.nick;
            participantControl.Index = index;
            participantControl.Location = new Point(posX, posY);

            this.Controls.Add(participantControl);
            noParticipantControls.Add(participantControl);
            Panel_NoParticipants.Controls.Add(participantControl);
        }

        private void UpdateNoParticipantCells()
        {
            int sizeY = 30;
            int space = 10;

            for (int i = 0; i < noParticipantControls.Count; i++)
            {
                ParticipantControl control = noParticipantControls[i];

                int posX = space;
                int posY = (sizeY + space / 2) * i + space;

                SetPosition(control, posX, posY, false);

                control.Index = i;
            }
        }

        private void UpdateParticipantCells()
        {
            int sizeY = 30;
            int space = 10;

            for (int i = 0; i < participantControls.Count; i++)
            {
                ParticipantControl control = participantControls[i];

                int posX = space;
                int posY = (sizeY + space / 2) * i + space;

                SetPosition(control, posX, posY, true);

                control.Index = i;
            }
        }

        private void SetPosition(ParticipantControl control, int posX, int posY, bool isParticipant)
        {
            control.Location = new Point(posX, posY);
            control.Participant = isParticipant;
        }

        public void SetStatus(bool isParticipant, int index)
        {
            if (isParticipant)
            {
                ParticipantControl participantControl = participantControls[index];

                participantControls.Remove(participantControl);
                noParticipantControls.Add(participantControl);

                Panel_Participants.Controls.Remove(participantControl);
                Panel_NoParticipants.Controls.Add(participantControl);

                participantControl.Participant = false;
                participantControl.StatusImage = plusImage;
            }
            else
            {
                ParticipantControl participantControl = noParticipantControls[index];

                noParticipantControls.Remove(participantControl);
                participantControls.Add(participantControl);

                Panel_NoParticipants.Controls.Remove(participantControl);
                Panel_Participants.Controls.Add(participantControl);

                participantControl.Participant = true;
                participantControl.StatusImage = minusImage;
            }

            UpdateNoParticipantCells();
            UpdateParticipantCells();
            UpdateParticipantsCount();
        }

        private void UpdateParticipantsCount()
        {
            Label_CountParticipants.Text = noParticipantControls.Count + "/" + participantControls.Count;
        }

        public void CreateTournamentButton(object sender, EventArgs e)
        {
            string gameName = TextBox_Game.Text;
            string tournamentName = TextBox_Name.Text;
            if (tournamentName == "")
            {
                OpenMessage("Tournament name not specified.");
                return;
            }

            string date = TextBox_Date.Text;
            string prize = TextBox_Prize.Text;

            int groupBo = int.Parse(TextBox_BOGroupStage.Text);
            int playoffBo = int.Parse(TextBox_BOPlayoff.Text);
            int playoffFinalBo = int.Parse(TextBox_BOPlayoffFinal.Text);

            List<int> playersIdList = new List<int>();
            foreach (var control in participantControls)
            {
                playersIdList.Add(control.Player.id);
            }
            if (playersIdList.Count < 4 || !CheckCountPlayers(playersIdList.Count))
            {
                OpenMessage("Unavailable number of players. Needed: 4, 8, 16, 24, 32, 48, 64 and so on.");
                return;
            }

            string playersId = JsonSerializer.Serialize(playersIdList);

            Tournament tournament = new Tournament();
            tournament.ClearTournament(gameName, tournamentName, date, prize, Stage.GroupStage.ToString(), groupBo, playoffBo, playoffFinalBo, playersId);

            home.AddTournamentToDatabase(tournament);
            home.SaveDataBase();
            home.UpdateTournamentsList();
            this.Close();
        }

        private bool CheckCountPlayers(int n)
        {
            return (n > 0) && (Math.Log(n, 2) % 1 == 0);
        }

        public void OpenMessage(string text)
        {
            Label_Message.Visible = true;
            Label_Message.Text = text;
        }

        public void CheckBOChange(object sender, EventArgs e)
        {
            int groupBo = int.Parse(TextBox_BOGroupStage.Text);
            int playoffBo = int.Parse(TextBox_BOPlayoff.Text);
            int playoffFinalBo = int.Parse(TextBox_BOPlayoffFinal.Text);

            if (groupBo < 1) { groupBo = 1; }
            if (groupBo > 5) { groupBo = 5; }

            if (playoffBo < 1) { playoffBo = 1; }
            if (playoffBo > 5) { playoffBo = 5; }

            if (playoffFinalBo < 1) { playoffFinalBo = 1; }
            if (playoffFinalBo > 5) { playoffFinalBo = 5; }

            TextBox_BOGroupStage.Text = groupBo.ToString();
            TextBox_BOPlayoff.Text = playoffBo.ToString();
            TextBox_BOPlayoffFinal.Text = playoffFinalBo.ToString();
        }
    }
}