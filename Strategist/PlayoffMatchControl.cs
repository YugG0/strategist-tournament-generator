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
    public partial class PlayoffMatchControl : UserControl
    {
        public PlayoffMatchControl()
        {
            InitializeComponent();
        }

        public PlayoffMatchControl(ViewTournament viewTournament, int round, int numberMatch, Stage stage)
        {
            InitializeComponent();

            this.viewTournament = viewTournament;
            this.round = round;
            this.numberMatch = numberMatch;
            this.stage = stage;
        }

        public string Nick1
        {
            set => Label_Player1Nick.Text = value;
        }

        public string Nick2
        {
            set => Label_Player2Nick.Text = value;
        }

        public string Score1
        {
            set => Label_Score1.Text = value;
        }

        public string Score2
        {
            set => Label_Score2.Text = value;
        }

        private ViewTournament viewTournament;
        private Stage stage;
        private int round;
        private int numberMatch;

        public void AddScore1Button(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                viewTournament.AddScorePoint(1, round, numberMatch, 1, stage);
            }
            else if (e.Button == MouseButtons.Right)
            {
                viewTournament.AddScorePoint(1, round, numberMatch, -1, stage);
            }
        }

        public void AddScore2Button(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                viewTournament.AddScorePoint(2, round, numberMatch, 1, stage);
            }
            else if (e.Button == MouseButtons.Right)
            {
                viewTournament.AddScorePoint(2, round, numberMatch, -1, stage);
            }
        }
    }
}