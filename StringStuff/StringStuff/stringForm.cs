using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Stuff
{
    public partial class stringForm : Form
    {
        public stringForm()
        {
            InitializeComponent();
        }

        string code = "qwertyuiopasdfghjklzxcvbnm";

        private string SwitchCase(string input)
        {

           
            string output = "";
          
            foreach (char c in input)
            {

               if (Char.IsUpper(c))
                {
                 output += Char.ToLower(c);
                }
                
               else if (Char.IsLower(c))
                {
                   output+= Char.ToUpper(c);
                }
               else if (c == ' ')
                {
                    output += c;
                }
              
            }

           
            switchCaseTextBox.Text = output;



            return output;
        }

        private string Reverse(string input)
        {

            string output = "";

            for ( int i = input.Length -1; i >= 0; i--)
            {
                output += input[i];

            }






            return output;
        }

        private string PigLatin(string input)
        {
            string output = "";
            string[] words;
            words = input.Split(' ');
            string temp;
            foreach (string word in words)
            {
                
                temp = word;
                temp += temp[0];
               temp = temp.Remove(0,1);
                temp += "ay ";
                output += temp.ToLower();
            }
            
            
            return output; 
    }

        private string ShiftCypher(string input, int charsToShift)
        {

            string output = "";
            char temp;

            string alpha = "abcdefghijklmnopqrstuvwxyz";
            foreach(char c in input)
            {
                if (c == ' ')
                {
                    output += ' ';
                }
                else
                {
                    temp = Char.ToLower(c); // had to shift to lowercase
                    int index = alpha.IndexOf(temp);
                    index += charsToShift;
                    if (index >= 26)
                        index -= 26;
                    output += alpha[index];
                }
            }

                
                // index 28 -26 = 2 
           
            
            return output;
        }

        private string SubCypher(string input, string code)
        {
            // maybe put as global? code = "qwertyuiopasdfghjklzxcvbnm";
            
            string output = "";
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            char temp;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    output += ' ';
                }
                else
                {
                    temp = Char.ToLower(c); // had to shift to lowercase
                    int index = alpha.IndexOf(temp);
                    output += code[index];
                }
            }

            return output;
        }

        private void transformButton_Click(object sender, EventArgs e)
        {

            string input = inputTextBox.Text;
            switchCaseTextBox.Text = SwitchCase(input);
            subTextBox.Text = SubCypher(input, code);
            pigLatinTextBox.Text = PigLatin(input);
            shiftTextBox.Text = ShiftCypher(input, 4);
            reverseTextBox.Text = Reverse(input);

        }
    }
}
