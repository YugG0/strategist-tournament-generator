using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategist
{
    public class Player
    {
        public int id { get; set; }
        public string nick { get; set; }

        public Player() { }
        public Player(string nick) 
        { 
            this.nick = nick;
        }
    }
}
