using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategist
{
    public partial class Home : Form
    {
        public Home()
        {
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

        private ApplicationContext dataBase;
        public List<Player> players = new List<Player>();
        public List<Tournament> tournaments = new List<Tournament>();
        
        private List<PlayerCell> playerCells = new List<PlayerCell>();
        private List<TournamentCell> tournamentCells = new List<TournamentCell>();

        private List<HomeTabsBttnsControl> upperTourTabs = new List<HomeTabsBttnsControl>();
        private List<HomeTabsBttnsControl> downTourTabs = new List<HomeTabsBttnsControl>();

        private int commandUpperTabs;
        private int commandDownTabs;

        // Nav
        private int tournamentPerPage = 11;
        private int playersPerPage = 44;

        private int countTournamentsNavPages = 1;
        private int countPlayersNavPages = 1;

        private int currentTournamentsNavPages = 1;
        private int currentPlayersNavPages = 1;
        // End nav

        private void Start()
        {
            LoadDatabase();
            CreateTabs();
            CreateCellList();
            UpdateObjectPopularity();
        }

        private void CreateCellList()
        {
            GeneratePlayerCells();
            GenerateTournamentCells();
        }

        private void LoadDatabase()
        {
            dataBase = new ApplicationContext();

            players = dataBase.Players.ToList();
            tournaments = dataBase.Tournaments.ToList();

            countPlayersNavPages = (int)Math.Ceiling((double)players.Count / playersPerPage);
            countTournamentsNavPages = (int)Math.Ceiling((double)tournaments.Count / tournamentPerPage);
        }

        private void GeneratePlayerCells()
        {
            int cellSizeX = 249;
            int cellSizeY = 48;

            int space = 6;

            int x = 0, y = 0;

            for (int i = 0; i < players.Count; i++)
            {
                int posX = 0;
                int posY = 0;

                posX = space + (cellSizeX + space) * x;
                posY = space + (cellSizeY + space) * y;

                Player player = players[i];

                CreatePlayerCell(posX, posY, player.id, player.nick);

                x++;

                if (x == 4)
                {
                    x = 0;
                    y++;
                }
            }
        }

        private void CreatePlayerCell(int posX, int posY, int id, string nick)
        {
            PlayerCell cell = new PlayerCell(this, id);

            cell.Location = new Point(posX, posY);
            cell.SetNick = nick; ;

            PanelCells.Controls.Add(cell);
            playerCells.Add(cell);
        }

        public void UpdateCells()
        {
            LoadDatabase();

            if (commandUpperTabs == 0)
            {
                foreach (TournamentCell cell in tournamentCells)
                {
                    this.Controls.Remove(cell);
                    cell.Dispose();
                }

                tournamentCells.Clear();
                GenerateTournamentCells();
            }
            else if (commandUpperTabs == 1)
            {
                foreach (PlayerCell cell in playerCells)
                {
                    this.Controls.Remove(cell);
                    cell.Dispose();
                }

                playerCells.Clear();
                GeneratePlayerCells();
            }

            UpdateObjectPopularity();
        }

        private void GenerateTournamentCells()
        {
            int sizeY = 50;

            int space = 5;

            for (int i = 0; i < tournaments.Count; i++)
            {
                int posX = space;
                int posY = (sizeY + space) * i + space;

                CreateTournamentCell(posX, posY, tournaments[i]);
            }
        }

        private void CreateTournamentCell(int posX, int posY, Tournament tournament)
        {
            TournamentCell cell = new TournamentCell(this, tournament.id);

            cell.Location = new Point(posX, posY);
            cell.Title = tournament.title;
            cell.Date = tournament.date;
            cell.Prize = tournament.prize;

            if (tournament.winnerId != -1)
            {
                cell.Winner = GetPlayerFromDatabase(tournament.winnerId).nick;
            }
            else
            {
                cell.Winner = "TBD";
            }

            if (tournament.runnerupId != -1)
            {
                cell.Runnerup = GetPlayerFromDatabase(tournament.runnerupId).nick;
            }
            else
            {
                cell.Runnerup = "TBD"; 
            }

            PanelCells.Controls.Add(cell);
            tournamentCells.Add(cell);
        }

        private Player GetPlayerFromDatabase(int id)
        {
            List<Player> allPlayers = players;

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

        private void OpenCreateTournamentWindow(object sender, EventArgs e)
        {
            CreateTournament createTournament = new CreateTournament(this, players);
            createTournament.Show();
        }

        private void OpenCreatePlayerWindow(object sender, EventArgs e)
        {
            CreatePlayer createPlayer = new CreatePlayer(this);
            createPlayer.Show();
        }

        public void EditPlayerWithId(int id)
        {
            EditPlayer editPlayer = new EditPlayer(this, id);
            editPlayer.Show();
        }

        public void ViewTournamentWithId(int id)
        {
            foreach (Tournament tournament in tournaments) 
            { 
                if (tournament.id == id) 
                {
                    ViewTournament viewTournament = new ViewTournament(this, tournament);
                    viewTournament.Show();

                    break;
                }
            }
        }

        private void OpenOtherWindow(object sender, EventArgs e)
        {
            Other other = new Other(this);
            other.Show();
        }

        public void UpdateListButton(object sender, EventArgs e)
        {
            UpdateCells();
        }

        public void UpdateTournamentsList()
        {
            LoadDatabase();

            foreach (TournamentCell cell in tournamentCells)
            {
                this.Controls.Remove(cell);
                cell.Dispose();
            }

            tournamentCells.Clear();
            GenerateTournamentCells();

            UpdateObjectPopularity();
        }

        public void UpdatePlayersList()
        {
            LoadDatabase();

            foreach (PlayerCell cell in playerCells)
            {
                this.Controls.Remove(cell);
                cell.Dispose();
            }

            playerCells.Clear();
            GeneratePlayerCells();

            UpdateObjectPopularity();
        }

        public void SaveDataBase()
        {
            dataBase.SaveChanges();
        }

        public void AddPlayerToDatabase(Player player)
        {
            dataBase.Players.Add(player);
        }

        public void RemovePlayerFromDatabase(Player player) 
        {
            var playerToRemove = dataBase.Players.Find(player.id);
            if (playerToRemove != null)
            {
                dataBase.Players.Remove(playerToRemove);
            }
            else
            {
                Console.WriteLine("Player not found for removal.");
            }
        }

        public void RemoveTournamentFromDatabase(Tournament tournament)
        {
            var tournamentToRemove = dataBase.Tournaments.Find(tournament.id);
            if (tournamentToRemove != null)
            {
                dataBase.Tournaments.Remove(tournamentToRemove);
            }
            else
            {
                Console.WriteLine("Tournament not found for removal.");
            }
        }

        public void AddTournamentToDatabase(Tournament tournament)
        {
            dataBase.Tournaments.Add(tournament);
        }

        public void ClearTournamentsDatabase()
        {
            foreach (var item in dataBase.Tournaments)
            {
                dataBase.Tournaments.Remove(item);
            }

            SaveDataBase();

            UpdateTournamentsList();
        }

        public void ClearPlayersDatabase()
        {
            foreach (var item in dataBase.Players)
            {
                dataBase.Players.Remove(item);
            }

            SaveDataBase();
            UpdatePlayersList();
        }

        private void CreateTabs()
        {
            CreateTabGroupStages(1, true, "Players", DockStyle.Left, Panel_Upper, upperTourTabs, false);
            CreateTabGroupStages(0, true, "Tournaments", DockStyle.Left, Panel_Upper, upperTourTabs, true);
            upperTourTabs.Reverse();

            CreateTabGroupStages(2, false, "Completed", DockStyle.Left, Panel_Down, downTourTabs, false);
            CreateTabGroupStages(1, false, "Ongoing", DockStyle.Left, Panel_Down, downTourTabs, false);
            CreateTabGroupStages(0, false, "All", DockStyle.Left, Panel_Down, downTourTabs, true);
            downTourTabs.Reverse();
        }

        private void CreateTabGroupStages(int command, bool isUpperTab, string text, DockStyle dockStyle, Control control, List<HomeTabsBttnsControl> tourTabs, bool isStartActive)
        {
            HomeTabsBttnsControl buttonRoundControll = new HomeTabsBttnsControl(this, command, isUpperTab);

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
                downTourTabs[0].ActiveButton();
                downTourTabs[commandDownTabs].NotActiveButton();

                upperTourTabs[command].ActiveButton();
                upperTourTabs[commandUpperTabs].NotActiveButton();

                commandDownTabs = 0;
                commandUpperTabs = command;

                UpdateObjectPopularity();
            }
            else
            {
                if (command != commandDownTabs)
                {
                    downTourTabs[command].ActiveButton();
                    downTourTabs[commandDownTabs].NotActiveButton();

                    commandDownTabs = command;
                    UpdateObjectPopularity();
                }
            }
        }

        private void UpdateObjectPopularity()
        {
            if (commandUpperTabs == 0)
            {
                foreach (PlayerCell cell in playerCells)
                {
                    cell.Visible = false;
                }

                foreach (TournamentCell cell in tournamentCells)
                {
                    cell.Visible = true;
                }
            }
            else if (commandUpperTabs == 1)
            {
                foreach (PlayerCell cell in playerCells)
                {
                    cell.Visible = true;
                }

                foreach (TournamentCell cell in tournamentCells)
                {
                    cell.Visible = false;
                }
            }
        }
    }
}