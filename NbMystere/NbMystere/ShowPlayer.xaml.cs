
using System.Windows;
using ClassMetier;

namespace NbMystere
{
    /// <summary>
    /// Logique d'interaction pour ShowPlayer.xaml
    /// </summary>
    public partial class ShowPlayer : Window
    {
        public ShowPlayer()
        {

            InitializeComponent();

        }
        private void onLoad(object sender, RoutedEventArgs e)
        {
           
            wlisteJoueurs.DataContext = MainWindow.listeJoueur ;

        }
    }
}
