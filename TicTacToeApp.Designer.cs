
namespace TicTacToe
{
    partial class TicTacToeApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Label();
            this.Xwon = new System.Windows.Forms.Label();
            this.Owon = new System.Windows.Forms.Label();
            this.XandO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(116)))));
            this.btnClear.Location = new System.Drawing.Point(275, 85);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Очистить поле";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.startGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(116)))));
            this.startGame.Location = new System.Drawing.Point(275, 56);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(157, 23);
            this.startGame.TabIndex = 29;
            this.startGame.Text = "Начать игру";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(67)))), ((int)(((byte)(116)))));
            this.closeBtn.Location = new System.Drawing.Point(468, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(14, 13);
            this.closeBtn.TabIndex = 31;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Xwon
            // 
            this.Xwon.AutoSize = true;
            this.Xwon.Location = new System.Drawing.Point(301, 158);
            this.Xwon.Name = "Xwon";
            this.Xwon.Size = new System.Drawing.Size(107, 13);
            this.Xwon.TabIndex = 32;
            this.Xwon.Text = "Крестики выиграли";
            this.Xwon.Visible = false;
            // 
            // Owon
            // 
            this.Owon.AutoSize = true;
            this.Owon.Location = new System.Drawing.Point(301, 158);
            this.Owon.Name = "Owon";
            this.Owon.Size = new System.Drawing.Size(97, 13);
            this.Owon.TabIndex = 33;
            this.Owon.Text = "Нолики выиграли";
            this.Owon.Visible = false;
            // 
            // XandO
            // 
            this.XandO.AutoSize = true;
            this.XandO.Location = new System.Drawing.Point(336, 158);
            this.XandO.Name = "XandO";
            this.XandO.Size = new System.Drawing.Size(38, 13);
            this.XandO.TabIndex = 34;
            this.XandO.Text = "Ничья";
            this.XandO.Visible = false;
            // 
            // TicTacToeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(494, 279);
            this.Controls.Add(this.XandO);
            this.Controls.Add(this.Owon);
            this.Controls.Add(this.Xwon);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicTacToeApp";
            this.Text = "TicTacToeApp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TicTacToeApp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TicTacToeApp_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label Xwon;
        private System.Windows.Forms.Label Owon;
        private System.Windows.Forms.Label XandO;
    }
}