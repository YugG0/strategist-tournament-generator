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
    public partial class ParticipantControl : UserControl
    {
        public ParticipantControl(CreateTournament createTournament, Player player)
        {
            InitializeComponent();

            this.createTournament = createTournament;
            this.player = player;
        }

        public string Nick
        {
            set => Label_Nick.Text = value;
        }

        public Image StatusImage
        {
            set => PictureBox_Status.Image = value;
        }

        private Player player;
        private CreateTournament createTournament;
        private bool isParticipant;
        private int index;

        public bool Participant
        {
            set => isParticipant = value;
        }

        public int Index
        {
            set => index = value;
        }

        public Player Player
        {
            get => player;
        }

        public void SetStatusButton(object sender, EventArgs e)
        {
            createTournament.SetStatus(isParticipant, index);
        }
    }
}
