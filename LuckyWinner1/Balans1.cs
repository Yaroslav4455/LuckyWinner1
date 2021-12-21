using MySql.Data.MySqlClient;
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
    public partial class Balans1 : Form
    {
        public Balans1()
        {
            InitializeComponent();
            BalansInd.Text = BalansB.B;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainForm1 = new MainForm1();
            mainForm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Balans` = @Balans WHERE `users`.`Login` = @Login;", db.getConnection());
           
            command.Parameters.Add("@Balans", MySqlDbType.VarChar).Value = BalanField.Text;
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
             
            MessageBox.Show("баланс пополнен"); 
            BalansB.B = BalanField.Text; 
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
    }
}
