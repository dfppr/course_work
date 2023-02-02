using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

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

        private void label5_Click(object sender, EventArgs e)
        {
            Register frm2 = new Register();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            } // проверка на заполнение полей

           
            string loginUser = LoginBox.Text;
            string passwordUser = PasswordBox.Text;

            SQLiteConnection connect = new SQLiteConnection("Data Source = databasefile.db");
            connect.Open();

            SQLiteCommand command = connect.CreateCommand();
            command.Connection = connect;

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            command.CommandText = "SELECT * FROM 'users' WHERE login = @login AND password = @password";

            command.Parameters.Add("@login", DbType.String).Value = LoginBox.Text;
            command.Parameters.Add("@password", DbType.String).Value = PasswordBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Успешная авторизация!");
                this.Hide(); 
                TicTacToeApp ticTacToe = new TicTacToeApp();
                ticTacToe.ShowDialog();
                this.Close(); 
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль!");
                LoginBox.Clear();
                PasswordBox.Clear();
            }
        }

        private void LoginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
