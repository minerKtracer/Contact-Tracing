﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_CONTACT_TRACING
{
    public partial class GetPass : Form
    {
        public GetPass()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\kylene shane varona\Desktop\MY ASSIGN 3\test.txt", true);
            file.WriteLine("Information of the persons :");
            file.WriteLine("Date of Visit (mm/dd/yyyy) : " + MTextBox14.Text);
            file.WriteLine("Time in (am/pm): " + TITextBox2.Text);
            file.WriteLine("First Name: " + FNTextBox3.Text);
            file.WriteLine("Surname: " + SNTextBox4.Text);
            file.WriteLine("Age: " + ATextBox5.Text);
            file.WriteLine("Sex (F/M): " + STextBox6.Text);
            file.WriteLine("Phone Number: " + PNTextBox7.Text);
            file.WriteLine("Address: " + ADDTextBox8.Text);
            file.WriteLine("Baranagy: " + BTextBox9.Text);
            file.WriteLine("City: " + CTextBox10.Text);
            file.WriteLine("Expossure Risk: " + ERTextBox11.Text);
            file.WriteLine("Vaccinated (Y/N): " + VTextBox12.Text);
            file.WriteLine("How many dose?: " + QTextBox13.Text);
            file.Close();
        }

        private void AboutSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Kylene Shane M. Varona from BSCOE 1-5", "BASIC INFO");
        }

        private void ExitTab_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void ReadHistory_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\kylene shane varona\Desktop\MY ASSIGN 3\test.txt");
            String all = reader.ReadToEnd();
            MessageBox.Show(all);

            //while (!reader.EndOfStream)
            //{
            //    String line = reader.ReadLine();
            //    MessageBox.Show(line);
            //}
        }
    }
}
