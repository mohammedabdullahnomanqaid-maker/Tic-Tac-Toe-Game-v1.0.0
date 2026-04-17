
namespace Project_tic_tac_toe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbNameOfGame = new System.Windows.Forms.Label();
            this.picProgrammingP = new System.Windows.Forms.PictureBox();
            this.lbal1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.picProgrammingAdvice = new System.Windows.Forms.PictureBox();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbWhoIsWinner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProgrammingP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgrammingAdvice)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameOfGame
            // 
            this.lbNameOfGame.AutoSize = true;
            this.lbNameOfGame.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameOfGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNameOfGame.Location = new System.Drawing.Point(396, 9);
            this.lbNameOfGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameOfGame.Name = "lbNameOfGame";
            this.lbNameOfGame.Size = new System.Drawing.Size(261, 33);
            this.lbNameOfGame.TabIndex = 0;
            this.lbNameOfGame.Text = "Tic Tac Toe Game ";
            // 
            // picProgrammingP
            // 
            this.picProgrammingP.Location = new System.Drawing.Point(64, 42);
            this.picProgrammingP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picProgrammingP.Name = "picProgrammingP";
            this.picProgrammingP.Size = new System.Drawing.Size(148, 101);
            this.picProgrammingP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProgrammingP.TabIndex = 1;
            this.picProgrammingP.TabStop = false;
            // 
            // lbal1
            // 
            this.lbal1.AutoSize = true;
            this.lbal1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbal1.ForeColor = System.Drawing.Color.Yellow;
            this.lbal1.Location = new System.Drawing.Point(97, 146);
            this.lbal1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbal1.Name = "lbal1";
            this.lbal1.Size = new System.Drawing.Size(83, 31);
            this.lbal1.TabIndex = 2;
            this.lbal1.Text = "Turn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(81, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Winner";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(44, 310);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(177, 47);
            this.btnRestartGame.TabIndex = 4;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // picProgrammingAdvice
            // 
            this.picProgrammingAdvice.BackColor = System.Drawing.SystemColors.Desktop;
            this.picProgrammingAdvice.Location = new System.Drawing.Point(44, 375);
            this.picProgrammingAdvice.Name = "picProgrammingAdvice";
            this.picProgrammingAdvice.Size = new System.Drawing.Size(177, 62);
            this.picProgrammingAdvice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProgrammingAdvice.TabIndex = 5;
            this.picProgrammingAdvice.TabStop = false;
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.Location = new System.Drawing.Point(80, 177);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(122, 32);
            this.lbTurn.TabIndex = 16;
            this.lbTurn.Text = "Player 1";
            // 
            // lbWhoIsWinner
            // 
            this.lbWhoIsWinner.AutoSize = true;
            this.lbWhoIsWinner.Font = new System.Drawing.Font("PT Simple Bold Ruled", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbWhoIsWinner.Location = new System.Drawing.Point(57, 257);
            this.lbWhoIsWinner.Name = "lbWhoIsWinner";
            this.lbWhoIsWinner.Size = new System.Drawing.Size(167, 38);
            this.lbWhoIsWinner.TabIndex = 17;
            this.lbWhoIsWinner.Text = "In Progress";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(315, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 87);
            this.button1.TabIndex = 18;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(463, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 87);
            this.button2.TabIndex = 27;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(607, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 87);
            this.button3.TabIndex = 28;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(315, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 98);
            this.button4.TabIndex = 29;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(463, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 98);
            this.button5.TabIndex = 30;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(607, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 98);
            this.button6.TabIndex = 31;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(315, 310);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 91);
            this.button7.TabIndex = 32;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(463, 310);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 91);
            this.button8.TabIndex = 33;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Project_tic_tac_toe.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(607, 310);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 91);
            this.button9.TabIndex = 34;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbWhoIsWinner);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.picProgrammingAdvice);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbal1);
            this.Controls.Add(this.picProgrammingP);
            this.Controls.Add(this.lbNameOfGame);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picProgrammingP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgrammingAdvice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameOfGame;
        private System.Windows.Forms.PictureBox picProgrammingP;
        private System.Windows.Forms.Label lbal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.PictureBox picProgrammingAdvice;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbWhoIsWinner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

