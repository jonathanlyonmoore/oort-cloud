using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Form2 m_form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            m_form2.SendInfo += new SendDetails(m_form2_SendInfo);
        }

        void m_form2_SendInfo(string Details)
        {
            textBox1.Text = Details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_form2.ShowDialog(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
