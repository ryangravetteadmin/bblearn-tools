﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC_BB_Exam_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poolsettings thepooleditor = new poolsettings();
            thepooleditor.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            question_authoring thequestioneditor = new question_authoring();
            thequestioneditor.ShowDialog();
        }
    }
}
