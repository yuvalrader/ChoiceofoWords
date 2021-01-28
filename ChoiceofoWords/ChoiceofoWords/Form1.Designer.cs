
namespace ChoiceofoWords
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
            this.components = new System.ComponentModel.Container();
            this.player1 = new System.Windows.Forms.ListBox();
            this.player2 = new System.Windows.Forms.ListBox();
            this.LetterBank = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddWord = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.CheckWhoWon = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AccessibleName = "player1";
            this.player1.BackColor = System.Drawing.Color.Red;
            this.player1.FormattingEnabled = true;
            this.player1.ItemHeight = 37;
            this.player1.Location = new System.Drawing.Point(1151, 241);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(496, 744);
            this.player1.TabIndex = 0;
            this.player1.SelectedIndexChanged += new System.EventHandler(this.player1_SelectedIndexChanged);
            // 
            // player2
            // 
            this.player2.AccessibleName = "player2";
            this.player2.BackColor = System.Drawing.Color.Blue;
            this.player2.FormattingEnabled = true;
            this.player2.ItemHeight = 37;
            this.player2.Location = new System.Drawing.Point(1847, 241);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(511, 744);
            this.player2.TabIndex = 0;
            this.player2.SelectedIndexChanged += new System.EventHandler(this.player1_SelectedIndexChanged);
            // 
            // LetterBank
            // 
            this.LetterBank.BackColor = System.Drawing.Color.White;
            this.LetterBank.FormattingEnabled = true;
            this.LetterBank.ItemHeight = 37;
            this.LetterBank.Location = new System.Drawing.Point(58, 241);
            this.LetterBank.Name = "LetterBank";
            this.LetterBank.Size = new System.Drawing.Size(173, 744);
            this.LetterBank.TabIndex = 0;
            this.LetterBank.SelectedIndexChanged += new System.EventHandler(this.LetterBank_SelectedIndexChanged);
            this.LetterBank.DoubleClick += new System.EventHandler(this.LetterBank_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1153, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1853, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "player2";
            // 
            // AddWord
            // 
            this.AddWord.AccessibleName = "AddWord";
            this.AddWord.Location = new System.Drawing.Point(462, 467);
            this.AddWord.Name = "AddWord";
            this.AddWord.Size = new System.Drawing.Size(264, 79);
            this.AddWord.TabIndex = 2;
            this.AddWord.Text = "AddWord";
            this.AddWord.UseVisualStyleBackColor = true;
            this.AddWord.Click += new System.EventHandler(this.AddWord_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 341);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 77);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "LetterBank";
            // 
            // Delete
            // 
            this.Delete.AccessibleName = "Delete";
            this.Delete.Location = new System.Drawing.Point(462, 600);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(264, 79);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2077, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(381, 77);
            this.textBox2.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.AccessibleName = "Start";
            this.Start.Location = new System.Drawing.Point(-5, 1148);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(416, 118);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // CheckWhoWon
            // 
            this.CheckWhoWon.AccessibleName = "CheckWhoWon";
            this.CheckWhoWon.Location = new System.Drawing.Point(1586, 1078);
            this.CheckWhoWon.Name = "CheckWhoWon";
            this.CheckWhoWon.Size = new System.Drawing.Size(316, 105);
            this.CheckWhoWon.TabIndex = 6;
            this.CheckWhoWon.Text = "Check who won";
            this.CheckWhoWon.UseVisualStyleBackColor = true;
            this.CheckWhoWon.Click += new System.EventHandler(this.CheckWhoWon_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.AccessibleName = "PlayAgain";
            this.PlayAgain.Location = new System.Drawing.Point(-5, 6);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(422, 83);
            this.PlayAgain.TabIndex = 7;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // setting
            // 
            this.setting.AccessibleName = "setting ";
            this.setting.Location = new System.Drawing.Point(2108, 1149);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(360, 117);
            this.setting.TabIndex = 8;
            this.setting.Text = "setting ";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2496, 1266);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.CheckWhoWon);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.LetterBank);
            this.Controls.Add(this.player1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox player1;
        private System.Windows.Forms.ListBox player2;
        private System.Windows.Forms.ListBox LetterBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddWord;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button CheckWhoWon;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Button setting;
    }
}

