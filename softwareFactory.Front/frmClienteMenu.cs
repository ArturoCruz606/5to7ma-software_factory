using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using softwareFactory.AdoMySQL;
using softwareFactory.Core;
using et12.edu.ar.AGBD.Ado;


namespace softwareFactory.Front
{
    public partial class frmClienteMenu : Form
    {
        public IAdo AdoSoftware { get; set; }
        public frmClienteMenu()
        {
            InitializeComponent();
            var adoAGBD = FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "test");
            AdoSoftware = new AdoSoftware(adoAGBD);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAltaCliente nuevoCliente = new frmAltaCliente(AdoSoftware);
            
            Hide();
            nuevoCliente.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            frmClientes mostrarClientes = new frmClientes(AdoSoftware);

            Hide();
            mostrarClientes.ShowDialog();
        }
    }
}
