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
    public partial class OthetForm : Form
    {
        public OthetForm()
        {
            InitializeComponent();
        }
        OthetC s = new OthetC();

        private bool flag;

        string[] Login1 = { "Jertyi", "Tiyos", "Ykiols", "Gerder", "Shalily", "Раскольников", "ТочноНе36", "Ленин" };
        string[] Deistvie = { "Пополнил" };
        string[] Doxod = { "100", "100000", "5000", "200", "100", "1000" };





        Random rng = new Random();
        int count = 0;

        public void GamerSeans()
        {
            while (flag)
            {
                string login1 = Login1[rng.Next(0, Login1.Length)];
                string deistvie = Deistvie[rng.Next(0, Deistvie.Length)];
                string doxod = Doxod[rng.Next(0, Doxod.Length)];

                s.Player(login1, deistvie, doxod);
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
            GamersSeans gamersSeans = new GamersSeans();
            gamersSeans.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
