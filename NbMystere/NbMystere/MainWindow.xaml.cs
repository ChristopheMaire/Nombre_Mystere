using System;

using System.Windows;
using ClassMetier;

namespace NbMystere
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // "Parametre de l'application"
        public static ListJoueur listeJoueur = new ListJoueur();
        public static Joueur mainJoueur = new Joueur("","",0,0,0);
        public static Random rand = new Random();
        public static int nombre;



        public MainWindow()
        {
            //Charge la liste des joueur à l'ouvreture de l'application
            listeJoueur.Charger();


            InitializeComponent();

        }

        private void NewPlayer_Click(object sender, RoutedEventArgs e)
        {
           NewPlayer newplayer = new NewPlayer();
            newplayer.Show();
        }

        private void ShowPlayer_Click(object sender, RoutedEventArgs e)
        {
            ShowPlayer showplayer = new ShowPlayer();
            showplayer.Show();
        }

        private void Ident_Click(object sender, RoutedEventArgs e)
        {
            Identification ident = new Identification();
            ident.Show();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}
