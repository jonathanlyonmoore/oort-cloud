namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.batteryBox = new System.Windows.Forms.GroupBox();
            this.Batterytimer = new System.Windows.Forms.Timer(this.components);
            this.percent = new System.Windows.Forms.Label();
            this.batteryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // batteryBox
            // 
            this.batteryBox.Controls.Add(this.percent);
            this.batteryBox.Location = new System.Drawing.Point(55, 87);
            this.batteryBox.Name = "batteryBox";
            this.batteryBox.Size = new System.Drawing.Size(163, 100);
            this.batteryBox.TabIndex = 9;
            this.batteryBox.TabStop = false;
            this.batteryBox.Text = "Battery Life";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(48, 44);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(0, 13);
            this.percent.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 249);
            this.Controls.Add(this.batteryBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.batteryBox.ResumeLayout(false);
            this.batteryBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox batteryBox;
        private System.Windows.Forms.Timer Batterytimer;
        private System.Windows.Forms.Label percent;
    }
}