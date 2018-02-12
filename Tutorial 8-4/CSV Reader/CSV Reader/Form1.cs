using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Average(int[] scores)
        {
            double average = 0;
            int total = 0;

            // Calculate the total of the
            // test score tokens.

            // Calculate the average of these
            // test scores.
            return average;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;  // To read the file
                string line;   // To hold a line from the file
                int count = 0;
                int total;
                double average;          // Test score average

                // Create a delimiter array.
                char[] delim = { ',' };

                // Open the CSV file.
                inputFile = File.OpenText("..\\..\\Grades.csv");

                while (!inputFile.EndOfStream)
                {
                    count++;
                    line = inputFile.ReadLine();
                    string[] tokens = line.Split(delim);
                    total = 0;

                    foreach(string str in tokens)
                    {
                        total += int.Parse(str);
                    }
                    average = (double)total / tokens.Length;

                    averagesListBox.Items.Add("The average for student " +
                        count + " is " + average.ToString("n1"));
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
