namespace pryEdSerna
{
    partial class frmGrafo
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
            this.grpCargadDatos = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrarCarga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDestinoCarga = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbOrigenCarga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDestinoConsulta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOrigenConsulta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnOrigenes = new System.Windows.Forms.Button();
            this.cmbDestinoListar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDestinos = new System.Windows.Forms.Button();
            this.cmbOrigenListar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCargadDatos.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCargadDatos
            // 
            this.grpCargadDatos.Controls.Add(this.btnCargar);
            this.grpCargadDatos.Controls.Add(this.btnBorrarCarga);
            this.grpCargadDatos.Controls.Add(this.label3);
            this.grpCargadDatos.Controls.Add(this.label2);
            this.grpCargadDatos.Controls.Add(this.cmbDestinoCarga);
            this.grpCargadDatos.Controls.Add(this.txtPrecio);
            this.grpCargadDatos.Controls.Add(this.cmbOrigenCarga);
            this.grpCargadDatos.Controls.Add(this.label1);
            this.grpCargadDatos.Location = new System.Drawing.Point(249, 33);
            this.grpCargadDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grpCargadDatos.Name = "grpCargadDatos";
            this.grpCargadDatos.Padding = new System.Windows.Forms.Padding(2);
            this.grpCargadDatos.Size = new System.Drawing.Size(206, 175);
            this.grpCargadDatos.TabIndex = 0;
            this.grpCargadDatos.TabStop = false;
            this.grpCargadDatos.Text = "Carga de Datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(117, 136);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(66, 27);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrarCarga
            // 
            this.btnBorrarCarga.Location = new System.Drawing.Point(17, 136);
            this.btnBorrarCarga.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarCarga.Name = "btnBorrarCarga";
            this.btnBorrarCarga.Size = new System.Drawing.Size(71, 27);
            this.btnBorrarCarga.TabIndex = 6;
            this.btnBorrarCarga.Text = "Borrar Todo";
            this.btnBorrarCarga.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destino:";
            // 
            // cmbDestinoCarga
            // 
            this.cmbDestinoCarga.FormattingEnabled = true;
            this.cmbDestinoCarga.Location = new System.Drawing.Point(58, 62);
            this.cmbDestinoCarga.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestinoCarga.Name = "cmbDestinoCarga";
            this.cmbDestinoCarga.Size = new System.Drawing.Size(111, 21);
            this.cmbDestinoCarga.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(58, 94);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(111, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // cmbOrigenCarga
            // 
            this.cmbOrigenCarga.FormattingEnabled = true;
            this.cmbOrigenCarga.Location = new System.Drawing.Point(58, 25);
            this.cmbOrigenCarga.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOrigenCarga.Name = "cmbOrigenCarga";
            this.cmbOrigenCarga.Size = new System.Drawing.Size(111, 21);
            this.cmbOrigenCarga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen:";
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnBorrar);
            this.grpConsulta.Controls.Add(this.btnConsultar);
            this.grpConsulta.Controls.Add(this.label6);
            this.grpConsulta.Controls.Add(this.cmbDestinoConsulta);
            this.grpConsulta.Controls.Add(this.label5);
            this.grpConsulta.Controls.Add(this.cmbOrigenConsulta);
            this.grpConsulta.Controls.Add(this.label4);
            this.grpConsulta.Location = new System.Drawing.Point(482, 33);
            this.grpConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Padding = new System.Windows.Forms.Padding(2);
            this.grpConsulta.Size = new System.Drawing.Size(203, 175);
            this.grpConsulta.TabIndex = 1;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta de Datos";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(105, 136);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(66, 27);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(13, 136);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(71, 27);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio:";
            // 
            // cmbDestinoConsulta
            // 
            this.cmbDestinoConsulta.FormattingEnabled = true;
            this.cmbDestinoConsulta.Location = new System.Drawing.Point(61, 60);
            this.cmbDestinoConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestinoConsulta.Name = "cmbDestinoConsulta";
            this.cmbDestinoConsulta.Size = new System.Drawing.Size(111, 21);
            this.cmbDestinoConsulta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Destino:";
            // 
            // cmbOrigenConsulta
            // 
            this.cmbOrigenConsulta.FormattingEnabled = true;
            this.cmbOrigenConsulta.Location = new System.Drawing.Point(61, 25);
            this.cmbOrigenConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOrigenConsulta.Name = "cmbOrigenConsulta";
            this.cmbOrigenConsulta.Size = new System.Drawing.Size(111, 21);
            this.cmbOrigenConsulta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Origen:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerTodo);
            this.groupBox3.Controls.Add(this.btnOrigenes);
            this.groupBox3.Controls.Add(this.cmbDestinoListar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnDestinos);
            this.groupBox3.Controls.Add(this.cmbOrigenListar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dgvGrafo);
            this.groupBox3.Location = new System.Drawing.Point(8, 226);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(689, 268);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listar viajes";
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(584, 19);
            this.btnVerTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(93, 38);
            this.btnVerTodo.TabIndex = 12;
            this.btnVerTodo.Text = "Ver todos los viajes";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            // 
            // btnOrigenes
            // 
            this.btnOrigenes.Location = new System.Drawing.Point(469, 19);
            this.btnOrigenes.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrigenes.Name = "btnOrigenes";
            this.btnOrigenes.Size = new System.Drawing.Size(93, 27);
            this.btnOrigenes.TabIndex = 11;
            this.btnOrigenes.Text = "Listar Origenes";
            this.btnOrigenes.UseVisualStyleBackColor = true;
            // 
            // cmbDestinoListar
            // 
            this.cmbDestinoListar.FormattingEnabled = true;
            this.cmbDestinoListar.Location = new System.Drawing.Point(337, 24);
            this.cmbDestinoListar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestinoListar.Name = "cmbDestinoListar";
            this.cmbDestinoListar.Size = new System.Drawing.Size(111, 21);
            this.cmbDestinoListar.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hasta:";
            // 
            // btnDestinos
            // 
            this.btnDestinos.Location = new System.Drawing.Point(179, 19);
            this.btnDestinos.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(93, 27);
            this.btnDestinos.TabIndex = 8;
            this.btnDestinos.Text = "Listar Destinos";
            this.btnDestinos.UseVisualStyleBackColor = true;
            // 
            // cmbOrigenListar
            // 
            this.cmbOrigenListar.FormattingEnabled = true;
            this.cmbOrigenListar.Location = new System.Drawing.Point(52, 24);
            this.cmbOrigenListar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOrigenListar.Name = "cmbOrigenListar";
            this.cmbOrigenListar.Size = new System.Drawing.Size(111, 21);
            this.cmbOrigenListar.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Desde:";
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvGrafo.Location = new System.Drawing.Point(11, 92);
            this.dgvGrafo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.RowHeadersWidth = 62;
            this.dgvGrafo.RowTemplate.Height = 28;
            this.dgvGrafo.Size = new System.Drawing.Size(513, 154);
            this.dgvGrafo.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ciudad ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 163);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpCargadDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.grpCargadDatos.ResumeLayout(false);
            this.grpCargadDatos.PerformLayout();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCargadDatos;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBorrarCarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDestinoCarga;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbOrigenCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDestinoConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOrigenConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnOrigenes;
        private System.Windows.Forms.ComboBox cmbDestinoListar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.ComboBox cmbOrigenListar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}