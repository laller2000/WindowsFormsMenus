﻿namespace WindowsFormsMenus
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tagokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módositásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.befizetésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagokToolStripMenuItem,
            this.befizetésekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tagokToolStripMenuItem
            // 
            this.tagokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módositásToolStripMenuItem});
            this.tagokToolStripMenuItem.Name = "tagokToolStripMenuItem";
            this.tagokToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.tagokToolStripMenuItem.Text = "Tagok";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módositásToolStripMenuItem
            // 
            this.módositásToolStripMenuItem.Name = "módositásToolStripMenuItem";
            this.módositásToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.módositásToolStripMenuItem.Text = "Módositás";
            this.módositásToolStripMenuItem.Click += new System.EventHandler(this.módositásToolStripMenuItem_Click);
            // 
            // befizetésekToolStripMenuItem
            // 
            this.befizetésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem1,
            this.lekérdezésToolStripMenuItem});
            this.befizetésekToolStripMenuItem.Name = "befizetésekToolStripMenuItem";
            this.befizetésekToolStripMenuItem.Size = new System.Drawing.Size(98, 34);
            this.befizetésekToolStripMenuItem.Text = "Befizetések";
            // 
            // újToolStripMenuItem1
            // 
            this.újToolStripMenuItem1.Name = "újToolStripMenuItem1";
            this.újToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.újToolStripMenuItem1.Text = "Új";
            this.újToolStripMenuItem1.Click += new System.EventHandler(this.újToolStripMenuItem1_Click);
            // 
            // lekérdezésToolStripMenuItem
            // 
            this.lekérdezésToolStripMenuItem.Name = "lekérdezésToolStripMenuItem";
            this.lekérdezésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lekérdezésToolStripMenuItem.Text = "lekérdezés";
            this.lekérdezésToolStripMenuItem.Click += new System.EventHandler(this.lekérdezésToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tagokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módositásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem befizetésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lekérdezésToolStripMenuItem;
    }
}

