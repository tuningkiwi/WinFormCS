﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest01
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//OK
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)//Cancel
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
