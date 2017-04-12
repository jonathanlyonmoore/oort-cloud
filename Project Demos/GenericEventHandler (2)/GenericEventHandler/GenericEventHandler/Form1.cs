using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericEventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            {
                KeyButtonClass grid = default(KeyButtonClass);
                int i = 0;
                int j = 0;
                int ctlCount = 0;
                for (i = 0; i <= 4; i++)
                {
                    for (j = 0; j <= 4; j++)
                    {
                        ctlCount += 1;

                        grid = new KeyButtonClass(i * 10, j * 10);
                        grid.TabIndex = ctlCount - 1;
                        grid.Name = "btn" + ctlCount;
                        grid.Tag = ctlCount - 1;
                        grid.LostFocus += this.LostFocusHandler;
                        grid.GotFocus += this.GotFocusHandler;
                        grid.PreviewKeyDown += this.PreviewKeyDownHandler;
                        this.Controls.Add(grid);

                    }
                }
            } 
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GotFocusHandler(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button Button = default(System.Windows.Forms.Button);
            Button = (System.Windows.Forms.Button)sender;
            Button.BackColor = Color.Blue;
        }

        public void LostFocusHandler(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button Button = default(System.Windows.Forms.Button);
            Button = (System.Windows.Forms.Button)sender;
            Button.BackColor = this.BackColor;
        }

        public void PreviewKeyDownHandler(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
        {
            System.Windows.Forms.Button Button = default(System.Windows.Forms.Button);
            System.Windows.Forms.Button NextButton = default(System.Windows.Forms.Button);
            Button = (System.Windows.Forms.Button)sender;
            //MsgBox(Button.Name) 
            switch (e.KeyCode)
            {
                case Keys.Right:
                    
                    if ((this.Controls["btn" + Convert.ToString(Convert.ToInt32(Button.Tag) + 5)] is Button))
                    {
                        NextButton = (System.Windows.Forms.Button)this.Controls["btn" + Convert.ToString(Convert.ToInt32(Button.Tag) + 5)];
                        NextButton.Focus();
                    }

                    break;

                case Keys.Left:
                    if ((this.Controls["btn" + Convert.ToString((Convert.ToInt32(Button.Tag) - 3))] is Button))
                    {
                        NextButton = (System.Windows.Forms.Button)this.Controls["btn" + Convert.ToString(Convert.ToInt32(Button.Tag) - 3)];
                        NextButton.Focus();
                    }

                    break;
            }
        } 
    }
}
