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
    public partial class PlayerCell : UserControl
    {
        private Home home;
        private int playerId;

        public PlayerCell(Home home, int playerId)
        {
            InitializeComponent();

            this.home = home;
            this.playerId = playerId;
        }

        public string SetNick 
        {
            set => LabelNick.Text = value;
        }

        private void EditPlayerClick(object sender, EventArgs e)
        {
            home.EditPlayerWithId(playerId);
        }
    }
}
