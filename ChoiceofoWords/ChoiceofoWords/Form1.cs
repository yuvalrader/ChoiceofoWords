using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoiceofoWords
{
    public partial class Form1 : Form
    {
        private char[] Letter = new char[26];
        private Random randomLetter = new Random();
        private string word = "";
        private int time = 0;
        private static int turnLength = 60;
        private bool turn = false;
        private static int numOfLetter = 5;
        private static bool mod = false;
        private  bool tempmod = true;
        private int CountTurn = 0;
        private setting_Form SF = new setting_Form();

        public static void setTurnLength(int TL)
        {
            turnLength = TL;
        }

        public static void setnumOfLetter(int NOL)
        {
            numOfLetter = NOL;
        }
        public static void setMod(bool Mod)
        {
            mod = Mod;
        }

        private  void setLetterArray()
        {
            for (int i = 0; i < Letter.Length; i++)
            {
                Letter[i] =(char)(97 + i);
            }
        }

        private void setLetterBank()
        {
            while (LetterBank.Items.Count < numOfLetter)
            {
                int x = randomLetter.Next(0, Letter.Length);
                if (Letter[x] != '-')
                {
                    char L = Letter[x];
                    Letter[x] = '-';
                    LetterBank.Items.Add(L);
                }
            }
        }

        public Form1()
        {
            
            InitializeComponent();
        }

        public void setVisibleAndEnabledListBox1(bool OnOf)
        {
            label1.Visible = OnOf;
            player1.Visible = OnOf;
            player1.Enabled = OnOf;
        }
        public void setVisibleAndEnabledListBox2(bool OnOf)
        {
            label2.Visible = OnOf;
            player2.Visible = OnOf;
            player2.Enabled = OnOf;
        }

        private void AddWord_Click(object sender, EventArgs e)
        {
            if (CountTurn != 2)
            {
                if (turn)
                {
                    player2.Items.Add(word);
                    word = "";
                    textBox1.Text = word;
                }
                else
                {
                    player1.Items.Add(word);
                    word = "";
                    textBox1.Text = word;
                }
            }
        }

        private void LetterBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            word += LetterBank.SelectedItem.ToString();
            textBox1.Text = word;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (word.Length - 1 >= 0)
            {
                word = word.Remove(word.Length - 1);
            }
            textBox1.Text = word;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;

            if (CountTurn == 2)
            {
                setVisibleAndEnabledListBox1(true);
                CheckWhoWon.Enabled = true;
                CheckWhoWon.Visible = true;
                timer1.Stop();
            }
            else
            {
                if(((turnLength - time)  < turnLength / 2) && mod && tempmod)
                {
                    LetterBank.Items.Clear();
                    setLetterBank();
                    tempmod = !tempmod;
                }

                if ((turnLength - time) == 0)
                {
                    tempmod = true;
                    LetterBank.Items.Clear();
                    setLetterBank();
                    setVisibleAndEnabledListBox1(false);
                    setVisibleAndEnabledListBox2(true);
                    CountTurn++;
                    time = 0;
                    turn = !turn;
                }
                textBox2.Text = "time remain" + "" + (turnLength - time);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            setGame();
        }

        private void player1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountTurn == 2)
            {
                ListBox list = sender as ListBox;
                list.Items.Remove(list.SelectedItem);
            }
        }

        private void CheckWhoWon_Click(object sender, EventArgs e)
        {
            PlayAgain.Enabled = true;
            PlayAgain.Visible = true;
            setting.Enabled = true;
            setting.Visible = true;
            if (player1.Items.Count > player2.Items.Count)
            {
                MessageBox.Show("Player 1 won ");
            }else if (player2.Items.Count > player1.Items.Count)
            {
                MessageBox.Show("Player 2 won ");
            }
            else
            {
                MessageBox.Show("tie");
            }
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            setGame();
            CountTurn = 0;
            word = "";
            turn = false;
            player1.Items.Clear();
            player2.Items.Clear();
        }

        public void setGame()
        {
            LetterBank.Items.Clear();
            tempmod = true;
            setLetterArray();
            setLetterBank();
            timer1.Start();
            setVisibleAndEnabledListBox2(false);
            Start.Enabled = false;
            Start.Visible = false;
            CheckWhoWon.Enabled = false;
            CheckWhoWon.Visible = false;
            PlayAgain.Enabled = false;
            PlayAgain.Visible = false;
            setting.Enabled = false;
            setting.Visible = false;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            SF.ShowDialog();
        }
    }
}

