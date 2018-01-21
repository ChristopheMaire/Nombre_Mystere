
using System.Windows;
using ClassMetier;

namespace NbMystere
{
    /// <summary>
    /// Logique d'interaction pour NewPlayer.xaml
    /// </summary>
    public partial class NewPlayer : Window
    {
        public NewPlayer()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            lblTentative.Text = Joueur.nouveau_joueur(txtNom.Text, txtMdp.Text, MainWindow.listeJoueur);

         }
    }
}
