using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyWinner1
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
            FIO.Text = LoginL.L;
           STATYS.Text = StatysS.S;
            BRONI.Text = BronirovanieB.B;
            if (BRONI.Text == "У вас ничего не забронированно")
            {
                BRONI.ForeColor = Color.Red;
            }
            else
            {
                BRONI.ForeColor = Color.Green;
            }
            BalansInd.Text = BalansB.B;
        }

        private void clouseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bronirovanie bronirovanie = new Bronirovanie();
            bronirovanie.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statys statys = new Statys();
            statys.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balans1 balans1 = new Balans1();
            balans1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
