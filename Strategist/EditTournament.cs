using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategist
{
    public partial class EditTournament : Form
    {
        public EditTournament(ViewTournament viewTournament, Tournament tournament, Home home)
        {
            InitializeComponent();

            this.tournament = tournament;
            this.viewTournament = viewTournament;
            this.home = home;

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

        private Tournament tournament;
        private ViewTournament viewTournament;
        private Home home;

        private void Start()
        {
            LoadInfo();
        }

        private void LoadInfo()
        {
            TextBox_Game.Text = tournament.game;
            TextBox_Name.Text = tournament.title;
            TextBox_Date.Text = tournament.date;
            TextBox_Prize.Text = tournament.prize;

            SetWindowName(tournament.title);
        }

        public void AcceptEdit(object sender, EventArgs e)
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

            tournament.game = gameName;
            tournament.title = tournamentName;
            tournament.date = date;
            tournament.prize = prize;

            home.SaveDataBase();
            viewTournament.UpdateTournamentInfo();
        }

        public void DeleteButton(object sender, EventArgs e)
        {
            Button_YesDelete.Visible = true;
            Button_NoDelete.Visible = true;
        }

        public void YesDeleteButton(object sender, EventArgs e)
        {
            if (tournament != null)
            {
                home.RemoveTournamentFromDatabase(tournament);
                home.SaveDataBase();
                home.UpdateTournamentsList();

                viewTournament.Close();
                this.Close();
            }
        }

        public void NoDeleteButton(object sender, EventArgs e)
        {
            Button_YesDelete.Visible = false;
            Button_NoDelete.Visible = false;
        }

        private void OpenMessage(string text)
        {
            Label_Message.Visible = true;
            Label_Message.Text = text;
        }

        private void SetWindowName(string newName)
        {
            Label_WindowName.Text = "Edit " + newName;
        }
    }
}
