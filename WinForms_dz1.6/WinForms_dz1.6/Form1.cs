﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_dz1._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            DateTime tmp = DateTime.Parse(dtpData.Text);
            txbResult.Text = tmp.DayOfWeek.ToString();
        }
    }
}