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
    public partial class CierrePL : Form
    {
        TransferenciaBLL transferenciaBLL;
        TransferenciaDAL transferenciaDAL;

        string fecha;
        DateTime fechaAyerD;
        string fechaAyer;
        public CierrePL(string Fecha)
        {
            InitializeComponent();
            LlenarDGVcompra(Fecha);
            fecha = Fecha;
            fechaAyerD = Convert.ToDateTime(Fecha).AddDays(-1);
            //fechaAyerD=fechaAyerD.AddDays(-1);
            fechaAyer=fechaAyerD.ToString("yyyy-MM-dd");
            Totales();
            LlenarDGVcajaAyer(fechaAyer);
            LlenarDGVcajaHoy(fecha);
        }

        private void LlenarDGVcajaHoy(string fecha)
        {
            CajaDAL cajaDAL = new CajaDAL();
            DataTable dt = cajaDAL.CajaDT(fecha);

            foreach (DataRow dr in dt.Rows)
            {
                lb_id_caja.Text= Convert.ToString(dr[0]);
                txt_10c.Text = Convert.ToString(dr[1]);
                txt_20c.Text = Convert.ToString(dr[2]);
                txt_50c.Text = Convert.ToString(dr[3]);
                txt_1b.Text = Convert.ToString(dr[4]);
                txt_2b.Text = Convert.ToString(dr[5]);
                txt_5b.Text = Convert.ToString(dr[6]);
                txt_10b.Text = Convert.ToString(dr[7]);
                txt_20b.Text = Convert.ToString(dr[8]);
                txt_50b.Text = Convert.ToString(dr[9]);
                txt_100b.Text = Convert.ToString(dr[10]);
                txt_200b.Text = Convert.ToString(dr[11]);
                txt_total_caja.Text = Convert.ToString(dr[12]);



            }
        }

        public void LimpiarEntradas()
        {
            txt_valor_trans.Text = "";
            lb_id_transferencia.Text = "0";
        }

        private TransferenciaBLL ExtraerDatosTransferencia()
        {
            transferenciaBLL = new TransferenciaBLL();
            transferenciaBLL.Id_transferencia = Convert.ToInt32(lb_id_transferencia.Text);
            transferenciaBLL.Fecha_transferencia = fecha;
            transferenciaBLL.Total_transferencia = Convert.ToDouble(txt_valor_trans.Text);


            return transferenciaBLL;
        }

        private CajaBLL ExtraerDatosCaja()
        {
            CajaBLL cajaBLL = new CajaBLL();
            cajaBLL.ID_caja = Convert.ToInt32(lb_id_caja.Text);
            cajaBLL.Fecha_caja = fecha;
            if (txt_10c.Text==string.Empty)
            {
                txt_10c.Text = "0";
            }
            cajaBLL.DiezC_caja = Convert.ToInt32(txt_10c.Text);
            if (txt_20c.Text == string.Empty)
            {
                txt_20c.Text = "0";
            }
            cajaBLL.VeinteC_caja = Convert.ToInt32(txt_20c.Text);
            if (txt_50c.Text == string.Empty)
            {
                txt_50c.Text = "0";
            }
            cajaBLL.CincuentaC_caja = Convert.ToInt32(txt_50c.Text);
            if (txt_1b.Text == string.Empty)
            {
                txt_1b.Text = "0";
            }
            cajaBLL.UnB_caja = Convert.ToInt32(txt_1b.Text);
            if (txt_2b.Text == string.Empty)
            {
                txt_2b.Text = "0";
            }
            cajaBLL.DosB_caja = Convert.ToInt32(txt_2b.Text);
            if (txt_5b.Text == string.Empty)
            {
                txt_5b.Text = "0";
            }
            cajaBLL.CincoB_caja = Convert.ToInt32(txt_5b.Text);
            if (txt_10b.Text == string.Empty)
            {
                txt_10b.Text = "0";
            }
            cajaBLL.DiezB_caja = Convert.ToInt32(txt_10b.Text);
            if (txt_20b.Text == string.Empty)
            {
                txt_20b.Text = "0";
            }
            cajaBLL.VeinteB_caja = Convert.ToInt32(txt_20b.Text);
            if (txt_50b.Text == string.Empty)
            {
                txt_50b.Text = "0";
            }
            cajaBLL.CincuentaB_caja = Convert.ToInt32(txt_50b.Text);
            if (txt_100b.Text == string.Empty)
            {
                txt_100b.Text = "0";
            }
            cajaBLL.CienB_caja = Convert.ToInt32(txt_100b.Text);
            if (txt_200b.Text == string.Empty)
            {
                txt_200b.Text = "0";
            }
            cajaBLL.DoscientosB_caja = Convert.ToInt32(txt_200b.Text);

            cajaBLL.Total_caja = cajaBLL.DiezC_caja*0.10 + cajaBLL.VeinteC_caja*0.2 + cajaBLL.CincuentaC_caja*0.5 + cajaBLL.UnB_caja*1 + cajaBLL.DosB_caja*2 + cajaBLL.CincoB_caja*5 + cajaBLL.DiezB_caja*10 + cajaBLL.VeinteB_caja*20 + cajaBLL.CincuentaB_caja*50 + cajaBLL.CienB_caja*100 + cajaBLL.DoscientosB_caja*200;

            return cajaBLL;
        }


        #region CRUD
        private void btn_agregar_esp_Click(object sender, EventArgs e)
        {
            transferenciaDAL = new TransferenciaDAL();
            transferenciaDAL.Agregar(ExtraerDatosTransferencia());
            LlenarDGVcompra(fecha);
        }

        private void btn_modificar_esp_Click(object sender, EventArgs e)
        {
            transferenciaDAL = new TransferenciaDAL();
            transferenciaDAL.Modificar(ExtraerDatosTransferencia());
            LlenarDGVcompra(fecha);
        }

        private void btn_borrar_esp_Click(object sender, EventArgs e)
        {
            transferenciaDAL = new TransferenciaDAL();
            transferenciaDAL.Eliminar(ExtraerDatosTransferencia());
            LlenarDGVcompra(fecha);
        }
        #endregion
       
        #region DataGridView

        public void LlenarDGVcompra(string fecha)
        {
            transferenciaDAL = new TransferenciaDAL();
            try
            {
                dataGridView1.DataSource = transferenciaDAL.LlenarWhereFecha(fecha).Tables[0];
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Total";
                dataGridView1.Columns[2].HeaderText = "fecha";
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "no hay datos");
            }

            LimpiarEntradas();
        }

        public void LlenarDGVcajaAyer(string fecha)
        {
            CajaDAL cajaDAL = new CajaDAL();
            try
            {
                dataGridView2.DataSource = cajaDAL.LlenarWhereFecha(fecha).Tables[0];
                dataGridView2.Columns[0].HeaderText = "ID";
                dataGridView2.Columns[1].HeaderText = "0,10";
                dataGridView2.Columns[2].HeaderText = "0,20";
                dataGridView2.Columns[3].HeaderText = "0,50";
                dataGridView2.Columns[4].HeaderText = "1";
                dataGridView2.Columns[5].HeaderText = "2";
                dataGridView2.Columns[6].HeaderText = "5";
                dataGridView2.Columns[7].HeaderText = "10";
                dataGridView2.Columns[8].HeaderText = "20";
                dataGridView2.Columns[9].HeaderText = "50";
                dataGridView2.Columns[10].HeaderText = "100";
                dataGridView2.Columns[11].HeaderText = "200";
                dataGridView2.Columns[12].HeaderText = "Total";


                dataGridView2.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "no hay datos");
            }

            LimpiarEntradas();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            lb_id_transferencia.Text = row.Cells[0].Value.ToString();
            txt_valor_trans.Text = row.Cells[1].Value.ToString();
        }

        #endregion

        #region Totales

        public void Totales()
        {
            JornalDAL jornalDAL = new JornalDAL();
            DataTable dtB = jornalDAL.CalcularBono(fecha);
            double totalB = 0;
            foreach (DataRow dr in dtB.Rows)
            {
                totalB += Convert.ToDouble(dr[0]);
            }
            txt_bono.Text = Convert.ToString(totalB);

            ItemDAL itemDAL = new ItemDAL();
            DataTable dtV = itemDAL.CalcularTotal(fecha);
            double totalV = 0;
            foreach (DataRow dr in dtV.Rows)
            {
                totalV += Convert.ToDouble(dr[0]);
            }
            txt_venta.Text = Convert.ToString(totalV);

            CompraDAL compraDAL = new CompraDAL();
            DataTable dtC = compraDAL.CalcularTotal(fecha);
            double totalC = 0;
            foreach (DataRow dr in dtC.Rows)
            {
                totalC += Convert.ToDouble(dr[0]);
            }
            txt_compra.Text = Convert.ToString(totalC);

            SueldoDAL sueldoDAL = new SueldoDAL();
            DataTable dtS = sueldoDAL.CalcularTotal(fecha);
            double totalS = 0;
            foreach (DataRow dr in dtS.Rows)
            {
                totalS += Convert.ToDouble(dr[0]);
            }
            txt_sueldo.Text = Convert.ToString(totalS);

            TransferenciaDAL transferenciaDAL = new TransferenciaDAL();
            DataTable dtT = transferenciaDAL.CalcularTotal(fecha);
            double totalT = 0;
            foreach (DataRow dr in dtT.Rows)
            {
                totalT += Convert.ToDouble(dr[0]);
            }
            txt_transferencia.Text = Convert.ToString(totalT);

            CajaDAL cajaDAL = new CajaDAL();
            DataTable dtCA = cajaDAL.CalcularTotal(fechaAyer);
            double totalCA = 0;
            foreach (DataRow dr in dtCA.Rows)
            {
                totalCA += Convert.ToDouble(dr[0]);
            }

            
            DataTable dtCH = cajaDAL.CalcularTotal(fecha);
            double totalCH = 0;
            foreach (DataRow dr in dtCH.Rows)
            {
                totalCH += Convert.ToDouble(dr[0]);
            }

            double cierre = totalCH - totalCA + totalV - totalC + totalT;

            txt_cierre.Text = Convert.ToString(cierre);

        }

        #endregion

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //VERIFICAR SI HAY UNA CAJA CARGADA EN ESE DIA

            if (lb_id_caja.Text=="0")
            {
                NuevaCaja();
            }
            else
            {
                ModificarCaja();
            }

            LlenarDGVcajaHoy(fecha);
            //Totales
            Totales();
        }


        public void NuevaCaja()
        {
            CajaDAL cajaDAL = new CajaDAL();
            cajaDAL.Agregar(ExtraerDatosCaja());
            LlenarDGVcompra(fecha);
        }

        public void ModificarCaja()
        {
            CajaDAL cajaDAL = new CajaDAL();
            cajaDAL.Modificar(ExtraerDatosCaja());
            LlenarDGVcompra(fecha);
        }

       
    }
}
