namespace pryEdSerna
{
    partial class frmBaseDatosMostrarTabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseDatosMostrarTabla));
            this.dgvBase = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBase
            // 
            this.dgvBase.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBase.Location = new System.Drawing.Point(44, 69);
            this.dgvBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBase.Name = "dgvBase";
            this.dgvBase.RowHeadersWidth = 62;
            this.dgvBase.Size = new System.Drawing.Size(1084, 545);
            this.dgvBase.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnMostrar.Location = new System.Drawing.Point(1016, 630);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(112, 35);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cmbTabla
            // 
            this.cmbTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.cmbTabla.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTabla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Items.AddRange(new object[] {
            "Idioma",
            "Autor ",
            "Libro",
            "Pais"});
            this.cmbTabla.Location = new System.Drawing.Point(814, 630);
            this.cmbTabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(180, 28);
            this.cmbTabla.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(637, 636);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la tabla";
            // 
            // frmBaseDatosMostrarTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1173, 697);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvBase);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBaseDatosMostrarTabla";
            this.Text = "Base de Datos Mostrar Tabla";
            this.Load += new System.EventHandler(this.frmBaseDatosMostrarTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBase;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.Label label1;
    }
}