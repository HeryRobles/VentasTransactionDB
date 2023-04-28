using System;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace VentasTransactionDB
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Productos fProd = new Form_Productos();
            fProd.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Clientes form_Clientes = new Form_Clientes();
            form_Clientes.Show();   
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Existencias fInventario = new Form_Existencias();  
            fInventario.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ventas fVenta = new Form_Ventas();
            fVenta.Show();
        }
    }
}
