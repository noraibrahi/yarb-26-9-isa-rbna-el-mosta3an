﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Lab_System
{
    public partial class CBCtest : Form
    {
        public CBCtest(string msg1, string msg2, string msg3, string msg4, string msg5, string msg7)
        {
            InitializeComponent();
            AppDate.Text = msg1;
            ReportDate.Text = msg2;
            PhysicianName.Text = msg3;
            PatientName.Text = msg4;
            PatientID.Text = msg5;
            PatientAge.Text = msg7;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }
        
        private void CBCtest_Load(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar__Navigation_Screen f2 = new Registrar__Navigation_Screen();
            f2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn f2 = new SignIn();
            f2.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
