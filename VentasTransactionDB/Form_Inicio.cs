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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int productoId;
                if (int.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out productoId))
                {
                    Producto accesoProductos = new Producto();
                    accesoProductos.EliminarProducto(productoId);
                    MostrarProducto();
                 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
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

        
        private void button1_Click(object sender, EventArgs e)
        {
            VentaDetalle producto = new VentaDetalle();
            producto.ProductoId = 1;
            producto.Descripcion = textBox1.Text;
            producto.PrecioUnitario = Convert.ToDecimal(textBox3.Text);
            producto.Importe = producto.Cantidad * producto.PrecioUnitario;

            Venta venta = new Venta();
            venta.Conceptos.Add(producto);

            //Venta nvaVenta = new Venta();
            Form_Inicio formulario = new Form_Inicio();



            venta.GuardarVenta(venta);
        }

       
    }
}
