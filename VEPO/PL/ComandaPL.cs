using System;
using System.Data;
using System.Windows.Forms;
using VEPO.BLL;
using VEPO.DAL;


namespace VEPO.PL
{
    public partial class ComandaPL : Form
    {
        ComandaBLL comandaBLL;
        ComandaDAL comandaDAL;

        string fecha;
        public ComandaPL(string Fecha)
        {
            InitializeComponent();
            //LlenarDGVcompra(Fecha);
            CargarCBO();
            fecha = Fecha;
            LlenarDGVabierta();
            LlenarDGVcerrada();
            cb_insumo.Focus();
        }

        public void LimpiarEntradas()
        {
            cb_insumo.Text = "";
            txt_cantidad.Text = "";
            lb_id_Item.Text = "0";
        }

        #region Datos

        private ComandaBLL ExtraerDatosComanda()
        {
            comandaBLL = new ComandaBLL();
            comandaBLL.Id_comanda = Convert.ToInt32(lb_id_comanda.Text);
            comandaBLL.Fecha_comanda = fecha;
            comandaBLL.Mesa_comanda = txt_mesa.Text;
            comandaBLL.Delivery_comanda = chb_peya.Checked;

            return comandaBLL;
        }

        private ItemBLL ExtraerDatosItem()
        {
            ItemBLL itemBLL = new ItemBLL();
            itemBLL.Id_item = Convert.ToInt32(lb_id_Item.Text);
            itemBLL.Id_comandaI = Convert.ToInt32(lb_id_comanda.Text);
            itemBLL.Cantidad_item = Convert.ToInt32(txt_cantidad.Text);

            int.TryParse(cb_insumo.SelectedValue.ToString(), out int producto);
            itemBLL.Id_productoI = producto;

            double precio = EncontrarPrecio();
            itemBLL.Total_item = precio * itemBLL.Cantidad_item;

            double bono = EncontrarBono();
            itemBLL.Bono_item = bono * itemBLL.Cantidad_item;

            return itemBLL;
        }

        private double EncontrarPrecio()
        {
            ComandaDAL comandaDAL = new ComandaDAL();
            int.TryParse(cb_insumo.SelectedValue.ToString(), out int producto);
            DataTable dtJ = comandaDAL.CalcularPrecio(producto);
            double precio = 0;
            foreach (DataRow dr in dtJ.Rows)
            {
                if (chb_peya.Checked == false)
                {
                    precio += Convert.ToDouble(dr[0]);
                }
                else
                    precio += Convert.ToDouble(dr[1]);
            }

            return precio;
        }

        private double EncontrarBono()
        {
            ComandaDAL comandaDAL = new ComandaDAL();

            int.TryParse(cb_insumo.SelectedValue.ToString(), out int producto);
            DataTable dtJ = comandaDAL.CalcularPrecio(producto);
            double bono = 0;
            foreach (DataRow dr in dtJ.Rows)
            {
                bono = Convert.ToDouble(dr[2]);
            }

            return bono;
        }

        #endregion

        #region CRUD
        private void btn_agregar_esp_Click(object sender, EventArgs e)
        {

            if (lb_id_comanda.Text == "0")
            {
                CrearComanda(fecha);

            }


            AgregarItem();
            LlenarDGVItem();
            LlenarDGVabierta();
            LlenarDGVcerrada();
            LimpiarEntradas();
            cb_insumo.Focus();
        }

        private void btn_modificar_esp_Click(object sender, EventArgs e)
        {
            ComandaDAL comandaDAL = new ComandaDAL();

            if (txt_cantidad.Text == "" || cb_insumo.Text == "")
            {
                MessageBox.Show("Ingresar Producto y Cantidad");
                return;
            }
            ItemDAL itemDAL = new ItemDAL();
            itemDAL.Modificar(ExtraerDatosItem());

            CalcularTotal();
            LlenarDGVItem();
            LlenarDGVabierta();
            LlenarDGVcerrada();
            LimpiarEntradas();
            cb_insumo.Focus();
        }

