namespace Halley.Battery
{
    partial class Robot6BatteryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot6BatteryForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.recharge6 = new System.Windows.Forms.Button();
            this.Robot6dead = new System.Windows.Forms.Label();
            this.Robot6Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 84);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(82, 129);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(100, 23);
            this.progressBar6.TabIndex = 13;
            this.progressBar6.Value = 100;
            // 
            // recharge6
            // 
            this.recharge6.Enabled = false;
            this.recharge6.Location = new System.Drawing.Point(95, 191);
            this.recharge6.Name = "recharge6";
            this.recharge6.Size = new System.Drawing.Size(75, 23);
            this.recharge6.TabIndex = 14;
            this.recharge6.Text = "Recharge";
            this.recharge6.UseVisualStyleBackColor = true;
            this.recharge6.Click += new System.EventHandler(this.recharge6_Click);
            // 
            // Robot6dead
            // 
            this.Robot6dead.AutoSize = true;
            this.Robot6dead.ForeColor = System.Drawing.Color.Red;
            this.Robot6dead.Location = new System.Drawing.Point(39, 230);
            this.Robot6dead.Name = "Robot6dead";
            this.Robot6dead.Size = new System.Drawing.Size(215, 13);
            this.Robot6dead.TabIndex = 15;
            this.Robot6dead.Text = "**Robot 6 Battery needs to be Recharged.**";
            this.Robot6dead.Visible = false;
            // 
            // Robot6Timer
            // 
            this.Robot6Timer.Tick += new System.EventHandler(this.Robot6Timer_Tick);
            // 
            // Robot6BatteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.Robot6dead);
            this.Controls.Add(this.recharge6);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Robot6BatteryForm";
            this.Text = "Robot6BatteryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Button recharge6;
        private System.Windows.Forms.Label Robot6dead;
        public System.Windows.Forms.Timer Robot6Timer;
    }
}