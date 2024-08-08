using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Security.Policy;
using System.Data.SqlClient;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace Strategist
{
    public partial class ViewTournament : Form
    {
        public ViewTournament(Home home, Tournament tournament)
        {
            this.home = home;
            this.tournament = tournament;

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

        //Start Load Data
        private Home home;
        private Tournament tournament;
        private List<int> playersId = new List<int>();
        private Stage tournamentStage = Stage.GroupStage;

        private bool groupPlayersIsLoad;
        private bool groupStageIsLoad;
        private bool playoffStageIsLoad;

        private int groupBo = 1;
        private int playoffBo = 1;
        private int playoffFinalBo = 1;
        //End Load Data

        //Start Tour
        private List<TourTabsBttnsControl> groupUpperTabsBttsControls = new List<TourTabsBttnsControl>();
        private List<TourTabsBttnsControl> groupDownTabsBttsControls = new List<TourTabsBttnsControl>();

        private int commandUpperTabs;
        private int commandDownTabs;

        private List<Match> currentMatches = new List<Match>();
        //End Tour

        //Start Group Stage
        private int countRoundsInGroupStage;
        private int currentGroupRound = 0;

        private List<GroupPlayer> groupPlayers = new List<GroupPlayer>();
        private List<GroupPlayerControl> groupPlayerControls = new List<GroupPlayerControl>();
        private List<List<Match>> groupStageMatches = new List<List<Match>>();
        private List<List<GroupMatchControl>> groupMatchesControls = new List<List<GroupMatchControl>>();
        //End Group Stage

        //Start Play Stage
        private int countRoundsInPlayoffStage;
        private int currentPlayoffRound = 0;

        private List<Player> winners = new List<Player>();
        private List<List<Match>> playoffStageMatches = new List<List<Match>>();
        private List<List<PlayoffMatchControl>> playoffMatchControls = new List<List<PlayoffMatchControl>>();
        //End Play Stage

        private void Start()
        {
            LoadTournament();

            //--------------Tournament--------------
            CreateTabs();
            LoadTournamentInfo();

            //--------------Group stage--------------
            AddGroupPlayers();
            LoadGroupStagePlayers();
            AddMatchesGroupStages();

            //--------------Play-off stage--------------
            AddMatchesPlayoffStage();

            //--------------End--------------
            UpdateObjectPopularity();
            FullSave();
        }

        private void CheckGroupMatches()
        {
            bool allGamesPlayed = true;

            foreach (var match in currentMatches)
            {
                if (match.GetWinnerLoser() == (-1, -1))
                {
                    Label_Message.Visible = true;
                    Label_Message.Text = "The match was not played: " + GetPlayerFromDatabase(match.player1Id).nick + " Vs. " + GetPlayerFromDatabase(match.player2Id).nick;
                    allGamesPlayed = false;
                    break;
                }
            }

            if (allGamesPlayed)
            {
                foreach (var match in currentMatches)
                {
                    int winnerId, loserId;
                    (winnerId, loserId) = match.GetWinnerLoser();

                    Player winnerPlayer = GetPlayerFromDatabase(winnerId);
                    Player loserPlayer = GetPlayerFromDatabase(loserId);

                    GroupPlayer winnerGroupPlayer = GetGroupPlayer(winnerId);
                    GroupPlayer loserGroupPlayer = GetGroupPlayer(loserId);

                    winnerGroupPlayer.win++; winnerGroupPlayer.matchesPlayed++;
                    loserGroupPlayer.losses++; loserGroupPlayer.matchesPlayed++;
                }

                UpdateVisualizationGroupStagePlayers();

                if (currentGroupRound != countRoundsInGroupStage - 1)
                {
                    currentGroupRound++;

                    CreateCurrentGroupMatches();
                    CreateVisualizationGroupMatchesThisRound(currentGroupRound);
                    UpdateVisualizationCurrentGroupMatches(currentGroupRound);

                    SetCommand(currentGroupRound + 1, false);
                }
                else
                {
                    SetCommand(commandUpperTabs + 1, true);
                    EndGroupStage();
                }

                SaveGroupStageTournament();
            }
        }

        public void AddScorePoint(int numberPlayer, int round, int numberMatch, int score, Stage stage)
        {
            if (tournamentStage == stage)
            {
                if (tournamentStage == Stage.GroupStage) { if (round != currentGroupRound) { return; } }
                else if (tournamentStage == Stage.Playoffs) { if (round != currentPlayoffRound) { return; } }

                Match match = currentMatches[numberMatch];

                if (numberPlayer == 1)
                {
                    match.score1 += score;
                }
                else if (numberPlayer == 2)
                {
                    match.score2 += score;
                }

                int countWins = groupBo;
                if (match.isPlayoff) 
                {
                    if (match.isFinal)
                    {
                        countWins = playoffFinalBo;
                    }
                    else
                    {
                        countWins = playoffBo;
                    }
                }

                countWins = (int)Math.Ceiling((double)countWins / 2); 

                if (match.score1 > countWins) { match.score1 = countWins; }
                else if (match.score1 < 0) { match.score1 = 0; }

                if (match.score2 > countWins) { match.score2 = countWins; }
                else if (match.score2 < 0) { match.score2 = 0; }

                if (tournamentStage == Stage.GroupStage) 
                {
                    UpdateVisualizationCurrentGroupMatches(round);
                    SaveGroupStageTournament();
                }
                else if (tournamentStage == Stage.Playoffs)
                {
                    UpdateVisualizationPlayoffMatch(round);
                    SavePlayoffStageTournament();
                }
            }
        }

        public void EndRound(object sender, MouseEventArgs e)
        {
            if (tournamentStage == Stage.GroupStage)
            {
                CheckGroupMatches();
            }
            else if (tournamentStage == Stage.Playoffs)
            {
                CheckPlayoffMaches();
            }
        }

        private GroupPlayer GetGroupPlayer(int id)
        {
            foreach (var groupPlayer in groupPlayers)
            {
                if (groupPlayer.playerId == id) { return groupPlayer; }
            }
            return null;
        }

        private void LoadTournamentInfo()
        {
            //Load logo

            Label_WindowName.Text = tournament.title;

            Label_Title.Text = tournament.title;
            Label_Game.Text = tournament.game;
            Label_Date.Text = tournament.date;
            Label_Prize.Text = tournament.prize;

            if (tournament.winnerId == -1)
            {
                Label_Winner.Text = "Winner: TBD";
            }
            else
            {
                Label_Winner.Text = "Winner: " + GetPlayerFromDatabase(tournament.winnerId).nick;
            }

            if (tournament.runnerupId == -1)
            {
                Label_Runnerup.Text = "Runner-up: TBD";
            }
            else
            {
                Label_Runnerup.Text = "Runner-up: " + GetPlayerFromDatabase(tournament.runnerupId).nick;
            }
        }

        public void UpdateTournamentInfo()
        {
            LoadTournamentInfo();
        }

        private void AddGroupPlayers()
        {
            if (!groupPlayersIsLoad)
            {
                foreach (var playerId in playersId)
                {
                    GroupPlayer groupPlayer = new GroupPlayer(playerId);
                    groupPlayers.Add(groupPlayer);
                }

                groupPlayers = ShuffleGroupPlayers(groupPlayers);
            }
        }

        private void LoadGroupStagePlayers()
        {
            int sizeY = 35;

            int space = 6;

            for (int i = 0; i < groupPlayers.Count; i++)
            {
                int posX = space;
                int posY = space + (sizeY + space) * i;

                CreateGroupStagePlayerCell(posX, posY);
            }

            UpdateVisualizationGroupStagePlayers();
        }

        private void UpdateVisualizationGroupStagePlayers()
        {
            groupPlayers = SortingPlayersByWins(groupPlayers);

            for (int i = 0; i < groupPlayers.Count; i++)
            {
                UpdatePlayerVisualizationGroupStages(groupPlayerControls[i], i + 1, groupPlayers[i]);
            }
        }

        private void CreateGroupStagePlayerCell(int posX, int posY)
        {
            GroupPlayerControl groupPlayerControl = new GroupPlayerControl();

            groupPlayerControl.Location = new Point(posX, posY);

            this.Controls.Add(groupPlayerControl);
            Panel_Cells.Controls.Add(groupPlayerControl);
            groupPlayerControls.Add(groupPlayerControl);
        }

        private void UpdatePlayerVisualizationGroupStages(GroupPlayerControl groupPlayerControl, int number, GroupPlayer groupPlayer)
        {
            Player player = GetPlayerFromDatabase(groupPlayer.playerId);

            groupPlayerControl.Number = number + ".";
            groupPlayerControl.Nick = player.nick.ToString();

            groupPlayerControl.CountMatches = groupPlayer.matchesPlayed.ToString();
            groupPlayerControl.Score = groupPlayer.win.ToString() + " - " + groupPlayer.losses.ToString();

            if (groupPlayer.win >= 3) { groupPlayerControl.SetColor = Color.YellowGreen; }
            else if (groupPlayer.losses >= 3) { groupPlayerControl.SetColor = Color.IndianRed; }
        }

        private List<GroupPlayer> SortingPlayersByWins(List<GroupPlayer> players)
        {
            return players
            .OrderByDescending(player => player.win)
            .ThenBy(player => player.losses)
            .ToList();
        }

        private List<GroupPlayer> ShuffleGroupPlayers(List<GroupPlayer> players)
        {
            Random rnd = new Random();

            List<GroupPlayer> shufflePlayers = players;

            for (int i = 0; i < shufflePlayers.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GroupPlayer saveId = shufflePlayers[i];
                    int randomPos = rnd.Next(shufflePlayers.Count);

                    shufflePlayers[i] = shufflePlayers[randomPos];
                    shufflePlayers[randomPos] = saveId;
                }
            }

            return shufflePlayers;
        }

        private List<Player> ShufflePlayers(List<Player> players)
        {
            Random rnd = new Random();

            List<Player> shufflePlayers = players;

            for (int i = 0; i < shufflePlayers.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Player saveId = shufflePlayers[i];
                    int randomPos = rnd.Next(shufflePlayers.Count);

                    shufflePlayers[i] = shufflePlayers[randomPos];
                    shufflePlayers[randomPos] = saveId;
                }
            }

            return shufflePlayers;
        }

        private void AddMatchesGroupStages()
        {
            for (int i = 0; i < countRoundsInGroupStage; i++)
            {
                groupMatchesControls.Add(new List<GroupMatchControl>());
            }

            if (groupStageIsLoad)
            {
                AddToCurrentGroupMatchesLastSavedMatches();
                CreateVisualizationGroupMatches();
            }
            else
            {
                for (int i = 0; i < countRoundsInGroupStage; i++)
                {
                    groupStageMatches.Add(new List<Match>());
                }

                CreateCurrentGroupMatches();
                CreateVisualizationGroupMatchesThisRound(currentGroupRound);
            }

            UpdateVisualizationAllGroupMatches();
        }

        private void CreateCurrentGroupMatches()
        {
            groupPlayers = SortingPlayersByWins(groupPlayers);
            currentMatches = new List<Match>();
            int numberMatch = 0;

            for (int i = 0; i < groupPlayers.Count; i++)
            {
                if (groupPlayers[i].win < 3 && groupPlayers[i].losses < 3)
                {
                    int player1Id = groupPlayers[i].playerId;
                    int player2Id = groupPlayers[i + 1].playerId;

                    Match match = new Match(player1Id, player2Id);

                    match.groupBo = groupBo;
                    match.playoffBo = playoffBo;
                    match.playoffFinalBo = playoffFinalBo;
                    match.round = currentGroupRound;
                    match.numberMatch = numberMatch;

                    currentMatches.Add(match);
                    groupStageMatches[currentGroupRound].Add(match);

                    numberMatch++;
                    i++;
                }
            }
        }

        private void AddToCurrentGroupMatchesLastSavedMatches()
        {
            currentMatches = groupStageMatches[currentGroupRound];
        }

        private void CreateVisualizationGroupMatches()
        {
            for (int round = 0; round < groupStageMatches.Count; round++)
            {
                CreateVisualizationGroupMatchesThisRound(round);
            }
        }

        private void CreateVisualizationGroupMatchesThisRound(int round)
        {
            int sizeY = 35;

            for (int numberMatch = 0; numberMatch < groupStageMatches[round].Count; numberMatch++)
            {
                int posX = 0;
                int posY = 0;

                int space = 6;

                posX = space;
                posY = 60 + (sizeY + space) * numberMatch;

                CreateVisualizationGroupMatch(round, numberMatch, posX, posY);
            }
        }

        private void CreateVisualizationGroupMatch(int round, int numberMatch, int posX, int posY)
        {
            GroupMatchControl groupMatch = new GroupMatchControl(this, round, numberMatch, Stage.GroupStage);

            groupMatch.Location = new Point(posX, posY);

            this.Controls.Add(groupMatch);
            Panel_Cells.Controls.Add(groupMatch);
            groupMatchesControls[round].Add(groupMatch);
        }

        private void UpdateVisualizationAllGroupMatches()
        {
            for (int round = 0; round < groupMatchesControls.Count; round++)
            {
                UpdateVisualizationCurrentGroupMatches(round);
            }
        }

        private void UpdateVisualizationCurrentGroupMatches(int round)
        {
            for (int numberMatch = 0; numberMatch < groupStageMatches[round].Count; numberMatch++)
            {
                GroupMatchControl groupMatch = groupMatchesControls[round][numberMatch];
                Match match = groupStageMatches[round][numberMatch];

                Player player1 = GetPlayerFromDatabase(match.player1Id);
                Player player2 = GetPlayerFromDatabase(match.player2Id);

                groupMatch.Number = (numberMatch + 1) + ".";
                groupMatch.Nick1 = player1.nick;
                groupMatch.Nick2 = player2.nick;
                groupMatch.Score1 = match.score1.ToString();
                groupMatch.Score2 = match.score2.ToString();
            }
        }

        private void CreateTabs()
        {
            CreateTabGroupStages(1, true, "Play-off", DockStyle.Left, Panel_StageTabsUpper, groupUpperTabsBttsControls, false);
            CreateTabGroupStages(0, true, "Group", DockStyle.Left, Panel_StageTabsUpper, groupUpperTabsBttsControls, true);
            groupUpperTabsBttsControls.Reverse();

            CreateTabGroupStages(0, false, "Group list", DockStyle.Left, Panel_StageTabsDown, groupDownTabsBttsControls, true);
            for (int i = 1; i <= countRoundsInGroupStage; i++)
            {
                CreateTabGroupStages(i, false, "Round " + i, DockStyle.Right, Panel_StageTabsDown, groupDownTabsBttsControls, false);
            }
        }

        private void CreateTabGroupStages(int command, bool isUpperTab, string text, DockStyle dockStyle, Control control, List<TourTabsBttnsControl> tourTabs, bool isStartActive)
        {
            TourTabsBttnsControl buttonRoundControll = new TourTabsBttnsControl(this, command, isUpperTab);

            buttonRoundControll.ButtonText = text;
            buttonRoundControll.Dock = dockStyle;
            if (isStartActive) { buttonRoundControll.ActiveButton(); }

            this.Controls.Add(buttonRoundControll);
            control.Controls.Add(buttonRoundControll);
            tourTabs.Add(buttonRoundControll);
        }

        public void SetCommand(int command, bool isUpperTab)
        {
            if (isUpperTab)
            {
                groupDownTabsBttsControls[commandDownTabs].NotActiveButton();
                groupDownTabsBttsControls[0].ActiveButton();

                groupUpperTabsBttsControls[command].ActiveButton();
                groupUpperTabsBttsControls[commandUpperTabs].NotActiveButton();

                commandDownTabs = 0;
                commandUpperTabs = command;

                UpdateObjectPopularity();
            }
            else
            {
                if (command != commandDownTabs)
                {
                    groupDownTabsBttsControls[command].ActiveButton();
                    groupDownTabsBttsControls[commandDownTabs].NotActiveButton();

                    commandDownTabs = command;
                    UpdateObjectPopularity();
                }
            }
        }

        private void UpdateObjectPopularity()
        {
            Label_Message.Visible = false;

            if (commandUpperTabs == 0)
            {
                Panel_StageTabsDown.Visible = true;

                foreach (var controlList in playoffMatchControls)
                {
                    foreach (var control in controlList)
                    {
                        control.Visible = false;
                    }
                }

                if (commandDownTabs == 0)
                {
                    foreach (var controlList in groupMatchesControls)
                    {
                        foreach (var control in controlList)
                        {
                            control.Visible = false;
                        }
                    }

                    foreach (var control in groupPlayerControls)
                    {
                        control.Visible = true;
                    }

                    Button_EndRound.Visible = false;
                }
                else
                {
                    foreach (var controlList in groupMatchesControls)
                    {
                        foreach (var control in controlList)
                        {
                            control.Visible = false;
                        }
                    }

                    foreach (var control in groupPlayerControls)
                    {
                        control.Visible = false;
                    }

                    for (int i = 0; i < groupMatchesControls[commandDownTabs - 1].Count; i++)
                    {
                        groupMatchesControls[commandDownTabs - 1][i].Visible = true;
                    }

                    Button_EndRound.Visible = false;

                    if (commandDownTabs == currentGroupRound + 1 && tournamentStage == Stage.GroupStage)
                    {
                        Button_EndRound.Visible = true;
                    }
                }
            }
            else if (commandUpperTabs == 1)
            {
                if (tournamentStage == Stage.Playoffs) { Button_EndRound.Visible = true; }

                foreach (var controlList in groupMatchesControls)
                {
                    foreach (var control in controlList)
                    {
                        control.Visible = false;
                    }
                }

                foreach (var control in groupPlayerControls)
                {
                    control.Visible = false;
                }

                Panel_StageTabsDown.Visible = false;

                foreach (var controlList in playoffMatchControls)
                {
                    foreach (var control in controlList)
                    {
                        control.Visible = true;
                    }
                }
            }
        }

        private void AddMatchesPlayoffStage()
        {
            for (int i = 0; i < countRoundsInPlayoffStage; i++)
            {
                playoffMatchControls.Add(new List<PlayoffMatchControl>());
            }

            if (playoffStageIsLoad)
            {
                AddToCurrentPlayoffMatchesLastSavedMatches();
                CreateVisualizationPlayoffMatches();
                UpdateVisualizationAllPlayoffMatches();
            }
            else
            {
                CreateVisualizationPlayoffMatches();
            }
        }

        private void AddToCurrentPlayoffMatchesLastSavedMatches()
        {
            currentMatches = playoffStageMatches[currentPlayoffRound];
        }

        private void CreateVisualizationPlayoffMatches()
        {
            int sizeX = 250;
            int sizeY = 85;

            int spaceX = 100;
            int spaceY = 50;

            for (int round = 0; round < countRoundsInPlayoffStage; round++)
            {
                int matchesInCurrentRound = (playersId.Count / 2) / (int)Math.Pow(2, round + 1);
                int verticalSpacing = (int)Math.Pow(2, round) * (sizeY + spaceY);

                for (int countMatch = 0; countMatch < matchesInCurrentRound; countMatch++)
                {
                    int posX = (round * (sizeX + spaceX)) + 6;
                    int posY = (countMatch * verticalSpacing + (verticalSpacing / 2) - (sizeY / 2)) + 40;

                    CreateVisualizationPlayoffMatchControl(round, countMatch, posX, posY);
                }
            }
        }

        private void CreateVisualizationPlayoffMatchControl(int round, int countMatch, int posX, int posY)
        {
            PlayoffMatchControl playoffMatchControl = new PlayoffMatchControl(this, round, countMatch, Stage.Playoffs);

            playoffMatchControl.Location = new Point(posX, posY);

            this.Controls.Add(playoffMatchControl);
            Panel_Cells.Controls.Add(playoffMatchControl);
            playoffMatchControls[round].Add(playoffMatchControl);
        }

        private void UpdateVisualizationAllPlayoffMatches()
        {
            for (int round = 0; round < playoffStageMatches.Count; round++)
            {
                UpdateVisualizationPlayoffMatch(round);
            }
        }

        private void UpdateVisualizationPlayoffMatch(int round)
        {
            for (int countMatch = 0; countMatch < playoffStageMatches[round].Count; countMatch++)
            {
                Match match = playoffStageMatches[round][countMatch];
                PlayoffMatchControl playoffMatchControl = playoffMatchControls[round][countMatch];

                Player player1 = GetPlayerFromDatabase(match.player1Id);
                Player player2 = GetPlayerFromDatabase(match.player2Id);

                playoffMatchControl.Nick1 = player1.nick.ToString();
                playoffMatchControl.Nick2 = player2.nick.ToString();

                playoffMatchControl.Score1 = match.score1.ToString();
                playoffMatchControl.Score2 = match.score2.ToString();
            }
        }

        private void EndGroupStage()
        {
            tournamentStage = Stage.Playoffs;

            List<Player> playoffPlayers = new List<Player>();

            for (int i = 0; i < groupPlayers.Count; i++)
            {
                if (groupPlayers[i].win >= 3) // Set 3
                {
                    Player player = new Player();
                    player = GetPlayerFromDatabase(groupPlayers[i].playerId);
                    playoffPlayers.Add(player);
                }
            }

            for (int i = 0; i < countRoundsInPlayoffStage; i++)
            {
                playoffStageMatches.Add(new List<Match>());
            }

            playoffPlayers = ShufflePlayers(playoffPlayers);
            CreateCurrentPlayoffMatches(playoffPlayers);
        }

        private void CreateCurrentPlayoffMatches(List<Player> players)
        {
            currentMatches = new List<Match>();
            int numberMatch = 0;

            for (int i = 0; i < players.Count; i += 2)
            {
                Match match = new Match(players[i].id, players[i+1].id);

                match.round = currentPlayoffRound;
                match.numberMatch = numberMatch;

                match.groupBo = groupBo;
                match.playoffBo = playoffBo;
                match.playoffFinalBo = playoffFinalBo;

                match.isPlayoff = true;
                if (players.Count == 2) { match.isFinal = true; }

                currentMatches.Add(match);
                playoffStageMatches[currentPlayoffRound].Add(match);

                numberMatch++;
                // Тут баг, если игрока не хватает
            }

            UpdateVisualizationPlayoffMatch(currentPlayoffRound);
        }

        private void CheckPlayoffMaches()
        {
            bool allGamesPlayed = true;

            foreach (var match in currentMatches)
            {
                if (match.GetWinnerLoser() == (-1, -1))
                {
                    Label_Message.Visible = true;
                    Label_Message.Text = "The match was not played: " + GetPlayerFromDatabase(match.player1Id).nick + " Vs. " + GetPlayerFromDatabase(match.player2Id).nick;
                    allGamesPlayed = false;
                    break;
                }
            }

            if (allGamesPlayed)
            {
                Label_Message.Visible = false;

                winners = new List<Player>();

                foreach (var match in currentMatches)
                {
                    int winnerId, loserId;
                    (winnerId, loserId) = match.GetWinnerLoser();

                    Player winnerPlayer = GetPlayerFromDatabase(winnerId);
                    winners.Add(winnerPlayer);
                }

                if (currentPlayoffRound != countRoundsInPlayoffStage - 1)
                {
                    currentPlayoffRound++;
                    CreateCurrentPlayoffMatches(winners);
                    UpdateVisualizationPlayoffMatch(currentPlayoffRound);
                }
                else
                {
                    EndPlayofStage(currentMatches[0]);
                }

                SavePlayoffStageTournament();
            }
        }

        private void EndPlayofStage(Match match)
        {
            int winnerId, loserId;
            (winnerId, loserId) = match.GetWinnerLoser();

            tournament.winnerId = winnerId;
            tournament.runnerupId = loserId;

            tournamentStage = Stage.Final;

            SaveDatabase();
            LoadTournamentInfo();

            Button_EndRound.Visible = false;
        }

        private Player GetPlayerFromDatabase(int id)
        {
            List<Player> allPlayers = home.players;

            foreach (Player player in allPlayers)
            {
                if (player.id == id)
                {
                    return player;
                }
            }

            Player EmptyPlayer = new Player("[DELETE]");
            EmptyPlayer.id = -2;

            return EmptyPlayer;
        }

        private void LoadTournament()
        {
            tournamentStage = (Stage)Enum.Parse(typeof(Stage), tournament.currentTournamentStage);

            playersId = JsonSerializer.Deserialize<List<int>>(tournament.playersId);
            groupPlayers = JsonSerializer.Deserialize<List<GroupPlayer>>(tournament.groupPlayers);
            groupStageMatches = JsonSerializer.Deserialize<List<List<Match>>>(tournament.groupMatches);
            playoffStageMatches = JsonSerializer.Deserialize<List<List<Match>>>(tournament.bracketMatches);

            if (groupPlayers.Any())
            {
                groupPlayersIsLoad = true;
            }

            if (groupStageMatches.Any())
            {
                groupStageIsLoad = true;
            }

            if (playoffStageMatches.Any())
            {
                playoffStageIsLoad = true;
            }

            countRoundsInGroupStage = 3 + 3 - 1;
            countRoundsInPlayoffStage = (int)Math.Log(playersId.Count / 2, 2);

            groupBo = tournament.groupBo;
            playoffBo = tournament.playoffBo;
            playoffFinalBo = tournament.playoffFinalBo;

            currentGroupRound = tournament.currentGroupRound;
            currentPlayoffRound = tournament.currentPlayoffRound;
        }

        private void SaveGroupStageTournament()
        {
            tournament.currentTournamentStage = tournamentStage.ToString();
            tournament.currentGroupRound = currentGroupRound;

            string groupPlayerJson = JsonSerializer.Serialize(groupPlayers);
            string groupStageMatchesJson = JsonSerializer.Serialize(groupStageMatches);

            tournament.groupPlayers = groupPlayerJson;
            tournament.groupMatches = groupStageMatchesJson;

            SaveDatabase();
        }

        private void SavePlayoffStageTournament()
        {
            tournament.currentTournamentStage = tournamentStage.ToString();
            tournament.currentPlayoffRound = currentPlayoffRound;

            string playoffStageMatchesJson = JsonSerializer.Serialize(playoffStageMatches);

            tournament.bracketMatches = playoffStageMatchesJson;

            SaveDatabase();
        }

        private void FullSave()
        {
            tournament.currentTournamentStage = tournamentStage.ToString();
            tournament.currentGroupRound = currentGroupRound;
            tournament.currentPlayoffRound = currentPlayoffRound;

            string groupPlayerJson = JsonSerializer.Serialize(groupPlayers);
            string groupStageMatchesJson = JsonSerializer.Serialize(groupStageMatches);
            string playoffStageMatchesJson = JsonSerializer.Serialize(playoffStageMatches);

            tournament.groupPlayers = groupPlayerJson;
            tournament.groupMatches = groupStageMatchesJson;
            tournament.bracketMatches = playoffStageMatchesJson;

            SaveDatabase();
        }

        private void SaveDatabase()
        {
            home.SaveDataBase();
        }

        public void OpenEditTournament(object sender, EventArgs e)
        {
            EditTournament editTournament = new EditTournament(this, tournament, home);
            editTournament.Show();
        }
    }

    public class Match
    {
        public int player1Id { get; set; }
        public int player2Id { get; set; }
        public int score1 { get; set; }
        public int score2 { get; set; }

        public int round { get; set; }
        public int numberMatch { get; set; }

        public int groupBo { get; set; }
        public int playoffBo { get; set; }
        public int playoffFinalBo { get; set; }

        public bool isPlayoff { get; set; }
        public bool isFinal { get; set; }

        public (int, int) GetWinnerLoser()
        {
            int countWins = groupBo;

            if (isPlayoff)
            {
                if (isFinal)
                {
                    countWins = playoffFinalBo;
                }
                else
                {
                    countWins = playoffBo; 
                }
            }

            countWins = (int)Math.Ceiling((double)countWins / 2);

            if (score1 == countWins)
            {
                return (player1Id, player2Id);
            }
            else if (score2 == countWins)
            {
                return (player2Id, player1Id);
            }

            return (-1, -1);
        }

        public Match()
        {

        }

        public Match(int player1Id, int player2Id)
        {
            this.player1Id = player1Id;
            this.player2Id = player2Id;
        }

        public Match(int player1Id, int player2Id, int score1, int score2, int round, int numberMatch, bool isPlayoff)
        {
            this.player1Id = player1Id;
            this.player2Id = player2Id;
            this.score1 = score1;
            this.score2 = score2;
            this.round = round;
            this.numberMatch = numberMatch;
            this.isPlayoff = isPlayoff;
        }
    }

    public class GroupPlayer
    {
        public int playerId { get; set; }
        public int matchesPlayed { get; set; }
        public int win { get; set; }
        public int losses { get; set; }

        public GroupPlayer()
        {

        }

        public GroupPlayer(int playerId)
        {
            this.playerId = playerId;
        }
    }

    public enum Stage
    {
        NotStarted,
        GroupStage,
        Playoffs,
        Final
    }
}
