namespace WindowsFormsMenus
{
    partial class TagBefizetesUj
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
            this.dateTimePicker1_datum = new System.Windows.Forms.DateTimePicker();
            this.textBox1_azon = new System.Windows.Forms.TextBox();
            this.textBox2_osszeg = new System.Windows.Forms.TextBox();
            this.button1_felvetel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "azon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "osszeg:";
            // 
            // dateTimePicker1_datum
            // 
            this.dateTimePicker1_datum.CustomFormat = "";
            this.dateTimePicker1_datum.Location = new System.Drawing.Point(173, 99);
            this.dateTimePicker1_datum.Name = "dateTimePicker1_datum";
            this.dateTimePicker1_datum.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1_datum.TabIndex = 3;
            // 
            // textBox1_azon
            // 
            this.textBox1_azon.Location = new System.Drawing.Point(148, 34);
            this.textBox1_azon.Name = "textBox1_azon";
            this.textBox1_azon.Size = new System.Drawing.Size(104, 22);
            this.textBox1_azon.TabIndex = 4;
            // 
            // textBox2_osszeg
            // 
            this.textBox2_osszeg.Location = new System.Drawing.Point(201, 144);
            this.textBox2_osszeg.Name = "textBox2_osszeg";
            this.textBox2_osszeg.Size = new System.Drawing.Size(100, 22);
            this.textBox2_osszeg.TabIndex = 5;
            // 
            // button1_felvetel
            // 
            this.button1_felvetel.Location = new System.Drawing.Point(318, 247);
            this.button1_felvetel.Name = "button1_felvetel";
            this.button1_felvetel.Size = new System.Drawing.Size(93, 52);
            this.button1_felvetel.TabIndex = 6;
            this.button1_felvetel.Text = "befizfelvetel";
            this.button1_felvetel.UseVisualStyleBackColor = true;
            this.button1_felvetel.Click += new System.EventHandler(this.button1_felvetel_Click);
            // 
            // TagBefizetesUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_felvetel);
            this.Controls.Add(this.textBox2_osszeg);
            this.Controls.Add(this.textBox1_azon);
            this.Controls.Add(this.dateTimePicker1_datum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TagBefizetesUj";
            this.Text = "TagBefizetesUj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_datum;
        private System.Windows.Forms.TextBox textBox1_azon;
        private System.Windows.Forms.TextBox textBox2_osszeg;
        private System.Windows.Forms.Button button1_felvetel;
    }
}