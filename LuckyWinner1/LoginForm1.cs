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
  
    public partial class LoginForm1 : Form
    {
        //static class Global
        //{
        //    private static string _globalVar = "";

        //    public static string GlobalVar
        //    {
        //        get { return _globalVar; }
        //        set { _globalVar = value; }
        //    }
        //}
        int id = 12345684;
        public LoginForm1()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
        }

        private void clouseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); 
        } 

        Point LastPoint;
        
        private void LoginForm1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void LoginForm1_MouseDown(object sender, MouseEventArgs e)
        {   
            LastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "admin")
            {
                this.Hide();
     GamersSeans formSeans = new GamersSeans();
                formSeans.Show();
            }
            else { 
            String LoginUser = loginField.Text;
            String passUser = passField.Text;
            
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login`=@uL AND `Password`= @uP", db.getConnection());
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP",MySqlDbType.VarChar).Value = passUser;
                IDU.ID = LoginUser;
                LoginL.L = LoginUser;
                MessageBox.Show(IDU.ID);

                adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                  
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    this.Hide();
                MainForm1 mainForm1 = new MainForm1();
                mainForm1.Show();


            }
            else 
                MessageBox.Show("No");
            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
                

                DB db = new DB();

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Statys`=@s AND `Name`= @m  AND `Bronirovanie`=@br ", db.getConnection());
                command.Parameters.Add("@m", MySqlDbType.VarChar).Value = NameN.N;
                command.Parameters.Add("@s", MySqlDbType.VarChar).Value = StatysS.S;
            command.Parameters.Add("@br", MySqlDbType.VarChar).Value = BronirovanieB.B;



            adapter.SelectCommand = command;
                adapter.Fill(table);

                
                
        }
    }
}
