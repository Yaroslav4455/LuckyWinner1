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
    public partial class Statys : Form
    {
        public Statys()
        {
            InitializeComponent();
            BalansInd.Text =  BalansB.B;
            MessageBox.Show("Сначала нажать на сумму, потом на стрелочку, потом подтвердить оплату");
            
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

        private void VipBuy_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Statys` = @Statys WHERE `users`.`Login` = @Login;", db.getConnection());
            command.Parameters.Add("@Statys", MySqlDbType.VarChar).Value = "Vip";
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 10000 WHERE `users`.`Login` = @Login ;", db.getConnection());
            //command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //BalansB.B = (Convert.ToInt32(BalansB.B) - 10000).ToString();
            //MessageBox.Show("Ваш баланс " + BalansB.B);
            StatysS.S = "Vip";
            MessageBox.Show("вы Vip");

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainForm1 = new MainForm1();
            mainForm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balans1 balans1 = new Balans1();
            balans1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Statys` = @Statys WHERE `users`.`Login` = @Login;", db.getConnection());
            command.Parameters.Add("@Statys", MySqlDbType.VarChar).Value = "CC";
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 5000 WHERE `users`.`Login` = @Login ;", db.getConnection());
            //command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //BalansB.B = (Convert.ToInt32(BalansB.B) - 5000).ToString();
            //MessageBox.Show("Ваш баланс " + BalansB.B);
            StatysS.S = "Член Клуба";
            MessageBox.Show("вы член клуба");

            adapter.SelectCommand = command;
            adapter.Fill(table);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Statys` = @Statys WHERE `users`.`Login` = @Login;", db.getConnection());
            command.Parameters.Add("@Statys", MySqlDbType.VarChar).Value = "Sport";
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 2000 WHERE `users`.`Login` = @Login ;", db.getConnection());
            //command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //BalansB.B = (Convert.ToInt32(BalansB.B) - 2000).ToString();
            //MessageBox.Show("Ваш баланс " + BalansB.B);
            StatysS.S = "Sport";
            MessageBox.Show("вы Sport");

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 10000 WHERE `users`.`Login` = @Login ;", db.getConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            BalansB.B = (Convert.ToInt32(BalansB.B) - 10000).ToString();
            MessageBox.Show("Ваш баланс " + BalansB.B);


            //_ = new MySqlCommand("INSERT INTO `othetadmin` ( `Login1`, `Deistvie`, `Doxod`) VALUES ( @Login1, 'купил статус DBG', '10000');", db.getConnection());
            //command.Parameters.Add("@Login1", MySqlDbType.VarChar).Value = IDU.ID;
            
            //MessageBox.Show("готово");



            adapter.SelectCommand = command;
            adapter.Fill(table);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 5000 WHERE `users`.`Login` = @Login ;", db.getConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            BalansB.B = (Convert.ToInt32(BalansB.B) - 5000).ToString();
            MessageBox.Show("Ваш баланс " + BalansB.B);


            adapter.SelectCommand = command;
            adapter.Fill(table);


        }

        private void button9_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 2000 WHERE `users`.`Login` = @Login ;", db.getConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            BalansB.B = (Convert.ToInt32(BalansB.B) - 2000).ToString();
            MessageBox.Show("Ваш баланс " + BalansB.B);


            adapter.SelectCommand = command;
            adapter.Fill(table);

        }

        private void k_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `othetadmin` ( `Login1`, `Deistvie`, `Doxod`) VALUES ( @Login1, 'купил статус ВИП', '10000');", db.getConnection());
            command.Parameters.Add("@Login1", MySqlDbType.VarChar).Value = IDU.ID;

            MessageBox.Show("готово");



            adapter.SelectCommand = command;
            adapter.Fill(table);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `othetadmin` ( `Login1`, `Deistvie`, `Doxod`) VALUES ( @Login1, 'купил статус Член Клуба', '5000');", db.getConnection());
            command.Parameters.Add("@Login1", MySqlDbType.VarChar).Value = IDU.ID;

            MessageBox.Show("готово");



            adapter.SelectCommand = command;
            adapter.Fill(table);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `othetadmin` ( `Login1`, `Deistvie`, `Doxod`) VALUES ( @Login1, 'купил статус Start', '2000');", db.getConnection());
            command.Parameters.Add("@Login1", MySqlDbType.VarChar).Value = IDU.ID;

            MessageBox.Show("готово");



            adapter.SelectCommand = command;
            adapter.Fill(table);

        }
    }
}
