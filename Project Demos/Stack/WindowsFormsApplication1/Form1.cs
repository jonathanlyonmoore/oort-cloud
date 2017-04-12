using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadFromFile("test.txt");    

        }

        public void ReadFromFile(string filename)
        {
            Stack mystack = new Stack(60000);
            StreamReader SR;
            SR = File.OpenText(filename);
            string S;
            while((S = SR.ReadLine()) != null)
            {
                mystack.Push(S);
                textBox1.AppendText(mystack.Pop().ToString() + "\r\n");
            }           
                        
            
            SR.Close();
        }

        

            


                               
               
            
        }
    }


