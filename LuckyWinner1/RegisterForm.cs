﻿using MySql.Data.MySqlClient;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;
            passField.Text = "введите пароль";
            passField.ForeColor = Color.Gray;
            loginField.Text = "введите логин";
            loginField.ForeColor = Color.Gray;

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя") 
            {
                MessageBox.Show("Введите имя");
            return;
            }
            if (userSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (passField.Text == "введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (loginField.Text == "введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `Login`, `Password`, `Name`, `Surname`,`Statys`,`Bronirovanie` ) VALUES (@login, @password, @name, @surname, @statys, @bronirivanie)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
            command.Parameters.Add("@statys", MySqlDbType.VarChar).Value = "";
            command.Parameters.Add("@bronirivanie", MySqlDbType.VarChar).Value = "0";

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Вы успешно зарегестрированы");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();

        }

        private void clouseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        Point LastPoint;

        public object MySqlComment { get; private set; }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.ForeColor = Color.Black;
                userNameField.Text = "";
            }
            
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            { 
            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
            }
                
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.ForeColor = Color.Black;
                userSurnameField.Text = "";
            }

        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "введите логин")
            {
                loginField.ForeColor = Color.Black;
                loginField.Text = "";
            }

        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "введите логин";
                loginField.ForeColor = Color.Gray;
            }

        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "введите пароль")
            {
                passField.ForeColor = Color.Black;
                passField.Text = "";
            }

        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "введите пароль";
                passField.ForeColor = Color.Gray;
            }

        }

        
        
        public Boolean isUserExists()
        {

            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login`=@uL ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите новый");
                return true;
            }
                
            else
                return false;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm1 loginForm1 = new LoginForm1();
            loginForm1.Show();
        }
    }
} 
