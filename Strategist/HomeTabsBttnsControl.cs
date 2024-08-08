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
    public partial class HomeTabsBttnsControl : UserControl
    {
        public HomeTabsBttnsControl()
        {
            InitializeComponent();
        }

        public HomeTabsBttnsControl(Home home, int command, bool isUpperTab)
        {
            InitializeComponent();

            this.home = home;
            this.command = command;
            this.isUpperTab = isUpperTab;
        }

        public string ButtonText
        {
            set => Label_ButtonText.Text = value;
        }

        private Home home;
        private int command;
        private bool isUpperTab;

        public void ButtonClick(object sender, MouseEventArgs e)
        {
            home.SetCommand(command, isUpperTab);
        }

        public void ActiveButton()
        {
            Label_ButtonText.BackColor = Color.FromArgb(56, 56, 72);
        }

        public void NotActiveButton()
        {
            Label_ButtonText.BackColor = Color.FromArgb(46, 46, 62);
        }
    }
}
