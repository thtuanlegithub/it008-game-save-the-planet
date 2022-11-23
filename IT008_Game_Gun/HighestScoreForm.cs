﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IT008_Game_SaveThePlanet
{
    public partial class HighestScoreForm : Form
    {
        public HighestScoreForm()
        {
            InitializeComponent();
        }

        private void HighestScoreForm_Load(object sender, EventArgs e)
        {
            labelHighestScoreNum.Text = File.ReadAllText("dataHighScore.txt");
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void labelBack_MouseLeave(object sender, EventArgs e)
        {
            labelBack.ForeColor = Color.Snow;
        }

        private void labelBack_MouseMove(object sender, MouseEventArgs e)
        {
            labelBack.ForeColor = Color.DarkGray;
        }
    }
}
