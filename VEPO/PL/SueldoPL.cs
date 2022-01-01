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
    public partial class SueldoPL : Form
    {
        SueldoBLL sueldoBLL;
        SueldoDAL sueldoDAL;
        string fecha;

        public SueldoPL(string Fecha)
        {
            InitializeComponent();
            CargarCBO();
            fecha = Fecha;
        }

        private SueldoBLL ExtraerDatos()
        {
            int.TryParse(cb_insumo.SelectedValue.ToString(), out int empleado);

            sueldoBLL = new SueldoBLL();
            sueldoBLL.Id_sueldo= Convert.ToInt32(lb_id_compra.Text);
            sueldoBLL.Fecha_sueldo = fecha;

            sueldoDAL = new SueldoDAL();
            DataTable dt= sueldoDAL.CalcularSueldo(empleado);
            double total = 0;
            foreach (DataRow dr in dt.Rows)
            {
                total += Convert.ToDouble(dr[0]);
            }
            sueldoBLL.Total_sueldo= total;



            sueldoBLL.Id_empleadoS = empleado;

            return sueldoBLL;
        }


        #region CRUD
        private void btn_agregar_esp_Click(object sender, EventArgs e)
        {
            JornalBLL jornalBLL;
            jornalBLL = new JornalBLL();    
            int.TryParse(cb_insumo.SelectedValue.ToString(), out int empleado);
            
            sueldoDAL = new SueldoDAL();
            sueldoDAL.Agregar(ExtraerDatos());

            // aqui pongo en true al campo "pago" de la tabla Jornal
            
            DataTable dt = sueldoDAL.JornalesaPagar(empleado);
            foreach (DataRow dr in dt.Rows)
            {
                
                jornalBLL.Id_jornal= Convert.ToInt32(dr[0]);

                sueldoDAL.ModificarPago(jornalBLL);
            }

            LlenarDGVsueldo(empleado);
            LlenarDGVjornal(empleado);
        }


        #endregion


       

        #region DataGridView

        public void LlenarDGVsueldo(int id)
        {
            sueldoDAL = new SueldoDAL();
            try
            {
                dataGridView2.DataSource = sueldoDAL.LlenarWhere(id).Tables[0];
                dataGridView2.Columns[0].HeaderText = "Fecha";
                dataGridView2.Columns[1].HeaderText = "Total";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "no hay datos");
            }

        }

        public void LlenarDGVjornal(int id)
        {
            sueldoDAL = new SueldoDAL();
            try
            {
                dataGridView1.DataSource = sueldoDAL.LlenarJornal(id).Tables[0];
                dataGridView1.Columns[0].HeaderText = "Fecha";
                dataGridView1.Columns[1].HeaderText = "Entrada";
                dataGridView1.Columns[2].HeaderText = "Salida";
                dataGridView1.Columns[3].HeaderText = "Total";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "no hay datos");
            }

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

        private void cb_insumo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int.TryParse(cb_insumo.SelectedValue.ToString(), out int empleado);

            LlenarDGVjornal(empleado);
            LlenarDGVsueldo(empleado);
        }

        #endregion




    }
}
