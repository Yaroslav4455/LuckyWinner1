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
    class Gamers
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=casinouser");
        public ArrayList Seans()
        {
            ArrayList list = new ArrayList();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM users", connection);
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

        public bool Player(string Login, string Password, string Name, string Surname, string Statys, string Bronirovanie)
        {

            bool flag = false;
            MySqlCommand command = new MySqlCommand($"INSERT INTO users(Login, password, name, surname, Statys, Bronirovanie ) VALUES (@Login, @password, @name , @surname, @Statys, @Bronirovanie)", connection);
            command.Parameters.AddWithValue("@Login", Login);
            command.Parameters.AddWithValue("@password", Password);
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@surname", Surname);
            command.Parameters.AddWithValue("@Statys", Statys);
            command.Parameters.AddWithValue("@Bronirovanie", Bronirovanie);
           
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
