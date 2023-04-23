using AccesoDatos;
using System;
using System.Windows.Forms;

namespace VentasTransactionDB
{
    public partial class Form_Productos : Form
    {
        public Form_Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();
                producto.Descripcion = textBox1.Text;
                producto.PrecioUnitario = Convert.ToDecimal(textBox2.Text);
                producto.CrearProducto(producto);
                MessageBox.Show("Producto Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1 = new DataGridView();
            ExistenciaProd inventario = new ExistenciaProd();
            inventario.MostrarTablaExistencia();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
