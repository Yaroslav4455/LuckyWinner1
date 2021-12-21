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

    public partial class Bronirovanie : Form
    {
        //int id = 12345684;
        
        public Bronirovanie()
        {
            InitializeComponent();
            BalansInd.Text =  BalansB.B;
            MessageBox.Show("Сначала нажать на сумму, потом на стрелочку, потом ярлык игры");
            MessageBox.Show("Я бы мог реализовать это через открывающиеся окна, но я устал");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statys statys = new Statys();
            statys.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainForm1 = new MainForm1();
            mainForm1.Show();
        }

        private void durack_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Bronirovanie` = @Bronirovanie WHERE `users`.`Login` = @Login;", db.getConnection());
            command.Parameters.Add("@Bronirovanie", MySqlDbType.VarChar).Value = "1";
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 100 WHERE `users`.`Login` = @Login ;", db.getConnection());
            //command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //BalansB.B = (Convert.ToInt32(BalansB.B) - 100).ToString();
            //MessageBox.Show("Ваш баланс " +BalansB.B);
//Специально не убираю код, чтоб показать что я пытался реализовать и баланс и бронирование через одну кнопку, я пишу все правильно, но не работает

            MessageBox.Show("вы успешно забронированы");
            BronirovanieB.B = "У вас забронированна игра в дурака";


            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tyrnirs1 tyrnirs1 = new Tyrnirs1();
            tyrnirs1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Balans1 balans1 = new Balans1();
            balans1.Show();
        }

        private void kostiy_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Bronirovanie` = @Bronirovanie WHERE `users`.`Login` = @Login;", db.getConnection());
            command.Parameters.Add("@Bronirovanie", MySqlDbType.VarChar).Value = "2";
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 200 WHERE `users`.`Login` = @Login ;", db.getConnection());
            //command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //BalansB.B = (Convert.ToInt32(BalansB.B) - 200).ToString();
            //MessageBox.Show("Ваш баланс " + BalansB.B);
            MessageBox.Show("вы успешно забронированы");
            BronirovanieB.B = "У вас забронированна игра в кости";

            adapter.SelectCommand = command;
            adapter.Fill(table);

        }

        private void casino_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Bronirovanie` = @Bronirovanie WHERE `users`.`Login` = @Login;", db.getConnection());
            command.Parameters.Add("@Bronirovanie", MySqlDbType.VarChar).Value = "3";
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 300 WHERE `users`.`Login` = @Login ;", db.getConnection());
            //command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //BalansB.B = (Convert.ToInt32(BalansB.B) - 300).ToString();
   
            MessageBox.Show("вы успешно забронированы");
            BronirovanieB.B = "У вас забронированна игра в автоматы";

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void pokker_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Bronirovanie` = @Bronirovanie WHERE `users`.`Login` = @Login;", db.getConnection());
            command.Parameters.Add("@Bronirovanie", MySqlDbType.VarChar).Value = "4";
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 400 WHERE `users`.`Login` = @Login ;", db.getConnection());
            //command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            //BalansB.B = (Convert.ToInt32(BalansB.B) - 400).ToString();
            //MessageBox.Show("Ваш баланс " + BalansB.B);
            MessageBox.Show("вы успешно забронированы");
            BronirovanieB.B = "У вас забронированна игра в покер";

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        

        private void buyOne_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 100 WHERE `users`.`Login` = @Login ;", db.getConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            BalansB.B = (Convert.ToInt32(BalansB.B) - 100).ToString();
            MessageBox.Show("Ваш баланс " + BalansB.B);
            MessageBox.Show("Для подтверждения нажмите на иконку игры");

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void buyTwo_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 200 WHERE `users`.`Login` = @Login ;", db.getConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            BalansB.B = (Convert.ToInt32(BalansB.B) - 200).ToString();
            MessageBox.Show("Ваш баланс " + BalansB.B);
            MessageBox.Show("Для подтверждения нажмите на иконку игры");

            adapter.SelectCommand = command;
            adapter.Fill(table);

        }

        private void buy3_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 300 WHERE `users`.`Login` = @Login ;", db.getConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            BalansB.B = (Convert.ToInt32(BalansB.B) - 300).ToString();
            MessageBox.Show("Ваш баланс " + BalansB.B);
            MessageBox.Show("Для подтверждения нажмите на иконку игры");

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void buy4_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Balans` = `Balans` - 400 WHERE `users`.`Login` = @Login ;", db.getConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = IDU.ID;
            BalansB.B = (Convert.ToInt32(BalansB.B) - 400).ToString();
            MessageBox.Show("Ваш баланс " + BalansB.B);
            MessageBox.Show("Для подтверждения нажмите на иконку игры");

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void dalee1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `othetadmin` ( `Login1`, `Deistvie`, `Doxod`) VALUES ( @Login1, 'Забронировал игру в дурака', '100');", db.getConnection());
            command.Parameters.Add("@Login1", MySqlDbType.VarChar).Value = IDU.ID;

            MessageBox.Show("Для подтверждения нажмите на иконку игры");



            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void dalee2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `othetadmin` ( `Login1`, `Deistvie`, `Doxod`) VALUES ( @Login1, 'Забронировал игру в кости', '200');", db.getConnection());
            command.Parameters.Add("@Login1", MySqlDbType.VarChar).Value = IDU.ID;

            MessageBox.Show("Для подтверждения нажмите на иконку игры");



            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void dalee3_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `othetadmin` ( `Login1`, `Deistvie`, `Doxod`) VALUES ( @Login1, 'Забронировал игру в автоматы', '300');", db.getConnection());
            command.Parameters.Add("@Login1", MySqlDbType.VarChar).Value = IDU.ID;

            MessageBox.Show("Для подтверждения нажмите на иконку игры");



            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void dalee4_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `othetadmin` ( `Login1`, `Deistvie`, `Doxod`) VALUES ( @Login1, 'Забронировал игру в покер', '400');", db.getConnection());
            command.Parameters.Add("@Login1", MySqlDbType.VarChar).Value = IDU.ID;

            MessageBox.Show("Для подтверждения нажмите на иконку игры");



            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
    }
}
