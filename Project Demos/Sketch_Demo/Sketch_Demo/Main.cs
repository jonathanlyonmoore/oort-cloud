using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sketch_Demo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //insert code for when the program loads here.

        }

        private void robot1_Click(object sender, EventArgs e)
        {
            messageBox.Visible = false;
            message.Visible = false;
            gridBox.Visible = true;
            gridBox.Text = "Robot 1 Grid";
        }

        private void robot2_Click(object sender, EventArgs e)
        {
            messageBox.Visible = false;
            message.Visible = false;
            gridBox.Visible = true;
            gridBox.Text = "Robot 2 Grid";

        }

        private void robot3_Click(object sender, EventArgs e)
        {
            messageBox.Visible = false;
            message.Visible = false;
            gridBox.Visible = true;
            gridBox.Text = "Robot 3 Grid";

        }

        private void robot4_Click(object sender, EventArgs e)
        {
            messageBox.Visible = false;
            message.Visible = false;
            gridBox.Visible = true;
            gridBox.Text = "Robot 4 Grid";
        }

        private void robot5_Click(object sender, EventArgs e)
        {
            messageBox.Visible = false;
            message.Visible = false;
            gridBox.Visible = true;
            gridBox.Text = "Robot 5 Grid";
        }

        private void robot6_Click(object sender, EventArgs e)
        {
            messageBox.Visible = false;
            message.Visible = false;
            gridBox.Visible = true;
            gridBox.Text = "Robot 6 Grid";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            openFileDialog1.InitialDirectory = Application.StartupPath;           
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the XML files.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file Original error: " + ex.Message);
                }
            }

        }
    }
}
