namespace Halley.Robot1Battery
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
            this.percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(52, 112);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(35, 13);
            this.percent.TabIndex = 5;
            this.percent.Text = "label1";
            // 
            // Robot1BatteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.percent);
            this.Name = "Robot1BatteryForm";
            this.Text = "BatteryForm";
            this.Controls.SetChildIndex(this.percent, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer batteryTimer;
        private System.Windows.Forms.Label percent;

    }
}