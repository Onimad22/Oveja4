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
    public partial class InsumoPL : Form
    {
        InsumoBLL insumoBLL;
        InsumoDAL insumoDAL;

        public InsumoPL()
        {
            InitializeComponent();
            LlenarDGVinsumo();
        }

        public void LimpiarEntradasEspecie()
        {
            txt_especie.Text = "";
            txt_categoria.Text = "";
            lb_id_especie.Text = "0";
        }

        private InsumoBLL ExtraerDatos()
        {
            insumoBLL = new InsumoBLL();
            insumoBLL.Id_insumo = Convert.ToInt32(lb_id_especie.Text);
            insumoBLL.Nombre_insumo = txt_especie.Text;
            insumoBLL.Categoria_insumo = txt_categoria.Text;
            return insumoBLL;
        }


        #region CRUD
        private void btn_agregar_esp_Click(object sender, EventArgs e)
        {
            insumoDAL = new InsumoDAL();
            insumoDAL.Agregar(ExtraerDatos());
            LlenarDGVinsumo();
        }

        private void btn_modificar_esp_Click(object sender, EventArgs e)
        {
            insumoDAL = new InsumoDAL();
            insumoDAL.Modificar(ExtraerDatos());
            LlenarDGVinsumo();
        }

        private void btn_borrar_esp_Click(object sender, EventArgs e)
        {
            insumoDAL = new InsumoDAL();
            insumoDAL.Eliminar(ExtraerDatos());
            LlenarDGVinsumo();
        }
        #endregion


       

        #region DataGridView

        public void LlenarDGVinsumo()
        {
            insumoDAL = new InsumoDAL();

            dataGridView1.DataSource = insumoDAL.LlenarDGV().Tables[0];
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Categoria";
            dataGridView1.Columns[0].Visible = false;

            LimpiarEntradasEspecie();
            txt_especie.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            lb_id_especie.Text = row.Cells[0].Value.ToString();
            txt_especie.Text = row.Cells[1].Value.ToString();
            txt_categoria.Text = row.Cells[2].Value.ToString();
        }

        #endregion
    }
}
