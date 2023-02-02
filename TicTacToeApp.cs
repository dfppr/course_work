using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
   //00 01 02
   //10 11 12
   //20 21 22
     
    public partial class TicTacToeApp : Form
    {
        public void ticTacToe()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((a[0, i] != -1) && (a[0, i] == a[1, i]) && (a[0, i] == a[2, i]))
                {
                    if (a[0, i] == 1)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            pic[j, i].Image = Image.FromFile("2.jpg");

                            for (int a = 0; a < 3; a++)
                                for (int b = 0; b < 3; b++)
                                    but[b, a].Enabled = false;

                            Xwon.Visible = true;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            pic[j, i].Image = Image.FromFile("2.2.jpg");

                            for (int a = 0; a < 3; a++)
                                for (int b = 0; b < 3; b++)
                                    but[b, a].Enabled = false;

                            Owon.Visible = true;
                        }
                    }
                    break;
                }

                else
                {
                if ((a[i, 0] != -1) && (a[i, 0] == a[i, 1]) && (a[i, 0] == a[i, 2]))
                {
                    if (a[i, 0] == 1)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            pic[i, j].Image = Image.FromFile("3.jpg");

                            for (int a = 0; a < 3; a++)
                                for (int b = 0; b < 3; b++)
                                    but[b, a].Enabled = false;
                            Xwon.Visible = true;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            pic[i, j].Image = Image.FromFile("3.2.jpg");

                            for (int a = 0; a < 3; a++)
                                for (int b = 0; b < 3; b++)
                                    but[b, a].Enabled = false;

                            Owon.Visible = true;
                        }
                    }
                    break;
                }
            }
            }
            if ((a[0, 0] != -1) && (a[0, 0] == a[1, 1]) && (a[0, 0] == a[2, 2]))
            {
                if (a[0, 0] == 1)
                {
                    pic[0, 0].Image = Image.FromFile("5.jpg");
                    pic[1, 1].Image = Image.FromFile("5.jpg");
                    pic[2, 2].Image = Image.FromFile("5.jpg");

                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            but[i, j].Enabled = false;

                    Xwon.Visible = true;
                }

                else
                {
                    pic[0, 0].Image = Image.FromFile("5.2.jpg");
                    pic[1, 1].Image = Image.FromFile("5.2.jpg");
                    pic[2, 2].Image = Image.FromFile("5.2.jpg");

                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            but[i, j].Enabled = false;

                    Owon.Visible = true;
                }
            }

            if ((a[0, 2] != -1) && (a[0, 2] == a[1, 1]) && (a[0, 2] == a[2, 0]))
            {
                if (a[0, 2] == 1)
                {
                    pic[0, 2].Image = Image.FromFile("4.jpg");
                    pic[1, 1].Image = Image.FromFile("4.jpg");
                    pic[2, 0].Image = Image.FromFile("4.jpg");
                    btnClear.Visible = true;

                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            but[i, j].Enabled = false;

                    Xwon.Visible = true;
                }
                else
                {
                    pic[0, 2].Image = Image.FromFile("4.2.jpg");
                    pic[1, 1].Image = Image.FromFile("4.2.jpg");
                    pic[2, 0].Image = Image.FromFile("4.2.jpg");
                    btnClear.Visible = true;

                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            but[i, j].Enabled = false;

                    Owon.Visible = true;
                }
            }
        }

        public Button[,] but = new Button[3, 3];
        public PictureBox[,] pic = new PictureBox[3, 3];
        int[,] a = new int[3, 3];
        int c = 1;

        public TicTacToeApp()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = -1;

                    but[i, j] = new Button();
                    pic[i, j] = new PictureBox();

                    but[i, j].Size = new Size(55, 55);
                    pic[i, j].Size = new Size(55, 55);

                    but[i, j].Location = new Point(55 + 55 * i, 55 + 55 * j);
                    pic[i, j].Location = new Point(55 + 55 * i, 55 + 55 * j);

                    but[i, j].Click += new EventHandler(play);
                    this.Controls.Add(but[i, j]);
                    this.Controls.Add(pic[i, j]);
                    but[i, j].Visible = false;

                }
            }
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    but[i, j].Visible = true;
                    startGame.Enabled = false;
                }
            }
        }
        public void play(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int i = btn.Location.X / 70;
            int j = btn.Location.Y / 70;
            but[i, j].Visible = false;
            a[i, j] = c % 2;
            pic[i, j].Image = Image.FromFile(a[i, j].ToString() + ".png");
            c++;
            ticTacToe();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c = 1;
                    a[i, j] = -1;

                    but[i, j].Visible = true;
                    but[i, j].Enabled = true;
                }
            }
            Xwon.Visible = false;
            Owon.Visible = false;   
            XandO.Visible = false;
        }

        Point lastPoint;
        private void label1_MouseDown(object sender, MouseEventArgs e)
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

        private void TicTacToeApp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TicTacToeApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
