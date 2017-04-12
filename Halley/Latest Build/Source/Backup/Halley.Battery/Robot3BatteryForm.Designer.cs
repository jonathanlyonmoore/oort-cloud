namespace Halley.Battery
{
    partial class Robot3BatteryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot3BatteryForm));
            this.Robot3Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.recharge3 = new System.Windows.Forms.Button();
            this.Robot3dead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Robot3Timer
            // 
            this.Robot3Timer.Tick += new System.EventHandler(this.Robot3Timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 84);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(82, 129);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 23);
            this.progressBar3.TabIndex = 11;
            this.progressBar3.Value = 100;
            // 
            // recharge3
            // 
            this.recharge3.Enabled = false;
            this.recharge3.Location = new System.Drawing.Point(95, 191);
            this.recharge3.Name = "recharge3";
            this.recharge3.Size = new System.Drawing.Size(75, 23);
            this.recharge3.TabIndex = 12;
            this.recharge3.Text = "Recharge";
            this.recharge3.UseVisualStyleBackColor = true;
            this.recharge3.Click += new System.EventHandler(this.recharge3_Click);
            // 
            // Robot3dead
            // 
            this.Robot3dead.AutoSize = true;
            this.Robot3dead.ForeColor = System.Drawing.Color.Red;
            this.Robot3dead.Location = new System.Drawing.Point(37, 230);
            this.Robot3dead.Name = "Robot3dead";
            this.Robot3dead.Size = new System.Drawing.Size(215, 13);
            this.Robot3dead.TabIndex = 13;
            this.Robot3dead.Text = "**Robot 3 Battery needs to be Recharged.**";
            this.Robot3dead.Visible = false;
            // 
            // Robot3BatteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.Robot3dead);
            this.Controls.Add(this.recharge3);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Robot3BatteryForm";
            this.Text = "Robot3BatteryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer Robot3Timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button recharge3;
        private System.Windows.Forms.Label Robot3dead;
    }
}