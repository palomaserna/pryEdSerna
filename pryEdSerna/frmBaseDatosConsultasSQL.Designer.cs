namespace pryEdSerna
{
    partial class frmBaseDatosConsultasSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseDatosConsultasSQL));
            this.lblConsulta = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblConsulta.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.lblConsulta.Location = new System.Drawing.Point(27, 34);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(128, 22);
            this.lblConsulta.TabIndex = 0;
            this.lblConsulta.Text = "Consulta en SQL:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.txtConsulta.Location = new System.Drawing.Point(32, 71);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsulta.Size = new System.Drawing.Size(985, 153);
            this.txtConsulta.TabIndex = 1;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(32, 265);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 62;
            this.dgvConsulta.RowTemplate.Height = 28;
            this.dgvConsulta.Size = new System.Drawing.Size(986, 385);
            this.dgvConsulta.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(934, 231);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(82, 29);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmBaseDatosConsultasSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1245, 662);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lblConsulta);
            this.Name = "frmBaseDatosConsultasSQL";
            this.Text = "Base de Datos ConsultasSQL";
            this.Load += new System.EventHandler(this.frmBaseDatosConsultasSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnListar;
    }
}