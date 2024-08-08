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
    public partial class TourTabsBttnsControl : UserControl
    {
        public TourTabsBttnsControl()
        {
            InitializeComponent();
        }

        public TourTabsBttnsControl(ViewTournament viewTournament, int command, bool isUpperTab)
        {
            InitializeComponent();

            this.viewTournament = viewTournament;
            this.command = command;
            this.isUpperTab = isUpperTab;
        }

        public string ButtonText
        {
            set => Label_Round.Text = value;
        }

        private ViewTournament viewTournament;
        private int command;
        private bool isUpperTab;

        public void ButtonClick(object sender, MouseEventArgs e)
        {
            viewTournament.SetCommand(command, isUpperTab);
        }

        public void ActiveButton()
        {
            Label_Round.BackColor = Color.FromArgb(56, 56, 72);
        }

        public void NotActiveButton()
        {
            Label_Round.BackColor = Color.FromArgb(46, 46, 62);
        }
    }
}
