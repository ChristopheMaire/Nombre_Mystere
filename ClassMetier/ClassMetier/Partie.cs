using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassMetier
{
    public class Partie
    {

        public static string Rungame(int nombre, Joueur joueur, String tmp)
        {


            int testnb;

            //Test si le string peut se convertir en Int
            if (!(Int32.TryParse(tmp, out testnb)))
            {
                return "Entrer un nombre !! ";
            }
            testnb = Convert.ToInt32(tmp);

            if (testnb > nombre)
            {
                joueur.Score += 1;
                return "Trop Grand. \n nombre < " + testnb + ".";
            }
            else
            {
                if (testnb < nombre)
                {
                    joueur.Score += 1;
                    return "Trop petit. \n nombre > " + testnb + ".";
                }

                else
                {
                    joueur.Score += 1;
                    joueur.MiseAJour(joueur);
                    joueur.Score = 0;
                    return "Trouvé. \n nombre = " + testnb + ".";


                }
            }
        }
    }
}
