using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Halley;
namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        private KeyButton[,] grid;
        public Form1()
        {
            InitializeComponent();
            grid = new KeyButton[50,50];
            this.AddButtons();
        }
        public void AddButtons() {
            for(int i = 0; i< grid.GetLength(0); i++)
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = new KeyButton(i*10,j*10);
                    this.Controls.Add(grid[i,j]);
                    //Controls.AddRange(grid
                }
        }

    }
}
