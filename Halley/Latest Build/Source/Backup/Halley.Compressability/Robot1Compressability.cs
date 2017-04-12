using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Halley.Compressability
{
    public partial class Robot1Compressability : Form
    {   //constructor
        public Robot1Compressability()
        {
            InitializeComponent();
        }
        //Fix Compressability Button click
        private void Combutton1_Click(object sender, EventArgs e)
        {
            Com1pictureBox1.Visible = true;
            Com1pictureBox2.Visible = false;
            Combutton1.Visible = false;
            Com1label1.Visible = true;
        }
    }
}
