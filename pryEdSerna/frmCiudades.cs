﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdSerna
{
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }
        ClsArchivo x=new ClsArchivo();
        private void frmCiudades_Load(object sender, EventArgs e)
        {
            x.NombreArchivo = "Ciudades.csv";
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
           x.Grabar(txtCiudades.Text);
            x.Recorrer(lstCiudades);
            txtCiudades.Text = "";
        }
    }
}
