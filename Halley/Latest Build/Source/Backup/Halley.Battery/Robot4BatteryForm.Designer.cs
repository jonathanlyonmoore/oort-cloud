namespace Halley.Battery
{
    partial class Robot4BatteryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot4BatteryForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.recharge4 = new System.Windows.Forms.Button();
            this.Robot4dead = new System.Windows.Forms.Label();
            this.Robot4Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 84);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(82, 129);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(100, 23);
            this.progressBar4.TabIndex = 12;
            this.progressBar4.Value = 100;
            // 
            // recharge4
            // 
            this.recharge4.Enabled = false;
            this.recharge4.Location = new System.Drawing.Point(95, 191);
            this.recharge4.Name = "recharge4";
            this.recharge4.Size = new System.Drawing.Size(75, 23);
            this.recharge4.TabIndex = 13;
            this.recharge4.Text = "Recharge";
            this.recharge4.UseVisualStyleBackColor = true;
            this.recharge4.Click += new System.EventHandler(this.recharge4_Click);
            // 
            // Robot4dead
            // 
            this.Robot4dead.AutoSize = true;
            this.Robot4dead.ForeColor = System.Drawing.Color.Red;
            this.Robot4dead.Location = new System.Drawing.Point(32, 231);
            this.Robot4dead.Name = "Robot4dead";
            this.Robot4dead.Size = new System.Drawing.Size(215, 13);
            this.Robot4dead.TabIndex = 14;
            this.Robot4dead.Text = "**Robot 4 Battery needs to be Recharged.**";
            this.Robot4dead.Visible = false;
            // 
            // Robot4Timer
            // 
            this.Robot4Timer.Tick += new System.EventHandler(this.Robot4Timer_Tick);
            // 
            // Robot4BatteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.Robot4dead);
            this.Controls.Add(this.recharge4);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Robot4BatteryForm";
            this.Text = "Robot4BatteryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button recharge4;
        private System.Windows.Forms.Label Robot4dead;
        public System.Windows.Forms.Timer Robot4Timer;
    }
}