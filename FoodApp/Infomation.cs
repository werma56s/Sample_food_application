﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class Infomation : UserControl
    {
        public Infomation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("https://github.com/werma56s");
        }
    }
}
