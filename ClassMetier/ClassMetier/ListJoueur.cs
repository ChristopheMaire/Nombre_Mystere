using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

// Librairie MySql
using MySql.Data.MySqlClient;

namespace ClassMetier
{
    public class ListJoueur : List<Joueur>
    {

        public ListJoueur(params Joueur[] listjoueurs)
        {
            Remplir(listjoueurs);
        }

        public void Remplir(Joueur[] listjoueurs)
        {
            foreach (Joueur joueur in listjoueurs)
            {
                Add(joueur);
            }
        }

        public void Charger()
        {
            String connectionString = "SERVER=127.0.0.1;DATABASE=bddnbmystere;UID=root;PASSWORD=";
            MySqlConnection oConnection = new MySqlConnection(connectionString);


            try
            {
                oConnection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            DataSet oDataSet = new DataSet("joueur");

            String strRequete = "SELECT * FROM joueur";
            MySqlDataAdapter oSqlDataAdapter = new MySqlDataAdapter(strRequete, oConnection);

            MySqlCommandBuilder oBuilder = new MySqlCommandBuilder(oSqlDataAdapter);

            oSqlDataAdapter.Fill(oDataSet, "joueur");


            for (int i = 0; i < oDataSet.Tables["joueur"].Rows.Count; i++)
            {

                this.Add(new Joueur(oDataSet.Tables["joueur"].Rows[i][0].ToString(), oDataSet.Tables["joueur"].Rows[i][1].ToString(), Int32.Parse(oDataSet.Tables["joueur"].Rows[i][2].ToString()), 0, Int32.Parse(oDataSet.Tables["joueur"].Rows[i][3].ToString())));

            }

            oConnection.Close();

            /*
            this.Add(new Joueur("Paul","paul",0,0,0));
            this.Add(new Joueur("Pierre","pierre",0,0,0));
            this.Add(new Joueur("Jean","jean",0,0,0));*/

        }
    }


}
