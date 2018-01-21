
using System.Windows;
using ClassMetier;

namespace NbMystere
{
    /// <summary>
    /// Logique d'interaction pour RunWin.xaml
    /// </summary>
    public partial class RunWin : Window
    {
        public RunWin()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, RoutedEventArgs e)
        {

            //Lancement
            lblTentativePartie.Text = Partie.Rungame(MainWindow.nombre, MainWindow.mainJoueur, txtNb.Text); 


            //Recommencer ?
            if (lblTentativePartie.Text == "Trouvé. \n nombre = " + MainWindow.nombre + ".") {
                this.Close();

                Retry retry = new Retry();
                retry.Show();
                
            }
        }
    }
}
