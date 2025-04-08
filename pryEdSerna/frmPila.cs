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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila FilaPila = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            FilaPila.Agregar(Persona);

            FilaPila.Recorrer();//Grabo archivo
            FilaPila.Recorrer(dgvPila);//Muestro en grilla
            FilaPila.Recorrer(lstPila);//Muestra en lista
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaPila.Primero != null)
            {
                lblCod.Text = FilaPila.Primero.Codigo.ToString();
                lblNom.Text = FilaPila.Primero.Nombre;
                lblTra.Text = FilaPila.Primero.Tramite;

                FilaPila.Eliminar();

                FilaPila.Recorrer();//Grabo archivo
                FilaPila.Recorrer(lstPila);//Muestro en grilla
                FilaPila.Recorrer(lstPila);//Muestra en lista
            }
            else
            {
                lblCod.Text = "";
                lblNom.Text = "";
                lblTra.Text = "";

            }
        }
    }
}
