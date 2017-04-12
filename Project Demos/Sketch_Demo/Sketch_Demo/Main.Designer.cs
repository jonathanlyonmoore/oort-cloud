namespace Sketch_Demo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.robot6 = new System.Windows.Forms.Button();
            this.robot5 = new System.Windows.Forms.Button();
            this.robot4 = new System.Windows.Forms.Button();
            this.robot3 = new System.Windows.Forms.Button();
            this.robot2 = new System.Windows.Forms.Button();
            this.robot1 = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.gridBox = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.viewToolStripMenuItem.Text = "&View ";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(13, 28);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(215, 299);
            this.messageBox.TabIndex = 2;
            this.messageBox.TabStop = false;
            this.messageBox.Text = "Welcome Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.robot6);
            this.groupBox2.Controls.Add(this.robot5);
            this.groupBox2.Controls.Add(this.robot4);
            this.groupBox2.Controls.Add(this.robot3);
            this.groupBox2.Controls.Add(this.robot2);
            this.groupBox2.Controls.Add(this.robot1);
            this.groupBox2.Location = new System.Drawing.Point(234, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 299);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Robots";
            // 
            // robot6
            // 
            this.robot6.Location = new System.Drawing.Point(24, 258);
            this.robot6.Name = "robot6";
            this.robot6.Size = new System.Drawing.Size(75, 23);
            this.robot6.TabIndex = 5;
            this.robot6.Text = "Robot 6";
            this.robot6.UseVisualStyleBackColor = true;
            this.robot6.Click += new System.EventHandler(this.robot6_Click);
            // 
            // robot5
            // 
            this.robot5.Location = new System.Drawing.Point(24, 212);
            this.robot5.Name = "robot5";
            this.robot5.Size = new System.Drawing.Size(75, 23);
            this.robot5.TabIndex = 4;
            this.robot5.Text = "Robot 5";
            this.robot5.UseVisualStyleBackColor = true;
            this.robot5.Click += new System.EventHandler(this.robot5_Click);
            // 
            // robot4
            // 
            this.robot4.Location = new System.Drawing.Point(24, 169);
            this.robot4.Name = "robot4";
            this.robot4.Size = new System.Drawing.Size(75, 23);
            this.robot4.TabIndex = 3;
            this.robot4.Text = "Robot 4";
            this.robot4.UseVisualStyleBackColor = true;
            this.robot4.Click += new System.EventHandler(this.robot4_Click);
            // 
            // robot3
            // 
            this.robot3.Location = new System.Drawing.Point(24, 122);
            this.robot3.Name = "robot3";
            this.robot3.Size = new System.Drawing.Size(75, 23);
            this.robot3.TabIndex = 2;
            this.robot3.Text = "Robot 3";
            this.robot3.UseVisualStyleBackColor = true;
            this.robot3.Click += new System.EventHandler(this.robot3_Click);
            // 
            // robot2
            // 
            this.robot2.Location = new System.Drawing.Point(24, 75);
            this.robot2.Name = "robot2";
            this.robot2.Size = new System.Drawing.Size(75, 23);
            this.robot2.TabIndex = 1;
            this.robot2.Text = "Robot 2";
            this.robot2.UseVisualStyleBackColor = true;
            this.robot2.Click += new System.EventHandler(this.robot2_Click);
            // 
            // robot1
            // 
            this.robot1.Location = new System.Drawing.Point(24, 30);
            this.robot1.Name = "robot1";
            this.robot1.Size = new System.Drawing.Size(75, 23);
            this.robot1.TabIndex = 0;
            this.robot1.Text = "Robot 1";
            this.robot1.UseVisualStyleBackColor = true;
            this.robot1.Click += new System.EventHandler(this.robot1_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(12, 104);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(220, 91);
            this.message.TabIndex = 0;
            this.message.Text = resources.GetString("message.Text");
            // 
            // gridBox
            // 
            this.gridBox.Location = new System.Drawing.Point(12, 28);
            this.gridBox.Name = "gridBox";
            this.gridBox.Size = new System.Drawing.Size(220, 299);
            this.gridBox.TabIndex = 0;
            this.gridBox.TabStop = false;
            this.gridBox.Text = "Grid";
            this.gridBox.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 339);
            this.Controls.Add(this.gridBox);
            this.Controls.Add(this.message);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox messageBox;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button robot6;
        private System.Windows.Forms.Button robot5;
        private System.Windows.Forms.Button robot4;
        private System.Windows.Forms.Button robot3;
        private System.Windows.Forms.Button robot2;
        private System.Windows.Forms.Button robot1;
        private System.Windows.Forms.GroupBox gridBox;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

