using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySql
using MySql.Data.MySqlClient;
using System.Data;

namespace ClassMetier
{
    public class Joueur
    {
        string nom;
        string mdp;

        int nbpartie;
        int score;
        int nbcoup;

        public Joueur(string unNom, string unMdp, int NbPartie, int unScore, int unCoup)
        {
            nom = unNom;
            mdp = unMdp;
            nbpartie = NbPartie;
            score = unScore;
            nbcoup = unCoup;
        }
        public string Nom { get => nom; set => nom = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public int Nbpartie { get => nbpartie; set => nbpartie = value; }
        public int Score { get => score; set => score = value; }
        public int Nbcoup { get => nbcoup; set => nbcoup = value; }


        // Affichage du joueur
        public override string ToString()
        {
            return "Nom : " + nom + " \nParties Jouées : " + nbpartie + " \nCoups Min : " + nbcoup + "\nScore : " + score;
        }


        //Retourne une chaine str indiquant l'état d'ajout du joueur (Existant, Ajouté ou Champ vide)
        public static String nouveau_joueur(String nomE, String mdpE, ListJoueur listeJoueur)
        {

            // Si les entrées sont non vide
            if (nomE != "" && mdpE != "")
            {

                //Si le joueur existe (true) on affiche le texte
                foreach (Joueur j in listeJoueur)
                {
                    if (nomE == j.Nom)
                    {
                        return "Nom joueur existant. Ressayez.";

                    }

                }

                Joueur joueur = new Joueur(nomE, mdpE, 0, 0, 0);
                listeJoueur.Add(joueur);

                ajout_base(joueur);


                return joueur.nom + " Ajouté à la liste des joueurs !";

            }
            else
            {
                return "Erreur ! Champs de saisie vide. ";
            }

        }

        //Ajoute Joueur à la BDD 
        public static void ajout_base(Joueur j)
        {
            String connectionString = "SERVER=127.0.0.1;DATABASE=bddnbmystere;UID=root;PASSWORD=";
            MySqlConnection oConnection = new MySqlConnection(connectionString);

            MySqlCommand cmdAdd = oConnection.CreateCommand();
            cmdAdd.CommandText = "INSERT INTO `joueur` (`nom`, `mdp`, `nbcoup`, `nbpartie` ) VALUES ('" + j.nom + "', '" + j.mdp + "', '0', '0')";


            try
            {
                oConnection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            MySqlDataReader readcmdAdd = cmdAdd.ExecuteReader();

            readcmdAdd.Close();

            oConnection.Close();
        }


        //Met à jour les info du joueur dans la BDD
        public void MiseAJour(Joueur j)
        {
            if (j.Nbcoup == 0 || j.Nbcoup > j.Score)
            {
                j.Nbcoup = j.Score;
            }
            j.Nbpartie += 1;

            String connectionString = "SERVER=127.0.0.1;DATABASE=bddnbmystere;UID=root;PASSWORD=";
            MySqlConnection oConnection = new MySqlConnection(connectionString);

            MySqlCommand cmdUpd = oConnection.CreateCommand();
            cmdUpd.CommandText = "UPDATE `joueur` SET `nbcoup`= " + j.Nbcoup + ",`nbpartie`= " + j.Nbpartie + " WHERE nom = '" + j.nom + "'";

            try
            {
                oConnection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            MySqlDataReader readcmdAdd = cmdUpd.ExecuteReader();

            readcmdAdd.Close();

            oConnection.Close();


        }
    }
}
