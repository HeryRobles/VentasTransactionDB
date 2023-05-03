using AccesoDatos;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace VentasTransactionDB
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
            try
            {
                MostrarProducto();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        { 

            Producto producto = new Producto();
            producto.Descripcion = textBox1.Text;
            producto.PrecioUnitario = Convert.ToDecimal(textBox3.Text);
            producto.CrearProducto(producto);
            MessageBox.Show("Producto Agregado");

        }

        private void EditarProd(int id)
        {
            Producto producto = new Producto();
            producto.Id = id;
            producto.ActualizarProducto(producto);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                EditarProd(id);
            }

        }

        //private void EliminarProd(int id)
        //{
        //    Producto producto = new Producto();
        //    producto.Id = id;
        //    producto.EliminarProducto(producto);
        //}
        private void button5_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                producto.EliminarProducto(id);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[2].Value.ToString();

        }

        private void MostrarProducto()
        {
            Producto prod = new Producto();
            SqlDataAdapter adapter = prod.MostrarProducto();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = textBox2.Text;
            cliente.AgregarCliente(cliente);
            MessageBox.Show("Cliente Agregado");
        }

        //CREAR LA VENTA:
               
        private void button1_Click(object sender, EventArgs e)
        {
            VentaDetalle conceptos = new VentaDetalle();
            Venta venta = new Venta();
            venta.GuardarVenta(venta);
            MessageBox.Show("La venta se ha realizado con éxito");
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
        }

        private void MostrarClientes()
        {
            Cliente clientes = new Cliente();
            SqlDataAdapter adapter = clientes.MostrarClientes();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
