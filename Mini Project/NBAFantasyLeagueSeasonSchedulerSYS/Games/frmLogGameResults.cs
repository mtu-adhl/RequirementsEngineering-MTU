﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBAFantasyLeagueSeasonSchedulerSYS.Games
{
    public partial class frmLogGameResults : Form
    {
        private static new Form Parent;
        public frmLogGameResults(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void frmLogGameResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Show();
        }

        private void frmLogGameResults_Load(object sender, EventArgs e)
        {

        }
    }
}
