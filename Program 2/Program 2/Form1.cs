//Student ID: C1891
//3/9/17
//Program 2
//CIS 199-75
//This program is intended to have the user input their grade level, along with their 
// first letter of their last name. The program will then 
// give the date and time of when they are suppossed to register for classes 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrationDateButton_Click(object sender, EventArgs e)
        {
            char letterD;// this was added to be able to add a value to it, then compare to another char
            char letterI;// this was added to be able to add a value to it, then compare to another char
            char letterO;// this was added to be able to add a value to it, then compare to another char
            char letterS;// this was added to be able to add a value to it, then compare to another char

            char letter2B;// this was added to be able to add a value to it, then compare to another char
            char letter2F;// this was added to be able to add a value to it, then compare to another char
            char letter2L;// this was added to be able to add a value to it, then compare to another char
            char letter2Q;// this was added to be able to add a value to it, then compare to another char
            char letter2V;// this was added to be able to add a value to it, then compare to another char

            char letter; // this is to assign the nameTextBox to this char

            letter = nameTextBox.Text[0];

            letterD = 'D'; //this is to represent the letter D
            letterI = 'I';// this is to represent the letter I
            letterO = 'O';// this is to represent the letter O
            letterS = 'S';// this is to represent the letter S

            letter2B = 'B';// this is to represent the letter B
            letter2F = 'F';// this is to represent the letter F
            letter2L = 'L';// this is to represent the letter L
            letter2Q = 'Q';// this is to represent the letter Q
            letter2V = 'V';// this is to represent the letter V

            if (char.IsLetter(letter))
            {
                if (char.IsLower(letter) || char.IsUpper(letter))
                {
                    // the statements below occur if senior radio button is checked
                    if (seniorRadioButton.Checked)
                    {
                        if (letter <= letterD)
                            MessageBox.Show("Registration is on March 29 at 11:30am");
                        else if (letter <= letterI)
                            MessageBox.Show("Registration is on March 29 at 2:00pm");
                        else if (letter <= letterO)
                            MessageBox.Show("Registration is on March 29 at 4:00pm");
                        else if (letter <= letterS)
                            MessageBox.Show("Registration is on March 29 at 8:30am");
                        else
                            MessageBox.Show("Registration is on March 29 at 10:00pm");
                    }
                    // the statements below occur if junior radio button is checked
                    else if (juniorRadioButton.Checked)
                    {
                        if (letter <= letterD)
                            MessageBox.Show("Registration is on March 30 at 11:30am");
                        else if (letter <= letterI)
                            MessageBox.Show("Registration is on March 30 at 2:00pm");
                        else if (letter <= letterO)
                            MessageBox.Show("Registration is on March 30 at 4:00pm");
                        else if (letter <= letterS)
                            MessageBox.Show("Registration is on March 30 at 8:30am");
                        else
                            MessageBox.Show("Registration is on March 30 at 10:00pm");
                    }
                    // the statements below occur if sophomore radio button is checked
                    else if (sophomoreRadioButton.Checked)
                    {
                        if (letter <= letter2B)
                            MessageBox.Show("Registration is on March 31 at 4:00pm");
                        else if (letter <= letterD)
                            MessageBox.Show("Registration is on April 3 at 8:30am");
                        else if (letter <= letter2F)
                            MessageBox.Show("Registration is on April 3 at 10:00am");
                        else if (letter <= letterI)
                            MessageBox.Show("Registration is on April 3 at 11:30am");
                        else if (letter <= letter2L)
                            MessageBox.Show("Registration is on April 3 at 2:00pm");
                        else if (letter <= letterO)
                            MessageBox.Show("Registration is on April 3 at 4:00pm");
                        else if (letter <= letter2Q)
                            MessageBox.Show("Registration is on March 31 at 8:30am");
                        else if (letter <= letterS)
                            MessageBox.Show("Registration is on March 31 at 10:00am");
                        else if (letter <= letter2V)
                            MessageBox.Show("Registration is on March 31 at 11:30am");
                        else
                            MessageBox.Show("Registration is on March 31 at 2:00pm");
                    }
                    // the statements below occur if freshman radio button is checked
                    else if (freshmanRadioButton.Checked)
                    {
                        if (letter <= letter2B)
                            MessageBox.Show("Registration is on April 4 at 4:00pm");
                        else if (letter <= letterD)
                            MessageBox.Show("Registration is on April 5 at 8:30am");
                        else if (letter <= letter2F)
                            MessageBox.Show("Registration is on April 5 at 10:00am");
                        else if (letter <= letterI)
                            MessageBox.Show("Registration is on April 5 at 11:30am");
                        else if (letter <= letter2L)
                            MessageBox.Show("Registration is on April 5 at 2:00pm");
                        else if (letter <= letterO)
                            MessageBox.Show("Registration is on April 5 at 4:00pm");
                        else if (letter <= letter2Q)
                            MessageBox.Show("Registration is on April 4 at 8:30am");
                        else if (letter <= letterS)
                            MessageBox.Show("Registration is on April 4 at 10:00am");
                        else if (letter <= letter2V)
                            MessageBox.Show("Registration is on April 4 at 11:30am");
                        else
                            MessageBox.Show("Registration is on April 4 at 2:00pm");
                    }
                    else
                        MessageBox.Show("Please select grade level");
                }
                else
                    MessageBox.Show("Enter first letter of last name");
            }
           else
               MessageBox.Show("Enter first letter of last name");
        }
        // this will allow the user to clear the nameTextbox along with clearing the radio buttons
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            seniorRadioButton.Checked = false;
            juniorRadioButton.Checked = false;
            sophomoreRadioButton.Checked = false;
            freshmanRadioButton.Checked = false;
        }
    }
}
