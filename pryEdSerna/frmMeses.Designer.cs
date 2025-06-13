namespace pryEdSerna
{
    partial class frmMeses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeses));
            this.lblNroMes = new System.Windows.Forms.Label();
            this.lblNombreMes = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtNombreMes = new System.Windows.Forms.TextBox();
            this.dgvMes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numMes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroMes
            // 
            this.lblNroMes.AutoSize = true;
            this.lblNroMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.lblNroMes.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMes.Location = new System.Drawing.Point(187, 160);
            this.lblNroMes.Name = "lblNroMes";
            this.lblNroMes.Size = new System.Drawing.Size(129, 22);
            this.lblNroMes.TabIndex = 1;
            this.lblNroMes.Text = "Número del mes:";
            // 
            // lblNombreMes
            // 
            this.lblNombreMes.AutoSize = true;
            this.lblNombreMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.lblNombreMes.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMes.Location = new System.Drawing.Point(187, 215);
            this.lblNombreMes.Name = "lblNombreMes";
            this.lblNombreMes.Size = new System.Drawing.Size(129, 22);
            this.lblNombreMes.TabIndex = 2;
            this.lblNombreMes.Text = "Nombre del mes:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabar.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(284, 288);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(118, 44);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtNombreMes
            // 
            this.txtNombreMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreMes.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMes.Location = new System.Drawing.Point(338, 215);
            this.txtNombreMes.Name = "txtNombreMes";
            this.txtNombreMes.Size = new System.Drawing.Size(166, 27);
            this.txtNombreMes.TabIndex = 4;
            // 
            // dgvMes
            // 
            this.dgvMes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.dgvMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvMes.Location = new System.Drawing.Point(191, 373);
            this.dgvMes.Name = "dgvMes";
            this.dgvMes.RowHeadersWidth = 62;
            this.dgvMes.RowTemplate.Height = 28;
            this.dgvMes.Size = new System.Drawing.Size(393, 225);
            this.dgvMes.TabIndex = 5;
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
            this.Column2.HeaderText = "Mes";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // numMes
            // 
            this.numMes.Location = new System.Drawing.Point(338, 156);
            this.numMes.Name = "numMes";
            this.numMes.Size = new System.Drawing.Size(166, 26);
            this.numMes.TabIndex = 6;
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 731);
            this.Controls.Add(this.numMes);
            this.Controls.Add(this.dgvMes);
            this.Controls.Add(this.txtNombreMes);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblNombreMes);
            this.Controls.Add(this.lblNroMes);
            this.Name = "frmMeses";
            this.Text = "Meses";
            this.Load += new System.EventHandler(this.frmMeses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroMes;
        private System.Windows.Forms.Label lblNombreMes;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtNombreMes;
        private System.Windows.Forms.DataGridView dgvMes;
        private System.Windows.Forms.NumericUpDown numMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}