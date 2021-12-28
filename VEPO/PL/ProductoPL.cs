using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VEPO.DAL;
using VEPO.BLL;


namespace VEPO.PL
{
    public partial class ProductoPL : Form
    {
        ProductoBLL productoBLL;
        ProductoDAL productoDAL;

        public ProductoPL()
        {
            InitializeComponent();
            LlenarDGVinsumo();
        }

        public void LimpiarEntradasEspecie()
        {
            txt_nombre.Text = "";
            txt_local.Text = "";
            txt_peya.Text = "";
            txt_carne.Text = "";
            txt_papa.Text = "";
            txt_bono.Text = "";
            txt_categoria.Text = "";
            lb_id_producto.Text = "0";
        }

        private ProductoBLL ExtraerDatos()
        {
            productoBLL = new ProductoBLL();
            productoBLL.Id_producto = Convert.ToInt32(lb_id_producto.Text);
            productoBLL.Nombre_producto = txt_nombre.Text;
            productoBLL.PrecioLocal_producto = Convert.ToDouble(txt_local.Text);
            productoBLL.PrecioDelivery_producto = Convert.ToDouble(txt_peya.Text);
            productoBLL.Carne_producto = Convert.ToInt32(txt_carne.Text);
            productoBLL.Papa_producto = Convert.ToInt32(txt_papa.Text);
            productoBLL.Bono_producto = Convert.ToDouble(txt_bono.Text);
            productoBLL.Categoria_producto = txt_categoria.Text;
            return productoBLL;
        }


        #region CRUD
        private void btn_agregar_esp_Click(object sender, EventArgs e)
        {
            productoDAL = new ProductoDAL();
            productoDAL.Agregar(ExtraerDatos());
            LlenarDGVinsumo();
        }

        private void btn_modificar_esp_Click(object sender, EventArgs e)
        {
            productoDAL = new ProductoDAL();
            productoDAL.Modificar(ExtraerDatos());
            LlenarDGVinsumo();
        }

        private void btn_borrar_esp_Click(object sender, EventArgs e)
        {
            productoDAL = new ProductoDAL();
            productoDAL.Eliminar(ExtraerDatos());
            LlenarDGVinsumo();
        }
        #endregion


       

        #region DataGridView

        public void LlenarDGVinsumo()
        {
            productoDAL = new ProductoDAL();

            dataGridView1.DataSource = productoDAL.LlenarDGV().Tables[0];
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "$ Local";
            dataGridView1.Columns[3].HeaderText = "$ Peya";
            dataGridView1.Columns[4].HeaderText = "Carne";
            dataGridView1.Columns[5].HeaderText = "Papa";
            dataGridView1.Columns[6].HeaderText = "Bono";
            dataGridView1.Columns[7].HeaderText = "Categoria";
            dataGridView1.Columns[0].Visible = false;

            LimpiarEntradasEspecie();
            txt_nombre.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            lb_id_producto.Text = row.Cells[0].Value.ToString();
            txt_nombre.Text = row.Cells[1].Value.ToString();
            txt_local.Text = row.Cells[2].Value.ToString();
            txt_peya.Text = row.Cells[3].Value.ToString();
            txt_carne.Text = row.Cells[4].Value.ToString();
            txt_papa.Text = row.Cells[5].Value.ToString();
            txt_bono.Text = row.Cells[6].Value.ToString();
            txt_categoria.Text = row.Cells[7].Value.ToString();
        }

        #endregion
    }
}
