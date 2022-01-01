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
    public partial class JornalPL : Form
    {
        JornalBLL jornalBLL;
        JornalDAL jornalDAL;

        string fecha;
        public JornalPL(string Fecha)
        {
            InitializeComponent();
            LlenarDGVcompra(Fecha);
            CargarCBO();
            fecha = Fecha;
        }

        public void LimpiarEntradas()
        {
            cb_insumo.Text = "";
            txt_entrada.Text = "";
            txt_salida.Text = "";
            lb_id_compra.Text = "0";
        }

        private JornalBLL ExtraerDatos()
        {
            jornalBLL = new JornalBLL();
            jornalBLL.Id_jornal = Convert.ToInt32(lb_id_compra.Text);
            jornalBLL.Fecha_jornal = fecha;
            jornalBLL.Entrada_jornal = txt_entrada.Text;
            jornalBLL.Salida_jornal = txt_salida.Text;

            jornalDAL = new JornalDAL();
            DataTable dt= jornalDAL.CalcularBono(fecha);
            double bono = 0;
            foreach (DataRow dr in dt.Rows)
            {
                bono += Convert.ToDouble(dr[0]);
            }
            jornalBLL.Bono_jornal= bono;



            int.TryParse(cb_insumo.SelectedValue.ToString(), out int empleado);
            jornalBLL.Id_empleadoJ = empleado;

            
            DataTable dtJ = jornalDAL.CalcularJornal(empleado);
            double convenio = 0;
            foreach (DataRow dr in dtJ.Rows)
            {
                convenio += Convert.ToDouble(dr[0]);
            }

            DateTime entrada=Convert.ToDateTime(txt_entrada.Text);
            DateTime salida = Convert.ToDateTime(txt_salida.Text);
            double horas = salida.Subtract(entrada).TotalHours; 
            double totalH= horas * convenio;

            jornalBLL.Total_jornal = totalH+bono;

            return jornalBLL;
        }


        #region CRUD
        private void btn_agregar_esp_Click(object sender, EventArgs e)
        {
            jornalDAL = new JornalDAL();
            jornalDAL.Agregar(ExtraerDatos());
            LlenarDGVcompra(fecha);
        }

        private void btn_modificar_esp_Click(object sender, EventArgs e)
        {
            jornalDAL = new JornalDAL();
            jornalDAL.Modificar(ExtraerDatos());
            LlenarDGVcompra(fecha);
        }

        private void btn_borrar_esp_Click(object sender, EventArgs e)
        {
            jornalDAL = new JornalDAL();
            jornalDAL.Eliminar(ExtraerDatos());
            LlenarDGVcompra(fecha);
        }
        #endregion


       

        #region DataGridView

        public void LlenarDGVcompra(string fecha)
        {
            jornalDAL = new JornalDAL();
            try
            {
                dataGridView1.DataSource = jornalDAL.LlenarWhereFecha(fecha).Tables[0];
                dataGridView1.Columns[0].HeaderText = "Nombre";
                dataGridView1.Columns[1].HeaderText = "Id";
                dataGridView1.Columns[2].HeaderText = "Fecha";
                dataGridView1.Columns[3].HeaderText = "Entrada";
                dataGridView1.Columns[4].HeaderText = "Salida";
                dataGridView1.Columns[5].HeaderText = "Bono";
                dataGridView1.Columns[6].HeaderText = "Total";
                dataGridView1.Columns[7].HeaderText = "IdEmpleado";
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "no hay datos");
            }

            LimpiarEntradas();
            cb_insumo.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            lb_id_compra.Text = row.Cells[1].Value.ToString();
            cb_insumo.Text = row.Cells[0].Value.ToString();
            txt_entrada.Text = row.Cells[3].Value.ToString();
            txt_salida.Text = row.Cells[4].Value.ToString();
        }

        #endregion

        #region ComboBOX

        private void CargarCBO()
        {
            //CARGO EL CBO DE CLIENTE
            EmpleadoDAL empleadoDAL = new EmpleadoDAL();
            cb_insumo.DataSource = empleadoDAL.LlenarDGV().Tables[0];
            cb_insumo.DisplayMember = "Nombre_empleado";//va a mostrar el valor de ese campo pero
            cb_insumo.ValueMember = "Id_empleado";// el valor de ese campo en el CB sera este
            cb_insumo.SelectedItem = null;

        }

        #endregion

    }
}
