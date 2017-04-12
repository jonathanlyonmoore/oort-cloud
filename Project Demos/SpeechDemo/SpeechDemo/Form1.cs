using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.IO;

namespace SpeechDemo
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer speaker = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void speakIt_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speaker.SpeakAsync("Hello Jonathan the time is" + DateTime.Now);

        }
    }
}
