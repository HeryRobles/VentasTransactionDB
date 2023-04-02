using AccesoDatos;
using AccesoDatos.Metodos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VentasTransactionDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction metodos = new Transaction();
            Transaction(metodos.GuardarVenta());
        }
  
    }
}


