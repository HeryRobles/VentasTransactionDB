using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using AccesoDatos;
using FontAwesome.Sharp;

namespace VentasTransactionDB
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }

        //private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form_Productos fProd = new Form_Productos();
        //    fProd.Show();
        //}

        //private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form_Clientes form_Clientes = new Form_Clientes();
        //    form_Clientes.Show();   
        //}

        //private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Form_Existencias fInventario = new Form_Existencias();  
        //    fInventario.Show();
        //}

        //private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();
                producto.Descripcion = textBox1.Text;
                producto.PrecioUnitario = Convert.ToDecimal(textBox3.Text);
                producto.CrearProducto(producto);
                MessageBox.Show("Producto Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente= new Cliente();
            cliente.Nombre= textBox2.Text;
            cliente.AgregarCliente(cliente);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView1 = new DataGridView();
            ExistenciaProd inventario = new ExistenciaProd();
            inventario.MostrarTablaExistencia();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Venta nvaVenta = new Venta();
            Form_Inicio formulario = new Form_Inicio(); 

            

            nvaVenta.GuardarVenta(venta);
        }
    }
}
