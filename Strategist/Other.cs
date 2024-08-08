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
    public partial class Other : Form
    {
        public Other(Home home)
        {
            this.home = home;

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

        private Image checkImage;
        private Image noCheckImage;

        private bool clearTournaments;
        private bool clearPlayers;

        private void Start()
        {
            checkImage = Properties.Resources.Check_icon;
            noCheckImage = Properties.Resources.NoCheck_icon;
        }

        public void ClearTournamentsClick(object sender, EventArgs e)
        {
            if (clearTournaments)
            {
                clearTournaments = false;
                PictureBox_CheckTournament.BackgroundImage = noCheckImage;
            }
            else
            {
                clearTournaments = true;
                PictureBox_CheckTournament.BackgroundImage = checkImage;
            }

            CheckWarningMessage();
        }

        public void ClearPlayersClick(object sender, EventArgs e)
        {
            if (clearPlayers)
            {
                clearPlayers = false;
                PictureBox_CheckPlayer.BackgroundImage = noCheckImage;
            }
            else
            {
                clearPlayers = true;
                PictureBox_CheckPlayer.BackgroundImage = checkImage;
            }

            CheckWarningMessage();
        }

        public void AcceptClear(object sender, EventArgs e)
        {
            if (clearTournaments)
            {
                home.ClearTournamentsDatabase();
            }

            if (clearPlayers)
            {
                home.ClearPlayersDatabase();
            }
        }

        private void CheckWarningMessage()
        {
            if (clearTournaments || clearPlayers)
            {
                Label_Warnings.Visible = true;
            }
            else
            {
                Label_Warnings.Visible = false;
            }
        }
    }
}
