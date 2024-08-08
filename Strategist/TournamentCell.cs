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
    public partial class TournamentCell : UserControl
    {
        public TournamentCell(Home home, int id)
        {
            InitializeComponent();

            this.home = home;
            this.id = id;
        }

        public Image Logo
        {
            set => PictureBox_TournamentLogo.BackgroundImage = value;
        }

        public string Title
        {
            set => Label_Name.Text = value;
        }

        public string Date
        {
            set => Label_Data.Text = value;
        }

        public string Prize
        {
            set => Label_Prize.Text = value;
        }

        public string Winner
        {
            set => Label_Winner.Text = value;
        }

        public string Runnerup
        {
            set => Label_Runnerup.Text = value;
        }

        private Home home;
        private int id;

        public void VierTournamentButton(object sender, EventArgs e)
        {
            home.ViewTournamentWithId(id);
        }
    }
}
