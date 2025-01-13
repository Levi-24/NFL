using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace NFL
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var players = LoadPlayers(@"../../../src/players.txt");
            var coaches = LoadCoaches(@"../../../src/coaches.txt");
            var teams = LoadTeams(@"../../../src/teams.txt", players, coaches);

            TeamsDataGrid.ItemsSource = teams;
        }

        private List<Player> LoadPlayers(string filePath)
        {
            return File.ReadAllLines(filePath)
                       .Select(line => new Player(line))
                       .ToList();
        }

        private List<Coach> LoadCoaches(string filePath)
        {
            return File.ReadAllLines(filePath)
                       .Select(line => new Coach(line))
                       .ToList();
        }

        private List<Team> LoadTeams(string filePath, List<Player> players, List<Coach> coaches)
        {
            return File.ReadAllLines(filePath)
                       .Select(line => new Team(line, players, coaches))
                       .ToList();
        }

        private void Detail_Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            var dataGridRow = DataGridRow.GetRowContainingElement(button);
            if (dataGridRow?.DataContext is Player player)
            {
                var playerDetailsWindow = new PlayerWindow(player);
                playerDetailsWindow.Show();
            }
        }
    }

    public partial class Team
    {
        public string JerseysList => string.Join(", ", Jerseys);
        public string PlayersList => string.Join(", ", Players.Select(p => p.Name));
        public string CoachesList => string.Join(", ", Coaches.Select(c => c.Name));
    }
}
