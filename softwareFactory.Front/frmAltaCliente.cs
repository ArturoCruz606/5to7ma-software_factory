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
namespace softwareFactory.Front
{

    public partial class frmAltaCliente : Form
    {
        public Cliente NuevoCliente { get; set; }
        public IAdo Ado { get; set; }
        public frmAltaCliente(IAdo ado)
        {
            InitializeComponent();
            Ado = ado;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AltaCliente();
            txtDni.Text = string.Empty;
            txtIdentificador.Text = string.Empty;
            txtVerificador.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
        }
        private void AltaCliente()
        {
            string cuitEntero = txtIdentificador.Text + txtDni.Text + txtVerificador.Text;
            int cuit = int.Parse(cuitEntero);
            NuevoCliente = new Cliente(cuit, txtRazonSocial.Text);
            Ado.AltaCliente(NuevoCliente);
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
