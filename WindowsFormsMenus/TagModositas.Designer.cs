namespace WindowsFormsMenus
{
    partial class TagModositas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1_Azon = new System.Windows.Forms.TextBox();
            this.textBox2_Nev = new System.Windows.Forms.TextBox();
            this.textBox3_Szulev = new System.Windows.Forms.TextBox();
            this.textBox4_irszam = new System.Windows.Forms.TextBox();
            this.textBox5_Orsz = new System.Windows.Forms.TextBox();
            this.button1_Modositas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag adatainak módosítása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Azon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nev:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szulev";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Irszam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Orsz:";
            // 
            // textBox1_Azon
            // 
            this.textBox1_Azon.Location = new System.Drawing.Point(254, 104);
            this.textBox1_Azon.Name = "textBox1_Azon";
            this.textBox1_Azon.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Azon.TabIndex = 6;
            // 
            // textBox2_Nev
            // 
            this.textBox2_Nev.Location = new System.Drawing.Point(272, 158);
            this.textBox2_Nev.Name = "textBox2_Nev";
            this.textBox2_Nev.Size = new System.Drawing.Size(100, 22);
            this.textBox2_Nev.TabIndex = 7;
            // 
            // textBox3_Szulev
            // 
            this.textBox3_Szulev.Location = new System.Drawing.Point(272, 213);
            this.textBox3_Szulev.Name = "textBox3_Szulev";
            this.textBox3_Szulev.Size = new System.Drawing.Size(112, 22);
            this.textBox3_Szulev.TabIndex = 8;
            // 
            // textBox4_irszam
            // 
            this.textBox4_irszam.Location = new System.Drawing.Point(286, 262);
            this.textBox4_irszam.Name = "textBox4_irszam";
            this.textBox4_irszam.Size = new System.Drawing.Size(100, 22);
            this.textBox4_irszam.TabIndex = 9;
            // 
            // textBox5_Orsz
            // 
            this.textBox5_Orsz.Location = new System.Drawing.Point(286, 314);
            this.textBox5_Orsz.Name = "textBox5_Orsz";
            this.textBox5_Orsz.Size = new System.Drawing.Size(100, 22);
            this.textBox5_Orsz.TabIndex = 10;
            // 
            // button1_Modositas
            // 
            this.button1_Modositas.Location = new System.Drawing.Point(311, 392);
            this.button1_Modositas.Name = "button1_Modositas";
            this.button1_Modositas.Size = new System.Drawing.Size(75, 23);
            this.button1_Modositas.TabIndex = 11;
            this.button1_Modositas.Text = "Modositas";
            this.button1_Modositas.UseVisualStyleBackColor = true;
            this.button1_Modositas.Click += new System.EventHandler(this.button1_Modositas_Click);
            // 
            // TagModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_Modositas);
            this.Controls.Add(this.textBox5_Orsz);
            this.Controls.Add(this.textBox4_irszam);
            this.Controls.Add(this.textBox3_Szulev);
            this.Controls.Add(this.textBox2_Nev);
            this.Controls.Add(this.textBox1_Azon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TagModositas";
            this.Text = "TagModositas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TagModositas_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1_Azon;
        private System.Windows.Forms.TextBox textBox2_Nev;
        private System.Windows.Forms.TextBox textBox3_Szulev;
        private System.Windows.Forms.TextBox textBox4_irszam;
        private System.Windows.Forms.TextBox textBox5_Orsz;
        private System.Windows.Forms.Button button1_Modositas;
    }
}