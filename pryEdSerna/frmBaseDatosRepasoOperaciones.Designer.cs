namespace pryEdSerna
{
    partial class frmBaseDatosRepasoOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseDatosRepasoOperaciones));
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(49, 358);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 62;
            this.dgvConsulta.RowTemplate.Height = 28;
            this.dgvConsulta.Size = new System.Drawing.Size(909, 356);
            this.dgvConsulta.TabIndex = 3;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(863, 45);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(95, 29);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cmbTabla
            // 
            this.cmbTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.cmbTabla.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTabla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(346, 44);
            this.cmbTabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(442, 28);
            this.cmbTabla.TabIndex = 5;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruccion.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.lblInstruccion.Location = new System.Drawing.Point(39, 45);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(299, 22);
            this.lblInstruccion.TabIndex = 7;
            this.lblInstruccion.Text = "Operación a realizar en la base de datos:";
            // 
            // txtOperacion
            // 
            this.txtOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.txtOperacion.Location = new System.Drawing.Point(49, 129);
            this.txtOperacion.Multiline = true;
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.ReadOnly = true;
            this.txtOperacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOperacion.Size = new System.Drawing.Size(800, 157);
            this.txtOperacion.TabIndex = 8;
            // 
            // frmBaseDatosRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 740);
            this.Controls.Add(this.txtOperacion);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvConsulta);
            this.Name = "frmBaseDatosRepasoOperaciones";
            this.Text = "Base de Datos Repaso de Operaciones";
            this.Load += new System.EventHandler(this.frmBaseDatosRepasoOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox txtOperacion;
    }
}