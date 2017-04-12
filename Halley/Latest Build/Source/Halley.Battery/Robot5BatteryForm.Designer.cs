namespace Halley.Battery
{
    partial class Robot5BatteryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot5BatteryForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.recharge5 = new System.Windows.Forms.Button();
            this.Robot5dead = new System.Windows.Forms.Label();
            this.Robot5Timer = new System.Windows.Forms.Timer(this.components);
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
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(82, 129);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(100, 23);
            this.progressBar5.TabIndex = 13;
            this.progressBar5.Value = 100;
            // 
            // recharge5
            // 
            this.recharge5.Enabled = false;
            this.recharge5.Location = new System.Drawing.Point(95, 191);
            this.recharge5.Name = "recharge5";
            this.recharge5.Size = new System.Drawing.Size(75, 23);
            this.recharge5.TabIndex = 14;
            this.recharge5.Text = "Recharge";
            this.recharge5.UseVisualStyleBackColor = true;
            this.recharge5.Click += new System.EventHandler(this.recharge5_Click);
            // 
            // Robot5dead
            // 
            this.Robot5dead.AutoSize = true;
            this.Robot5dead.ForeColor = System.Drawing.Color.Red;
            this.Robot5dead.Location = new System.Drawing.Point(36, 232);
            this.Robot5dead.Name = "Robot5dead";
            this.Robot5dead.Size = new System.Drawing.Size(215, 13);
            this.Robot5dead.TabIndex = 15;
            this.Robot5dead.Text = "**Robot 5 Battery needs to be Recharged.**";
            this.Robot5dead.Visible = false;
            // 
            // Robot5Timer
            // 
            this.Robot5Timer.Tick += new System.EventHandler(this.Robot5Timer_Tick);
            // 
            // Robot5BatteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.Robot5dead);
            this.Controls.Add(this.recharge5);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Robot5BatteryForm";
            this.Text = "Robot5BatteryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Button recharge5;
        private System.Windows.Forms.Label Robot5dead;
        public System.Windows.Forms.Timer Robot5Timer;
    }
}