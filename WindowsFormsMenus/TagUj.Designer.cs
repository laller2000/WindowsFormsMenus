namespace WindowsFormsMenus
{
    partial class TagUj
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
            this.textBox1_Nev = new System.Windows.Forms.TextBox();
            this.textBox2_Orsz = new System.Windows.Forms.TextBox();
            this.button1_Felvetel = new System.Windows.Forms.Button();
            this.textBox1_Azon = new System.Windows.Forms.TextBox();
            this.textBox2_Szulev = new System.Windows.Forms.TextBox();
            this.textBox3_Irszam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új tag felvétele";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Azon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nev:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szulev";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "irszam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Orsz:";
            // 
            // textBox1_Nev
            // 
            this.textBox1_Nev.Location = new System.Drawing.Point(197, 116);
            this.textBox1_Nev.Name = "textBox1_Nev";
            this.textBox1_Nev.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Nev.TabIndex = 7;
            // 
            // textBox2_Orsz
            // 
            this.textBox2_Orsz.Location = new System.Drawing.Point(172, 242);
            this.textBox2_Orsz.Name = "textBox2_Orsz";
            this.textBox2_Orsz.Size = new System.Drawing.Size(100, 22);
            this.textBox2_Orsz.TabIndex = 8;
            // 
            // button1_Felvetel
            // 
            this.button1_Felvetel.Location = new System.Drawing.Point(367, 319);
            this.button1_Felvetel.Name = "button1_Felvetel";
            this.button1_Felvetel.Size = new System.Drawing.Size(75, 23);
            this.button1_Felvetel.TabIndex = 11;
            this.button1_Felvetel.Text = "Újtagfelvétel";
            this.button1_Felvetel.UseVisualStyleBackColor = true;
            this.button1_Felvetel.Click += new System.EventHandler(this.button1_Felvetel_Click);
            // 
            // textBox1_Azon
            // 
            this.textBox1_Azon.Location = new System.Drawing.Point(197, 66);
            this.textBox1_Azon.Name = "textBox1_Azon";
            this.textBox1_Azon.Size = new System.Drawing.Size(100, 22);
            this.textBox1_Azon.TabIndex = 12;
            // 
            // textBox2_Szulev
            // 
            this.textBox2_Szulev.Location = new System.Drawing.Point(197, 150);
            this.textBox2_Szulev.Name = "textBox2_Szulev";
            this.textBox2_Szulev.Size = new System.Drawing.Size(100, 22);
            this.textBox2_Szulev.TabIndex = 13;
            // 
            // textBox3_Irszam
            // 
            this.textBox3_Irszam.Location = new System.Drawing.Point(175, 201);
            this.textBox3_Irszam.Name = "textBox3_Irszam";
            this.textBox3_Irszam.Size = new System.Drawing.Size(100, 22);
            this.textBox3_Irszam.TabIndex = 14;
            // 
            // TagUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3_Irszam);
            this.Controls.Add(this.textBox2_Szulev);
            this.Controls.Add(this.textBox1_Azon);
            this.Controls.Add(this.button1_Felvetel);
            this.Controls.Add(this.textBox2_Orsz);
            this.Controls.Add(this.textBox1_Nev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TagUj";
            this.Text = "TagUj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TagUj_FormClosing);
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
        private System.Windows.Forms.TextBox textBox1_Nev;
        private System.Windows.Forms.TextBox textBox2_Orsz;
        private System.Windows.Forms.Button button1_Felvetel;
        private System.Windows.Forms.TextBox textBox1_Azon;
        private System.Windows.Forms.TextBox textBox2_Szulev;
        private System.Windows.Forms.TextBox textBox3_Irszam;
    }
}