﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// this event handler will trigger when the final form load, loading the form action will retrieve all the data
        /// from the public class , then show it to the user 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalForm_Load(object sender, EventArgs e)
        {
            StrengthTextBox.Text = Program.character.Strength;
            DexterityTextBox.Text = Program.character.Dexterity;
            ConstitutionTextBox.Text = Program.character.Constitution;
            IntelligenceTextBox.Text = Program.character.Intelligence;
            WisdomTextBox.Text = Program.character.Wisdom;
            CharismaTextBox.Text = Program.character.Charisma;
            textBox1.Text = Program.character.FirstName;
            LastNameTextBox.Text = Program.character.LastName;
            textBox2.Text = Program.character.Race;
        }
    }
}
