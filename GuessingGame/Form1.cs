using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        int guessNumber;
        Random randGen = new Random();
        int roll;
        int away;
        int awayAbsolute;

        public Form1()
        {
            InitializeComponent();
            roll = randGen.Next(1, 101);
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            try
            {
                guessNumber = Convert.ToInt32(numberText.Text);
            }
            catch
            {
                outputLabel.Text = "Please use a whole number between 1 and 100";
            }

            away = roll - guessNumber;
            awayAbsolute = Math.Abs(away);

            if (guessNumber > roll)
            {
                outputLabel.Text = "Too High!";
            }
            else if (guessNumber < roll)
            {
                outputLabel.Text = "Too Low!";
            }
            else
            {
                outputLabel.Text = "That's Correct!";
            }

            if (awayAbsolute > 50)
            {
                outputLabel.Text += $"\nFreezing!";
            }
            else if (awayAbsolute > 25)
            {
                outputLabel.Text += $"\nCold!";
            }
            else if (awayAbsolute > 15)
            {
                outputLabel.Text += $"\nCool!";
            }
            else if (awayAbsolute > 10)
            {
                outputLabel.Text += $"\nWarm!";
            }
            else if (awayAbsolute > 5)
            {
                outputLabel.Text += $"\nHot!";
            }
            else if (awayAbsolute > 0)
            {
                outputLabel.Text += $"\nBoiling!";
            }
            else
            {
                outputLabel.Text += $"\nYou got heat stroke";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            roll = randGen.Next(1, 101);
            outputLabel.Text = "";
            numberText.Text = "";
        }
    }
}
