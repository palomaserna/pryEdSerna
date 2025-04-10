namespace pryEdSerna
{
    partial class frmProvincias
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
            this.txtProvincias = new System.Windows.Forms.TextBox();
            this.btnGrabarP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProvincias = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProvincias
            // 
            this.txtProvincias.Location = new System.Drawing.Point(113, 38);
            this.txtProvincias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProvincias.Name = "txtProvincias";
            this.txtProvincias.Size = new System.Drawing.Size(109, 20);
            this.txtProvincias.TabIndex = 0;
            this.txtProvincias.TextChanged += new System.EventHandler(this.txtProvincias_TextChanged);
            // 
            // btnGrabarP
            // 
            this.btnGrabarP.Location = new System.Drawing.Point(188, 114);
            this.btnGrabarP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrabarP.Name = "btnGrabarP";
            this.btnGrabarP.Size = new System.Drawing.Size(57, 20);
            this.btnGrabarP.TabIndex = 1;
            this.btnGrabarP.Text = "Grabar";
            this.btnGrabarP.UseVisualStyleBackColor = true;
            this.btnGrabarP.Click += new System.EventHandler(this.btnGrabarP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // dgvProvincias
            // 
            this.dgvProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvProvincias.Location = new System.Drawing.Point(11, 153);
            this.dgvProvincias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProvincias.Name = "dgvProvincias";
            this.dgvProvincias.RowHeadersWidth = 62;
            this.dgvProvincias.RowTemplate.Height = 28;
            this.dgvProvincias.Size = new System.Drawing.Size(356, 128);
            this.dgvProvincias.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 75);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(109, 20);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo:";
            // 
            // frmProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(394, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dgvProvincias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabarP);
            this.Controls.Add(this.txtProvincias);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProvincias";
            this.Text = "frmProvincias";
            this.Load += new System.EventHandler(this.frmProvincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProvincias;
        private System.Windows.Forms.Button btnGrabarP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProvincias;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}