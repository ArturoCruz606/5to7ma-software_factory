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
using et12.edu.ar.AGBD.Ado;
using softwareFactory.AdoMySQL;

namespace softwareFactory.Front
{
    public partial class frmClientes : Form
    {
        //Agregar using para esto
        List<Cliente> Clientes { get; set; }
        public AdoSoftware Ado { get; set; }

        //Recibir ado por paramentro
        public frmClientes(AdoSoftware ado)
        {
            InitializeComponent();
            Ado = ado;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        public void CompletarGrid()
        {
            Clientes = Ado.ObtenerClientes();
            //Asignar la lista de cliente en base a lo que devuelva el ado
            dgvClientes.DataSource = Clientes;
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmClienteMenu volver = new frmClienteMenu();

            volver.Show();
            Close();
        }
    }
}
