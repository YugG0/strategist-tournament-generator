using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategist
{
    public partial class EditPlayer : Form
    {
        public EditPlayer(Home home, int id)
        {
            this.home = home;
            playerId = id;

            InitializeComponent();

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
        private List<Player> players;

        private Player editPlayer;
        private int editPlayerPosition;

        private int playerId;

        private void Start()
        {
            Button_NoDelete.Visible = false;
            Button_YesDelete.Visible = false;

            LoadDatabase();
            (editPlayer, editPlayerPosition) = FindPlayerByID(playerId);
            SetWindowName(editPlayer.nick);
            TextBox_PlayerNewNick.Text = editPlayer.nick;
        }

        private void LoadDatabase()
        {
            players = home.players;
        }

        private void SetWindowName(string newName)
        {
            Label_WindowName.Text = "Edit " + newName;
        }

        private (Player, int) FindPlayerByID(int id)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].id == id) { return (players[i], i); }
            }

            return (null, 0);
        }

        private void ConfirmButton(object sender, EventArgs e)
        {
            string newPlayerNick = TextBox_PlayerNewNick.Text;

            if (editPlayer != null)
            {
                editPlayer.nick = newPlayerNick;
                home.SaveDataBase();
                SetWindowName(newPlayerNick);
                home.UpdatePlayersList();
            }
        }

        private void DeleteButton(object sender, EventArgs e)
        {
            Button_NoDelete.Visible = true;
            Button_YesDelete.Visible = true;
        }

        private void YesDeleteButton(object sender, EventArgs e)
        {
            if (editPlayer != null)
            {
                home.RemovePlayerFromDatabase(editPlayer);
                home.SaveDataBase();
                home.UpdatePlayersList();
                this.Close();
            }
        }

        private void NoDeleteButton(object sender, EventArgs e)
        {
            Button_NoDelete.Visible = false;
            Button_YesDelete.Visible = false;
        }
    }
}