namespace WindowsFormsMenus
{
    partial class TagBefizetesLekerdezes
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
            this.dataGridView1_Befiz = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Befiz)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_Befiz
            // 
            this.dataGridView1_Befiz.AllowUserToAddRows = false;
            this.dataGridView1_Befiz.AllowUserToDeleteRows = false;
            this.dataGridView1_Befiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Befiz.Location = new System.Drawing.Point(0, -2);
            this.dataGridView1_Befiz.Name = "dataGridView1_Befiz";
            this.dataGridView1_Befiz.ReadOnly = true;
            this.dataGridView1_Befiz.RowHeadersWidth = 51;
            this.dataGridView1_Befiz.RowTemplate.Height = 24;
            this.dataGridView1_Befiz.Size = new System.Drawing.Size(802, 453);
            this.dataGridView1_Befiz.TabIndex = 0;
            // 
            // TagBefizetesLekerdezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1_Befiz);
            this.Name = "TagBefizetesLekerdezes";
            this.Text = "TagBefizetesLekerdezes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TagBefizetesLekerdezes_FormClosing);
            this.Load += new System.EventHandler(this.TagBefizetesLekerdezes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Befiz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_Befiz;
    }
}