﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BaldinAA.Sprint7.Project.V14
{
    public partial class FormGuideImage : Form
    {
        public FormGuideImage()
        {
            InitializeComponent();
        }
        public void textBoxGuideImage_SBI_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void groupBoxGuideImageDescription_SBI_Enter(object sender, EventArgs e)
        {

        }
    }
}
