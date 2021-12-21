using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LuckyWinner1
{
    internal class ClassTurnirs
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=casinouser");
        public ArrayList Seans()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM turnirs", connection);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                foreach (DbDataRecord result in dr)
                {
                    list.Add(result);
                }
            }
            connection.Close();
            return list;
        }

        public bool Add_to_Turnirs(string Namegame, string Maxchel, string Lvl, string Prizi, string Yslovie)
        {

            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO turnirs(Namegame, Maxchel, Lvl, Prizi, Yslovie) VALUES (@Namegame, @Maxchel, @Lvl , @Prizi, @Yslovie)", connection);
            command.Parameters.AddWithValue("@Namegame", Namegame);
            command.Parameters.AddWithValue("@Maxchel", Maxchel);
            command.Parameters.AddWithValue("@Lvl", Lvl);
            command.Parameters.AddWithValue("@Prizi", Prizi);
            command.Parameters.AddWithValue("@Yslovie", Yslovie);
            

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                flag = true;
            }
            connection.Close();
            return flag;
        }

    }
}
