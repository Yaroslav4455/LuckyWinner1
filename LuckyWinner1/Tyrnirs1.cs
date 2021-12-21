using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyWinner1
{
    public partial class Tyrnirs1 : Form
    {
        public Tyrnirs1()
        {
            InitializeComponent();
        }

        ClassTurnirs s = new ClassTurnirs();

        private bool flag;

        string[] Namegame = { "Дурак", "Кости", "Покер", "Казино" };
        string[] Maxchel = { "2", "4", "6", "8", "10", "12", "14", "11" };
        string[] Lvl = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };
        string[] Prizi = { "10000000", "10000", "Кубок", "1500", "20000", "30000", "100", "60000", "40000" };
        string[] Yslovie = { "быть в костюмах", "все в масках животных", "кто програл тот лох, а кто выиграл крутой" };
        




        Random rng = new Random();
        int count = 0;
        public void NewSeans()
        {
            while (flag)
            {
                string namegame = Namegame[rng.Next(0, Namegame.Length)];
                string maxchel = Maxchel[rng.Next(0, Maxchel.Length)];
                string lvl = Lvl[rng.Next(0, Lvl.Length)];
                string prizi = Prizi[rng.Next(0, Prizi.Length)];
                string yslovie = Yslovie[rng.Next(0, Yslovie.Length)];

                s.Add_to_Turnirs(namegame, maxchel, lvl, prizi, yslovie);
                count++;
                label1.Invoke(new Action(() => label1.Text = count.ToString()));
                Thread.Sleep(1000);
            }
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            flag = true;
            Task.Run(() => NewSeans());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void spisokTyrnir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           spisokTyrnir.DataSource = s.Seans();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            spisokTyrnir.DataSource = s.Seans();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `TyrnirsID` = @TyrnirsID WHERE `users`.`Login` = @Login;", db.getConnection());
            command.Parameters.Add("@TyrnirsID", MySqlDbType.VarChar).Value = TyrnirField.Text;
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            MessageBox.Show("вы успешно забронированы");
           
            adapter.SelectCommand = command;
            adapter.Fill(table);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TyrnirField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainForm1 = new MainForm1();
            mainForm1.Show();
        }
    }
}
