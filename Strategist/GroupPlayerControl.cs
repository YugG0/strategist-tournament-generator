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
    public partial class GroupPlayerControl : UserControl
    {
        public GroupPlayerControl()
        {
            InitializeComponent();
        }

        public string Number
        {
            set => Label_PlayerPosition.Text = value;
        }

        public string Nick
        {
            set => Label_PlayerNick.Text = value;
        }

        public string CountMatches
        {
            set => Label_CountMatches.Text = value;
        }

        public string Score
        {
            set => Label_Score.Text = value;
        }

        public Color SetColor
        {
            set
            {
                Label_PlayerPosition.ForeColor = value;
                Label_PlayerNick.ForeColor = value;
                Label_CountMatches.ForeColor = value;
                Label_Score.ForeColor = value;
            }
        }

        private bool active = true;

        public bool Active
        {
            get => active;
            set => active = value;
        }
    }
}
