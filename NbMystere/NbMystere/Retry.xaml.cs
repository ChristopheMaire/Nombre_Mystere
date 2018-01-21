
using System.Windows;
using ClassMetier;

namespace NbMystere
{
    /// <summary>
    /// Logique d'interaction pour Retry.xaml
    /// </summary>
    public partial class Retry : Window
    {
        public Retry()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            //Génération du nombre aléatoire à trouver
            MainWindow.nombre = MainWindow.rand.Next(100);
            MainWindow.mainJoueur.Score = 0;
            RunWin runwin = new RunWin();
            runwin.Show();

            this.Close();
        }

        private void noButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
