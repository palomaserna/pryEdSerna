namespace pryEdSerna
{
    partial class frmBaseDatosOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseDatosOperaciones));
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyMultiatributo = new System.Windows.Forms.Button();
            this.btnProySimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.btnSelecMultiatributo = new System.Windows.Forms.Button();
            this.btnSelecSimple = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(73, 57);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.RowHeadersWidth = 62;
            this.dgvBaseDatos.RowTemplate.Height = 28;
            this.dgvBaseDatos.Size = new System.Drawing.Size(1056, 394);
            this.dgvBaseDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProyMultiatributo);
            this.groupBox1.Controls.Add(this.btnProySimple);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(32, 480);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnJuntar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJuntar.Location = new System.Drawing.Point(16, 143);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(254, 31);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = false;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProyMultiatributo
            // 
            this.btnProyMultiatributo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnProyMultiatributo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProyMultiatributo.Location = new System.Drawing.Point(16, 94);
            this.btnProyMultiatributo.Name = "btnProyMultiatributo";
            this.btnProyMultiatributo.Size = new System.Drawing.Size(254, 31);
            this.btnProyMultiatributo.TabIndex = 1;
            this.btnProyMultiatributo.Text = "Proyección Multiatributo";
            this.btnProyMultiatributo.UseVisualStyleBackColor = false;
            this.btnProyMultiatributo.Click += new System.EventHandler(this.btnProyMultiatributo_Click);
            // 
            // btnProySimple
            // 
            this.btnProySimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnProySimple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProySimple.Location = new System.Drawing.Point(16, 42);
            this.btnProySimple.Name = "btnProySimple";
            this.btnProySimple.Size = new System.Drawing.Size(254, 31);
            this.btnProySimple.TabIndex = 0;
            this.btnProySimple.Text = "Proyección Simple";
            this.btnProySimple.UseVisualStyleBackColor = false;
            this.btnProySimple.Click += new System.EventHandler(this.btnProySimple_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.groupBox2.Controls.Add(this.btnConvolucion);
            this.groupBox2.Controls.Add(this.btnSelecMultiatributo);
            this.groupBox2.Controls.Add(this.btnSelecSimple);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(459, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de Selección- WHERE";
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnConvolucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvolucion.Location = new System.Drawing.Point(16, 143);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(254, 31);
            this.btnConvolucion.TabIndex = 2;
            this.btnConvolucion.Text = "Selección por convolución";
            this.btnConvolucion.UseVisualStyleBackColor = false;
            this.btnConvolucion.Click += new System.EventHandler(this.btnConvolucion_Click);
            // 
            // btnSelecMultiatributo
            // 
            this.btnSelecMultiatributo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnSelecMultiatributo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecMultiatributo.Location = new System.Drawing.Point(16, 94);
            this.btnSelecMultiatributo.Name = "btnSelecMultiatributo";
            this.btnSelecMultiatributo.Size = new System.Drawing.Size(254, 31);
            this.btnSelecMultiatributo.TabIndex = 1;
            this.btnSelecMultiatributo.Text = "Selección Multiatributo";
            this.btnSelecMultiatributo.UseVisualStyleBackColor = false;
            this.btnSelecMultiatributo.Click += new System.EventHandler(this.btnSelecMultiatributo_Click);
            // 
            // btnSelecSimple
            // 
            this.btnSelecSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnSelecSimple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecSimple.Location = new System.Drawing.Point(16, 42);
            this.btnSelecSimple.Name = "btnSelecSimple";
            this.btnSelecSimple.Size = new System.Drawing.Size(254, 31);
            this.btnSelecSimple.TabIndex = 0;
            this.btnSelecSimple.Text = "Selección Simple";
            this.btnSelecSimple.UseVisualStyleBackColor = false;
            this.btnSelecSimple.Click += new System.EventHandler(this.btnSelecSimple_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(874, 480);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 192);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnDiferencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiferencia.Location = new System.Drawing.Point(16, 143);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(254, 31);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = false;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnInterseccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInterseccion.Location = new System.Drawing.Point(16, 94);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(254, 31);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = false;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnUnion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnion.Location = new System.Drawing.Point(16, 42);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(254, 31);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = false;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 695);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBaseDatos);
            this.Name = "frmBaseDatosOperaciones";
            this.Text = "BaseDatosOperaciones";
            this.Load += new System.EventHandler(this.frmBaseDatosOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyMultiatributo;
        private System.Windows.Forms.Button btnProySimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.Button btnSelecMultiatributo;
        private System.Windows.Forms.Button btnSelecSimple;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}