﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeV1
{
    public partial class frmTicTacToe : Form
    {
        public frmTicTacToe()
        {
            InitializeComponent();
            lblLabels = new Label[3][3]{{ label1, label4, label7 }, { label2, label5, label8 }, { label3, label6, label9 } };
        }

        private Label[,] lblLabels;
    }
}