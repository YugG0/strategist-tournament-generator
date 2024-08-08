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
    public partial class CreatePlayer : Form
    {
        public CreatePlayer(Home home)
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

        private Color creationColor = Color.FromArgb(255, 192, 128);
        private Color readyColor = Color.FromArgb(128, 255, 128);

        private void Start()
        {
            InitializeTimer();
            LabelCreatePlayerStatus.Visible = false;
        }

        public void CreatePlayerButton(object sender, EventArgs e)
        {
            StartCreatrTimer();

            string nick = "";

            nick = TextBox_PlayerNick.Text;

            Player newPlayer = new Player(nick);

            home.AddPlayerToDatabase(newPlayer);
            home.SaveDataBase();

            EndCreateTimer();
            home.UpdatePlayersList();
        }

        private Timer timer;
        private int dotsCount;

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
        }

        private void StartCreatrTimer()
        {
            timer.Start();
            LabelCreatePlayerStatus.Visible = true;
            LabelCreatePlayerStatus.ForeColor = creationColor;
            LabelCreatePlayerStatus.Text = "Creation";
        }

        private void EndCreateTimer()
        {
            timer.Stop();
            LabelCreatePlayerStatus.ForeColor = readyColor;
            LabelCreatePlayerStatus.Text = "Player created";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dotsCount = (dotsCount + 1) % 4;
            string dots = new string('.', dotsCount);
            LabelCreatePlayerStatus.Text = $"Creation{dots}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timer.Stop();
            base.OnFormClosing(e);
        }
    }
}