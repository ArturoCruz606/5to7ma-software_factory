using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using softwareFactory.Core;
using softwareFactory.AdoMySQL;
using et12.edu.ar.AGBD.Ado;

namespace softwareFactory.Front
{

    public partial class frmAltaCliente : Form
    {
        public Cliente NuevoCliente { get; set;  }
        public AdoSoftware AdoSoftware { get; set; }

        public frmAltaCliente()
        {
            InitializeComponent();
            var adoAGBD = FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "test");
            AdoSoftware = new AdoSoftware(adoAGBD);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AltaCliente();
        }
        private void AltaCliente()
        {
            string cuitEntero = txtIdentificador.Text + txtDni.Text + txtVerificador.Text;
            int cuit = int.Parse(cuitEntero);
            NuevoCliente = new Cliente(cuit, txtRazonSocial.Text);
            AdoSoftware.AltaCliente(NuevoCliente);
            MessageBox.Show("Cliente agregado");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmClienteMenu volver = new frmClienteMenu();

            volver.Show();
            Close();
        }
    }
}
