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
    public partial class EmpleadoPL : Form
    {
        EmpleadoBLL empleadoBLL;
        EmpleadoDAL empleadoDAL;

        public EmpleadoPL()
        {
            InitializeComponent();
            LlenarDGVinsumo();
        }

        public void LimpiarEntradas()
        {
            txt_empleado.Text = "";
            txt_convenio.Text = "";
            lb_id_especie.Text = "0";
        }

        private EmpleadoBLL ExtraerDatos()
        {
            empleadoBLL = new EmpleadoBLL();
            empleadoBLL.Id_empleado = Convert.ToInt32(lb_id_especie.Text);
            empleadoBLL.Nombre_empleado = txt_empleado.Text;
            empleadoBLL.Convenio_empleado = Convert.ToDouble(txt_convenio.Text);
            return empleadoBLL;
        }


        #region CRUD
        private void btn_agregar_esp_Click(object sender, EventArgs e)
        {
            empleadoDAL = new EmpleadoDAL();
            empleadoDAL.Agregar(ExtraerDatos());
            LlenarDGVinsumo();
        }

        private void btn_modificar_esp_Click(object sender, EventArgs e)
        {
            empleadoDAL = new EmpleadoDAL();
            empleadoDAL.Modificar(ExtraerDatos());
            LlenarDGVinsumo();
        }

        private void btn_borrar_esp_Click(object sender, EventArgs e)
        {
            empleadoDAL = new EmpleadoDAL();
            empleadoDAL.Eliminar(ExtraerDatos());
            LlenarDGVinsumo();
        }
        #endregion


       

        #region DataGridView

        public void LlenarDGVinsumo()
        {
            empleadoDAL = new EmpleadoDAL();

            dataGridView1.DataSource = empleadoDAL.LlenarDGV().Tables[0];
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "$/H";
            dataGridView1.Columns[0].Visible = false;

            LimpiarEntradas();
            txt_empleado.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            lb_id_especie.Text = row.Cells[0].Value.ToString();
            txt_empleado.Text = row.Cells[1].Value.ToString();
            txt_convenio.Text = row.Cells[2].Value.ToString();
        }

        #endregion
    }
}
