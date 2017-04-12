namespace Halley.Compressability
{
    partial class Robot1Compressability
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot1Compressability));
            this.Com1pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Com1pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Combutton1 = new System.Windows.Forms.Button();
            this.Com1label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Com1pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Com1pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Com1pictureBox2
            // 
            this.Com1pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("Com1pictureBox2.Image")));
            this.Com1pictureBox2.Location = new System.Drawing.Point(66, 23);
            this.Com1pictureBox2.Name = "Com1pictureBox2";
            this.Com1pictureBox2.Size = new System.Drawing.Size(149, 133);
            this.Com1pictureBox2.TabIndex = 3;
            this.Com1pictureBox2.TabStop = false;
            this.Com1pictureBox2.Visible = false;
            // 
            // Com1pictureBox1
            // 
            this.Com1pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("Com1pictureBox1.Image")));
            this.Com1pictureBox1.Location = new System.Drawing.Point(77, 38);
            this.Com1pictureBox1.Name = "Com1pictureBox1";
            this.Com1pictureBox1.Size = new System.Drawing.Size(128, 94);
            this.Com1pictureBox1.TabIndex = 4;
            this.Com1pictureBox1.TabStop = false;
            // 
            // Combutton1
            // 
            this.Combutton1.Location = new System.Drawing.Point(77, 162);
            this.Combutton1.Name = "Combutton1";
            this.Combutton1.Size = new System.Drawing.Size(114, 53);
            this.Combutton1.TabIndex = 5;
            this.Combutton1.Text = "Fix Robot 1\'s Compressability Sensor";
            this.Combutton1.UseVisualStyleBackColor = true;
            this.Combutton1.Visible = false;
            this.Combutton1.Click += new System.EventHandler(this.Combutton1_Click);
            // 
            // Com1label1
            // 
            this.Com1label1.AutoSize = true;
            this.Com1label1.Location = new System.Drawing.Point(38, 231);
            this.Com1label1.Name = "Com1label1";
            this.Com1label1.Size = new System.Drawing.Size(216, 13);
            this.Com1label1.TabIndex = 6;
            this.Com1label1.Text = "Robot 1\'s Compressability Sensor is Working";
            // 
            // Robot1Compressability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.Com1label1);
            this.Controls.Add(this.Combutton1);
            this.Controls.Add(this.Com1pictureBox2);
            this.Controls.Add(this.Com1pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Robot1Compressability";
            this.Text = "Robot1Compressability";
            ((System.ComponentModel.ISupportInitialize)(this.Com1pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Com1pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox Com1pictureBox2;
        public System.Windows.Forms.PictureBox Com1pictureBox1;
        public System.Windows.Forms.Button Combutton1;
        public System.Windows.Forms.Label Com1label1;
    }
}