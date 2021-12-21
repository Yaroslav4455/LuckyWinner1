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
    public partial class GamersSeans : Form
    {
        public GamersSeans()
        {
            InitializeComponent();
        }
        Gamers s = new Gamers();

        private bool flag;

        string[] Login = { "Jertyi", "Tiyos", "Ykiols", "Gerder", "Shalily", "Раскольников", "ТочноНе36", "Ленин" };
        string[] Password = { "11111", "1234565", "6546578", "654321", "234ен", "суперзащита", "пинкодоткарты", "прико" };
        string[] Name = { "Валерия", "Екатерина","Машка", "Галина", "Петька", "Евгения" };
        string[] Surname = { "Калмвкова", "Викторовская", "Камаровская" };
        string[] Statys = { "Vip", "Sport", "CC" };
        string[] Bronirovanie = { "1", "2","3", "4" };

        


        Random rng = new Random();
        int count = 0;

        public void GamerSeans()
        {
            while (flag)
            {
                string login = Login[rng.Next(0, Login.Length)];
                string password = Password[rng.Next(0,Password.Length)];
                string name = Name[rng.Next(0, Name.Length)];
                string surname = Surname[rng.Next(0, Surname.Length)];
                string statys = Statys[rng.Next(0, Statys.Length)];
                string bronirovanie = Bronirovanie[rng.Next(0, Bronirovanie.Length)];
                s.Player(login, password, name, surname, statys, bronirovanie);
                count++;
                label1.Invoke(new Action(() => label1.Text = count.ToString()));
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            Task.Run(() => GamerSeans());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
        }



        

        private void FormSeans_Load_1(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = s.Seans();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = s.Seans();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OthetForm othetForm = new OthetForm();
            othetForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
