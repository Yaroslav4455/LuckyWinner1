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
    class OthetC
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=casinouser");
        public ArrayList Seans()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM othetadmin", connection);
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

        public bool Player(string Login1, string Deistvie, string Doxod)
        {

            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO othetadmin(Login1, Deistvie, Doxod) VALUES (@Login1, @Deistvie, @Doxod )", connection);
            command.Parameters.AddWithValue("@Login1", Login1);
            command.Parameters.AddWithValue("@Deistvie", Deistvie);
            command.Parameters.AddWithValue("@Doxod", Doxod);

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
