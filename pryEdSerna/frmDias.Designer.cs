namespace pryEdSerna
{
    partial class frmDias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDias));
            this.lblNroDia = new System.Windows.Forms.Label();
            this.numDia = new System.Windows.Forms.NumericUpDown();
            this.lblDia = new System.Windows.Forms.Label();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dgvDia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroDia
            // 
            this.lblNroDia.AutoSize = true;
            this.lblNroDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.lblNroDia.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDia.Location = new System.Drawing.Point(213, 131);
            this.lblNroDia.Name = "lblNroDia";
            this.lblNroDia.Size = new System.Drawing.Size(122, 22);
            this.lblNroDia.TabIndex = 2;
            this.lblNroDia.Text = "Número del día:";
            // 
            // numDia
            // 
            this.numDia.Location = new System.Drawing.Point(360, 127);
            this.numDia.Name = "numDia";
            this.numDia.Size = new System.Drawing.Size(166, 26);
            this.numDia.TabIndex = 7;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.lblDia.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(213, 189);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(136, 22);
            this.lblDia.TabIndex = 8;
            this.lblDia.Text = "Día de la semana:";
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaSemana.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaSemana.Location = new System.Drawing.Point(360, 184);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(166, 27);
            this.txtDiaSemana.TabIndex = 9;
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(346, 261);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(118, 44);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dgvDia
            // 
            this.dgvDia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.dgvDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvDia.Location = new System.Drawing.Point(206, 348);
            this.dgvDia.Name = "dgvDia";
            this.dgvDia.RowHeadersWidth = 62;
            this.dgvDia.RowTemplate.Height = 28;
            this.dgvDia.Size = new System.Drawing.Size(393, 225);
            this.dgvDia.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Número";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Día ";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // frmDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 635);
            this.Controls.Add(this.dgvDia);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDiaSemana);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.numDia);
            this.Controls.Add(this.lblNroDia);
            this.Name = "frmDias";
            this.Text = "frmDias";
            this.Load += new System.EventHandler(this.frmDias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroDia;
        private System.Windows.Forms.NumericUpDown numDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridView dgvDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}