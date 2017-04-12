namespace Halley.Battery
{
    partial class Robot1BatteryForm
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
            this.batteryTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.recharge = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Robot1dead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // batteryTimer
            // 
            this.batteryTimer.Tick += new System.EventHandler(this.batteryTimer_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(82, 129);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Value = 100;
            // 
            // recharge
            // 
            this.recharge.Enabled = false;
            this.recharge.Location = new System.Drawing.Point(95, 191);
            this.recharge.Name = "recharge";
            this.recharge.Size = new System.Drawing.Size(75, 23);
            this.recharge.TabIndex = 7;
            this.recharge.Text = "Recharge";
            this.recharge.UseVisualStyleBackColor = true;
            this.recharge.Click += new System.EventHandler(this.recharge_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Halley.Battery.Properties.Resources.battery;
            this.pictureBox1.Location = new System.Drawing.Point(56, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 84);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Robot1dead
            // 
            this.Robot1dead.AutoSize = true;
            this.Robot1dead.Location = new System.Drawing.Point(13, 239);
            this.Robot1dead.Name = "Robot1dead";
            this.Robot1dead.Size = new System.Drawing.Size(199, 13);
            this.Robot1dead.TabIndex = 9;
            this.Robot1dead.Text = "Robot 1 Battery needs to be Recharged.";
            this.Robot1dead.Visible = false;
            // 
            // Robot1BatteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.Robot1dead);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.recharge);
            this.Controls.Add(this.progressBar1);
            this.Name = "Robot1BatteryForm";
            this.Text = "Robot 1 Battery Life";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer batteryTimer;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button recharge;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Robot1dead;

    }
}