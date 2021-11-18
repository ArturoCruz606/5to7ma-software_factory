using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softwareFactory.Front
{
    public partial class frmClienteMenu : Form
    {
        public frmClienteMenu()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAltaCliente nuevoCliente = new frmAltaCliente();
            
            Hide();
            nuevoCliente.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            frmClientes mostrarClientes = new frmClientes();

            Hide();
            mostrarClientes.ShowDialog();
        }
    }
}
