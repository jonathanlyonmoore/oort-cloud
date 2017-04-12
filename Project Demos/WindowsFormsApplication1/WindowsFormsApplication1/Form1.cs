using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form 
    {
       

        public Form1()
        {           
            InitializeComponent();
            RobotsStart();
            
        }


        private void Form1_Load(object sender, System.EventArgs e)
        {
            Form2 form2 = new Form2();
            

           
        }

        private void batteryLifeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }       

       

        private void tempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 temp = new Form3();
            temp.Show();
        }


        private void RobotsStart()
        {
            //button13.BackColor = System.Drawing.Color.Blue;
            button13.Text = "Robot 1";
            button13.UseVisualStyleBackColor = true; 



        }

        







       
    }
}
