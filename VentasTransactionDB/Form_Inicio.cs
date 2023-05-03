﻿using AccesoDatos;
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
                //MostrarClientes();
                //MostrarProducto();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Agregar Producto a la lista.
        private void button2_Click(object sender, EventArgs e)
        { 

            Producto producto = new Producto();
            producto.Descripcion = textBox1.Text;
            producto.PrecioUnitario = Convert.ToDecimal(textBox3.Text);
            producto.CrearProducto(producto);
            MessageBox.Show("Producto Agregado");

        }
        //Editar Producto.
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

        //-------------------Métodos para los C L I E N T E S --------------------------------
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
        }

        private void MostrarClientes()
        {
            Cliente clientes = new Cliente();
            SqlDataAdapter adapter = clientes.MostrarClientes();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void EditarCliente(int id)
        {
            Cliente cliente = new Cliente();
            cliente.Id = id;
            cliente.ActualizarCliente(cliente);
        }
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Id"].Value);
                EditarCliente(id);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente ();
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                cliente.EliminarCliente(id);
            }
        }

        //-------------------Métodos para la V E N T A --------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Venta venta = new Venta();
                venta.ClienteId = 1;

                VentaDetalle producto1 = new VentaDetalle();
                producto1.ProductoId = 1;
                producto1.Cantidad = 1;
                producto1.Descripcion = "Azucar kg";
                producto1.PrecioUnitario = 27.00m;
                producto1.Importe = producto1.Cantidad * producto1.PrecioUnitario;
                venta.Conceptos.Add(producto1);

                VentaDetalle producto2 = new VentaDetalle();
                producto2.ProductoId = 2;
                producto2.Cantidad = 1;
                producto2.Descripcion = "Jugo Mango";
                producto2.PrecioUnitario = 10.00m;
                producto2.Importe = producto2.Cantidad * producto2.PrecioUnitario;
                venta.Conceptos.Add(producto2);

                venta.Total = producto1.Importe + producto2.Importe;
                venta.GuardarVenta(venta);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrio un error al guardar la venta {ex.Message}");
            }



            MessageBox.Show("La venta se ha realizado con éxito");

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
