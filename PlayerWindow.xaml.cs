using System.Windows;

namespace NFL
{
    public partial class PlayerWindow : Window
    {
        public PlayerWindow(Player player)
        {
            InitializeComponent();

            DataContext = player;
        }
    }
}
