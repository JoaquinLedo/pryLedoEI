﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryLedoEI
{
    public partial class frmNavegar : Form
    {
        public frmNavegar()
        {
            InitializeComponent();
        }

        private void btnAbrirCarpetas_Click(object sender, EventArgs e)
        {
            ventanaCarpetas.ShowDialog();

            //seleccionar una carpeta
            lblEjemplo.Text = ventanaCarpetas.SelectedPath;

        }

        private void btnGrabarArchivo_Click(object sender, EventArgs e)
        {
            //ruta del archivo
            string ruta = lblEjemplo.Text;
            //nombre del archivo
            ruta += "/" +  txtNombreArchivo.Text;

            StreamWriter manejoArchivo = new StreamWriter(ruta);

            MessageBox.Show("Archivo creado " + txtNombreArchivo.Text);

        }

        private void frmNavegar_Load(object sender, EventArgs e)
        {

        }
    }
}
