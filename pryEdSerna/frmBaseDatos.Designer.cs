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
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(21, 8);
            this.dgvBaseDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.RowHeadersWidth = 62;
            this.dgvBaseDatos.RowTemplate.Height = 28;
            this.dgvBaseDatos.Size = new System.Drawing.Size(704, 280);
            this.dgvBaseDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProyMultiatributo);
            this.groupBox1.Controls.Add(this.btnProySimple);
            this.groupBox1.Location = new System.Drawing.Point(21, 312);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(203, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(11, 93);
            this.btnJuntar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(169, 20);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProyMultiatributo
            // 
            this.btnProyMultiatributo.Location = new System.Drawing.Point(11, 61);
            this.btnProyMultiatributo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProyMultiatributo.Name = "btnProyMultiatributo";
            this.btnProyMultiatributo.Size = new System.Drawing.Size(169, 20);
            this.btnProyMultiatributo.TabIndex = 1;
            this.btnProyMultiatributo.Text = "Proyección Multiatributo";
            this.btnProyMultiatributo.UseVisualStyleBackColor = true;
            this.btnProyMultiatributo.Click += new System.EventHandler(this.btnProyMultiatributo_Click);
            // 
            // btnProySimple
            // 
            this.btnProySimple.Location = new System.Drawing.Point(11, 27);
            this.btnProySimple.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProySimple.Name = "btnProySimple";
            this.btnProySimple.Size = new System.Drawing.Size(169, 20);
            this.btnProySimple.TabIndex = 0;
            this.btnProySimple.Text = "Proyección Simple";
            this.btnProySimple.UseVisualStyleBackColor = true;
            this.btnProySimple.Click += new System.EventHandler(this.btnProySimple_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConvolucion);
            this.groupBox2.Controls.Add(this.btnSelecMultiatributo);
            this.groupBox2.Controls.Add(this.btnSelecSimple);
            this.groupBox2.Location = new System.Drawing.Point(306, 312);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(203, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de Selección- WHERE";
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.Location = new System.Drawing.Point(11, 93);
            this.btnConvolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(169, 20);
            this.btnConvolucion.TabIndex = 2;
            this.btnConvolucion.Text = "Selección por convolución";
            this.btnConvolucion.UseVisualStyleBackColor = true;
            // 
            // btnSelecMultiatributo
            // 
            this.btnSelecMultiatributo.Location = new System.Drawing.Point(11, 61);
            this.btnSelecMultiatributo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelecMultiatributo.Name = "btnSelecMultiatributo";
            this.btnSelecMultiatributo.Size = new System.Drawing.Size(169, 20);
            this.btnSelecMultiatributo.TabIndex = 1;
            this.btnSelecMultiatributo.Text = "Selección Multiatributo";
            this.btnSelecMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnSelecSimple
            // 
            this.btnSelecSimple.Location = new System.Drawing.Point(11, 27);
            this.btnSelecSimple.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelecSimple.Name = "btnSelecSimple";
            this.btnSelecSimple.Size = new System.Drawing.Size(169, 20);
            this.btnSelecSimple.TabIndex = 0;
            this.btnSelecSimple.Text = "Selección Simple";
            this.btnSelecSimple.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Location = new System.Drawing.Point(583, 312);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(203, 125);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(11, 93);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(169, 20);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(11, 61);
            this.btnInterseccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(169, 20);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(11, 27);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(169, 20);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBaseDatos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBaseDatosOperaciones";
            this.Text = "frmBaseDatos";
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