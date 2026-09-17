namespace CetrtaUra
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zapstC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priimekC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razredC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrojstva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 133);
            this.button1.TabIndex = 0;
            this.button1.Text = "Beri iz datoteke po vrsticah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zapstC,
            this.imec,
            this.priimekC,
            this.razredC,
            this.datumrojstva});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 199);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // zapstC
            // 
            this.zapstC.HeaderText = "Zaporedna številka";
            this.zapstC.MinimumWidth = 6;
            this.zapstC.Name = "zapstC";
            this.zapstC.Width = 125;
            // 
            // imec
            // 
            this.imec.HeaderText = "ime";
            this.imec.MinimumWidth = 6;
            this.imec.Name = "imec";
            this.imec.Width = 125;
            // 
            // priimekC
            // 
            this.priimekC.HeaderText = "priimek";
            this.priimekC.MinimumWidth = 6;
            this.priimekC.Name = "priimekC";
            this.priimekC.Width = 125;
            // 
            // razredC
            // 
            this.razredC.HeaderText = "Razred";
            this.razredC.MinimumWidth = 6;
            this.razredC.Name = "razredC";
            this.razredC.Width = 125;
            // 
            // datumrojstva
            // 
            this.datumrojstva.HeaderText = "Datum rojstva";
            this.datumrojstva.MinimumWidth = 6;
            this.datumrojstva.Name = "datumrojstva";
            this.datumrojstva.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zapstC;
        private System.Windows.Forms.DataGridViewTextBoxColumn imec;
        private System.Windows.Forms.DataGridViewTextBoxColumn priimekC;
        private System.Windows.Forms.DataGridViewTextBoxColumn razredC;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrojstva;
    }
}

