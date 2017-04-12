namespace Halley.Battery
{
    partial class Robot2BatteryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot2BatteryForm));
            this.Robot2Timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.recharge2 = new System.Windows.Forms.Button();
            this.Robot2dead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Robot2Timer
            // 
            this.Robot2Timer.Tick += new System.EventHandler(this.Robot2Timer_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(82, 129);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 10;
            this.progressBar2.Value = 100;
            // 
            // recharge2
            // 
            this.recharge2.Enabled = false;
            this.recharge2.Location = new System.Drawing.Point(95, 191);
            this.recharge2.Name = "recharge2";
            this.recharge2.Size = new System.Drawing.Size(75, 23);
            this.recharge2.TabIndex = 11;
            this.recharge2.Text = "Recharge";
            this.recharge2.UseVisualStyleBackColor = true;
            this.recharge2.Click += new System.EventHandler(this.recharge2_Click);
            // 
            // Robot2dead
            // 
            this.Robot2dead.AutoSize = true;
            this.Robot2dead.ForeColor = System.Drawing.Color.Red;
            this.Robot2dead.Location = new System.Drawing.Point(31, 232);
            this.Robot2dead.Name = "Robot2dead";
            this.Robot2dead.Size = new System.Drawing.Size(215, 13);
            this.Robot2dead.TabIndex = 12;
            this.Robot2dead.Text = "**Robot 2 Battery needs to be Recharged.**";
            this.Robot2dead.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 84);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Robot2BatteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.Robot2dead);
            this.Controls.Add(this.recharge2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Robot2BatteryForm";
            this.Text = "Robot 2 Battery Life";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer Robot2Timer;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button recharge2;
        private System.Windows.Forms.Label Robot2dead;
    }
}