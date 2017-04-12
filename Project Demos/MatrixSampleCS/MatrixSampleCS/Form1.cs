using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MatrixSampleCS
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        internal System.Windows.Forms.Panel panelFunctionDiagram;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        GraphFunction mIFunction = new GraphFunction();
        FunctionDiagram mFunctionDiagram;
                                                                                      public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panelFunctionDiagram = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelFunctionDiagram
            // 
            this.panelFunctionDiagram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFunctionDiagram.Location = new System.Drawing.Point(40, 16);
            this.panelFunctionDiagram.Name = "panelFunctionDiagram";
            this.panelFunctionDiagram.Size = new System.Drawing.Size(400, 400);
            this.panelFunctionDiagram.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(504, 438);
            this.Controls.Add(this.panelFunctionDiagram);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        private void Form1_Load(object sender, System.EventArgs e)
        {
            FunctionDiagram lFunctionDiagram = 
                new FunctionDiagram 
                    (panelFunctionDiagram.Width,
                     panelFunctionDiagram.Height, mIFunction);
            panelFunctionDiagram.BackgroundImage = 
                lFunctionDiagram.ChartBitmap;
            Text = "Application Coordinate Drawing for" 
                + mIFunction.ToString();
        
        }
	}
}
