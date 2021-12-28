﻿using System;
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
    public partial class CompraPL : Form
    {
        CompraBLL compraBLL;
        CompraDAL compraDAL;

        string fecha;
        public CompraPL(string Fecha)
        {
            InitializeComponent();
            LlenarDGVcompra();
            CargarCBO();
            fecha = Fecha;
        }

        public void LimpiarEntradasEspecie()
        {
            cb_insumo.Text = "";
            txt_categoria.Text = "";
            lb_id_compra.Text = "0";
        }

        private CompraBLL ExtraerDatos()
        {
            compraBLL = new CompraBLL();
            compraBLL.Id_compra = Convert.ToInt32(lb_id_compra.Text);
            compraBLL.Fecha_compra = fecha;
            compraBLL.Total_compra = Convert.ToDouble(txt_categoria.Text);

            int.TryParse(cb_insumo.SelectedValue.ToString(), out int insumo);
            compraBLL.Id_insumoC = insumo;

            return compraBLL;
        }


        #region CRUD
        private void btn_agregar_esp_Click(object sender, EventArgs e)
        {
            compraDAL = new CompraDAL();
            compraDAL.Agregar(ExtraerDatos());
            LlenarDGVcompra();
        }

        private void btn_modificar_esp_Click(object sender, EventArgs e)
        {
            compraDAL = new CompraDAL();
            compraDAL.Modificar(ExtraerDatos());
            LlenarDGVcompra();
        }

        private void btn_borrar_esp_Click(object sender, EventArgs e)
        {
            compraDAL = new CompraDAL();
            compraDAL.Eliminar(ExtraerDatos());
            LlenarDGVcompra();
        }
        #endregion


       

        #region DataGridView

        public void LlenarDGVcompra()
        {
            compraDAL = new CompraDAL();
            try
            {
                dataGridView1.DataSource = compraDAL.LlenarWhereFecha(fecha).Tables[0];
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Nombre";
                dataGridView1.Columns[2].HeaderText = "Categoria";
                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "no hay datos");
            }
           
           

            LimpiarEntradasEspecie();
            cb_insumo.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            lb_id_compra.Text = row.Cells[0].Value.ToString();
            cb_insumo.Text = row.Cells[1].Value.ToString();
            txt_categoria.Text = row.Cells[2].Value.ToString();
        }

        #endregion

        #region ComboBOX

        private void CargarCBO()
        {
            //CARGO EL CBO DE CLIENTE
            InsumoDAL insumoDAL = new InsumoDAL();
            cb_insumo.DataSource = insumoDAL.LlenarDGV().Tables[0];
            cb_insumo.DisplayMember = "Nombre_insumo";//va a mostrar el valor de ese campo pero
            cb_insumo.ValueMember = "Id_insumo";// el valor de ese campo en el CB sera este
            cb_insumo.SelectedItem = null;

        }

        #endregion

    }
}
