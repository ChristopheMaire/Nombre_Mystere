
using System.Windows;
using ClassMetier;

namespace NbMystere
{
    /// <summary>
    /// Logique d'interaction pour Identification.xaml
    /// </summary>
    public partial class Identification : Window
    {
        public Identification()
        {
            InitializeComponent();
        }

        private void identButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(Joueur j in MainWindow.listeJoueur) {



                if (txtNomIdent.Text == j.Nom && txtMdpIdent.Text == j.Mdp) {

                    //Lancement jeu
                    RunWin runwin = new RunWin();
                    runwin.Show();

                    //Cacher bouton "Lancer" : Evite de lancer plusieurs partie en même temps + Affichage Connecté
                    identButton.Visibility = Visibility.Hidden;

                    // Nouvel affichage
                    txtMdpIdent.Visibility = Visibility.Hidden;
                    lblMdpIdent.Visibility = Visibility.Hidden;
                    txtNomIdent.Visibility = Visibility.Hidden;
                    lblNomIdent.Visibility = Visibility.Hidden;
                    
                    lblTitleIdentification.Text = "Prêt pour une partie ?";

                    /* -------- Initialisation de la partie ! ------------ */

                    //Le mainJoueur prend les attributs du joueur connecté
                    j.Score = 0;
                    MainWindow.mainJoueur = j;
                    
                    // Affichage du nom du joueur
                    lblTentativeIdent.Visibility = Visibility.Visible;
                    lblTentativeIdent.Text = "Connecté, en Tant que \n" + MainWindow.mainJoueur.Nom + " !";

                    //Génération du nombre aléatoire à trouver
                    MainWindow.nombre = MainWindow.rand.Next(100);
 
                    //Sortie Boucle quand joueur trouvé
                    break;

                }

                else {
                    //Joueur Introuvable
                    lblTitleIdentification.Text = "Joueur inconnus.";
                }
            }
        }
    }
}
