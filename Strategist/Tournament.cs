using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Strategist
{
    public class Tournament
    {
        public int id { get; set; }

        public string game { get; set; }
        public string title { get; set; }
        public string prize { get; set; }
        public string date { get; set; }

        public string currentTournamentStage { get; set; }
        public int groupBo { get; set; }
        public int playoffBo { get; set; }
        public int playoffFinalBo { get; set; }

        public string playersId { get; set; } 
        public string groupPlayers { get; set; }
        public string groupMatches { get; set; }
        public string bracketMatches { get; set; }

        public int winnerId { get; set; }
        public int runnerupId { get; set; }

        public int currentGroupRound { get; set; }
        public int currentPlayoffRound { get; set; }

        public Tournament()
        {

        }

        public Tournament(string game, string title, string prize, string date)
        {
            this.game = game;
            this.title = title;
            this.date = date;
            this.prize = prize;
        }

        public void ClearTournament(string game, string title, string date, string prize, string currentTournamentStage, int groupBo, int playoffBo, int playoffFinalBo, string playersId)
        {
            this.game = game;
            this.title = title;
            this.date = date;
            this.prize = prize;

            this.currentTournamentStage = currentTournamentStage;
            this.groupBo = groupBo;
            this.playoffBo = playoffBo;
            this.playoffFinalBo = playoffFinalBo;

            this.playersId = playersId;

            this.groupPlayers = JsonSerializer.Serialize(new List<GroupPlayer>());
            this.groupMatches = JsonSerializer.Serialize(new List<Match>());
            this.bracketMatches = JsonSerializer.Serialize(new List<Match>());

            this.winnerId = -1;
            this.runnerupId = -1;

            this.currentGroupRound = 0;
            this.currentPlayoffRound = 0;
        }
    }
}