        private void btn_borrar_esp_Click(object sender, EventArgs e)
        {
            ComandaDAL comandaDAL = new ComandaDAL();

            if (txt_cantidad.Text == "" || cb_insumo.Text == "")
            {
                MessageBox.Show("Ingresar Producto y Cantidad");
                return;
            }
            ItemDAL itemDAL = new ItemDAL();
            itemDAL.Eliminar(ExtraerDatosItem());

            CalcularTotal();
            LlenarDGVItem();
            LlenarDGVabierta();
            LlenarDGVcerrada();
            LimpiarEntradas();
            cb_insumo.Focus();
        }

        private void CrearComanda(string fechaC)
        {

            if (txt_mesa.Text == "")
            {
                MessageBox.Show("Ingresar una Mesa");
                return;
            }
            comandaDAL = new ComandaDAL();
            comandaDAL.Agregar(ExtraerDatosComanda());

            DataTable dt = comandaDAL.UltimoId();
            foreach (DataRow dr in dt.Rows)
            {

                lb_id_comanda.Text = Convert.ToString(dr[0]);
            }
        }

        private void AgregarItem()
        {
            ComandaDAL comandaDAL = new ComandaDAL();

            if (lb_id_comanda.Text == "0")
            {
                return;
            }

            if (txt_cantidad.Text == "" || cb_insumo.Text == "")
            {
                MessageBox.Show("Ingresar Producto y Cantidad");
                return;
            }
            ItemDAL itemDAL = new ItemDAL();
            itemDAL.Agregar(ExtraerDatosItem());



            CalcularTotal();


        }

        private void CalcularTotal()
        {
            ItemDAL itemDAL = new ItemDAL();
            ComandaBLL comandaBLL = new ComandaBLL();
            ComandaDAL comandaDAL = new ComandaDAL();

            string id = lb_id_comanda.Text;

            DataTable dtI = itemDAL.LlenarDGVtotal(id);
            double total = 0;
            foreach (DataRow dri in dtI.Rows)
            {
                total += Convert.ToDouble(dri[0]);
            }
            comandaBLL.Total_comanda = total;
            comandaBLL.Id_comanda = Convert.ToInt32(id);
            comandaDAL.ModificarTotal(comandaBLL);
            txt_total.Text = Convert.ToString(total);
        }


        #endregion

        #region DataGridView

