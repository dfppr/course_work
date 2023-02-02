using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        Point lastPoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Authorization frm2 = new Authorization();
            frm2.Show();
            Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        public Boolean CheckUser()
        {
            string loginUser = loginField.Text;

            SQLiteConnection connect = new SQLiteConnection("Data Source=databasefile.db");
            connect.Open();

            SQLiteCommand command = connect.CreateCommand();
            command.Connection = connect;

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            command.CommandText = "SELECT * FROM `users` WHERE `login` = @login";

            command.Parameters.Add("@login", DbType.String).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже зарегистрирован, введите другой");
                return true;
            }
            else
                return false;
        }

        public void Check()
        {
            if (nameField.Text == "" || surnameField.Text == "" || loginField.Text == "" || passwordField.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            } // проверка на заполнение полей

           
                if (CheckUser())
            {
                return;
            } // проверка на наличие уже имеющегося пользователя
        } // проверки

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passwordField.Text;
            string nameUser = nameField.Text;
            string surnameUser = surnameField.Text;

            Check();

            SQLiteConnection connect = new SQLiteConnection("Data Source = databasefile.db");
            connect.Open();

            SQLiteCommand command = connect.CreateCommand();
            command.Connection = connect;

            command.CommandText = "INSERT INTO users (name, surname, login, password) VALUES (@name, @surname, @login, @password)";
            command.Parameters.AddWithValue("@name", nameUser);
            command.Parameters.AddWithValue("@surname", surnameUser);
            command.Parameters.AddWithValue("@login", loginUser);
            command.Parameters.AddWithValue("@password", passUser);
            int number = command.ExecuteNonQuery();

            if (number == 1)
            {
                MessageBox.Show("Аккаунт успешно создан");
                this.Hide(); 
                Authorization form_aut = new Authorization();
                form_aut.ShowDialog(); 
                this.Close();
            }
            
            else
            {
                MessageBox.Show("Ошибка регистрации");
            }
        }

        private void regLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization auth = new Authorization();
            auth.Show();
        }

        private void nameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void surnameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void loginField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void passwordField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