        public void LlenarDGVItem()
        {
            string id = lb_id_comanda.Text;
            ItemDAL itemDAL = new ItemDAL();
            try
            {
                dataGridView1.DataSource = itemDAL.LlenarDGV(id).Tables[0];
                dataGridView1.Columns[0].HeaderText = "Nombre";
                dataGridView1.Columns[1].HeaderText = "Cantidad";
                dataGridView1.Columns[2].HeaderText = "Subtotal";
                dataGridView1.Columns[3].HeaderText = "IdItem";
                dataGridView1.Columns[3].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "no hay datos");
            }
        }
        public void LlenarDGVabierta()
        {
            string id = lb_id_comanda.Text;
            ComandaDAL comanda = new ComandaDAL();
            try
            {
                dataGridView2.DataSource = comanda.LlenarDGVa(fecha).Tables[0];
                dataGridView2.Columns[0].HeaderText = "idComanda";
                dataGridView2.Columns[1].HeaderText = "Mesa";
                dataGridView2.Columns[2].HeaderText = "Pago";
                dataGridView2.Columns[3].HeaderText = "cerrar";
                dataGridView2.Columns[4].HeaderText = "delivery";
                dataGridView2.Columns[5].HeaderText = "Total";
                dataGridView2.Columns[6].HeaderText = "fecha";

                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                dataGridView2.Columns[6].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "no hay datos");
            }

        }

        public void LlenarDGVcerrada()
        {
            string id = lb_id_comanda.Text;
            ComandaDAL comanda = new ComandaDAL();
            try
            {
                dataGridView3.DataSource = comanda.LlenarDGVc(fecha).Tables[0];
                dataGridView3.Columns[0].HeaderText = "idComanda";
                dataGridView3.Columns[1].HeaderText = "Mesa";
                dataGridView3.Columns[2].HeaderText = "Pago";
                dataGridView3.Columns[3].HeaderText = "cerrar";
                dataGridView3.Columns[4].HeaderText = "delivery";
                dataGridView3.Columns[5].HeaderText = "Total";
                dataGridView3.Columns[6].HeaderText = "fecha";

                dataGridView3.Columns[0].Visible = false;
                dataGridView3.Columns[3].Visible = false;
                dataGridView3.Columns[6].Visible = false;
                dataGridView2.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "no hay datos");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            lb_id_Item.Text = row.Cells[3].Value.ToString();
            cb_insumo.Text = row.Cells[0].Value.ToString();
            txt_cantidad.Text = row.Cells[1].Value.ToString();


        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            lb_id_comanda.Text = row.Cells[0].Value.ToString();
            txt_total.Text = row.Cells[5].Value.ToString();
            txt_mesa.Text = row.Cells[1].Value.ToString();
            checkBox1.Checked = Convert.ToBoolean(row.Cells[3].Value);
            checkBox2.Checked = Convert.ToBoolean(row.Cells[2].Value);
            chb_peya.Checked = Convert.ToBoolean(row.Cells[4].Value);


            LlenarDGVItem();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            lb_id_comanda.Text = row.Cells[0].Value.ToString();
            txt_mesa.Text = row.Cells[1].Value.ToString();
            txt_total.Text = row.Cells[5].Value.ToString();
            chb_peya.Checked = Convert.ToBoolean(row.Cells[4].Value);
            checkBox1.Checked = Convert.ToBoolean(row.Cells[3].Value);
            checkBox2.Checked = Convert.ToBoolean(row.Cells[2].Value);



            LlenarDGVItem();
        }

        #endregion

        #region ComboBOX

        private void CargarCBO()
        {
            //CARGO EL CBO DE CLIENTE
            ProductoDAL productoDAL = new ProductoDAL();
            cb_insumo.DataSource = productoDAL.LlenarDGV().Tables[0];
            cb_insumo.DisplayMember = "Nombre_producto";//va a mostrar el valor de ese campo pero
            cb_insumo.ValueMember = "Id_producto";// el valor de ese campo en el CB sera este
            cb_insumo.SelectedItem = null;

            DataTable dt=productoDAL.LlenarCBO();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                collection.Add(Convert.ToString(row[0]));
            }


            //CARGO LA LISTA PARA EL AUTOCOMPLEATADO
            cb_insumo.AutoCompleteMode=AutoCompleteMode.Suggest;
            cb_insumo.AutoCompleteSource=AutoCompleteSource.CustomSource;
            cb_insumo.AutoCompleteCustomSource= collection;
        }

        #endregion

        #region CheckBox

        private void checkBox2_Click(object sender, EventArgs e)
        {
            ComandaBLL comandaBLL = new ComandaBLL();
            ComandaDAL comandaDAL = new ComandaDAL();

            comandaBLL.Id_comanda = Convert.ToInt32(lb_id_comanda.Text);
            comandaBLL.Pago_comanda = checkBox2.Checked;
            comandaDAL.ModificarPago(comandaBLL);
            LlenarDGVabierta();
            LlenarDGVcerrada();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            ComandaBLL comandaBLL = new ComandaBLL();
            ComandaDAL comandaDAL = new ComandaDAL();

            comandaBLL.Id_comanda = Convert.ToInt32(lb_id_comanda.Text);
            comandaBLL.Cerrar_comanda = checkBox1.Checked;
            comandaDAL.ModificarCerrar(comandaBLL);
            LlenarDGVabierta();
            LlenarDGVcerrada();
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
            lb_id_comanda.Text = "0";
            txt_mesa.Text = "";
            chb_peya.Checked = false;
            txt_total.Text = "0";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            LlenarDGVItem();
            txt_mesa.Focus();
        }




    }
}
