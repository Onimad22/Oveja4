using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VEPO.BLL;
using VEPO.DAL;
using VEPO.PL;

namespace VEPO
{
    public partial class Form1 : Form
    {

        string fecha;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void btn_comanda_Click(object sender, EventArgs e)
        {
            DateTime dtfecha = Fecha.Value;
            fecha = dtfecha.ToString("yyyy-MM-dd");

            openchildrenform(new ComandaPL(fecha));
            Colores();
            btn_comanda.BackColor = Color.FromArgb(4, 21, 31);
            btn_comanda.ForeColor = Color.FromArgb(196, 73, 0);

        }


        private void btn_compra_Click(object sender, EventArgs e)
        {
            DateTime dtfecha = Fecha.Value;
            fecha = dtfecha.ToString("yyyy-MM-dd");
            openchildrenform(new CompraPL(fecha));
            Colores();
            btn_compra.BackColor = Color.FromArgb(4, 21, 31);
            btn_compra.ForeColor = Color.FromArgb(196, 73, 0);
        }

        private void btn_jornal_Click(object sender, EventArgs e)
        {
            DateTime dtfecha = Fecha.Value;
            fecha = dtfecha.ToString("yyyy-MM-dd");

            openchildrenform(new JornalPL(fecha));
            Colores();
            btn_jornal.BackColor = Color.FromArgb(4, 21, 31);
            btn_jornal.ForeColor = Color.FromArgb(196, 73, 0);
        }

        private void btn_sueldo_Click(object sender, EventArgs e)
        {
            DateTime dtfecha = Fecha.Value;
            fecha = dtfecha.ToString("yyyy-MM-dd");
            openchildrenform(new SueldoPL(fecha));
            Colores();
            btn_sueldo.BackColor = Color.FromArgb(4, 21, 31);
            btn_sueldo.ForeColor = Color.FromArgb(196, 73, 0);
        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            DateTime dtfecha = Fecha.Value;
            fecha = dtfecha.ToString("yyyy-MM-dd");
            openchildrenform(new CierrePL(fecha));
            Colores();
            btn_cierre.BackColor = Color.FromArgb(4, 21, 31);
            btn_cierre.ForeColor = Color.FromArgb(196, 73, 0);
        }

        private void btn_insumo_Click(object sender, EventArgs e)
        {
            openchildrenform(new InsumoPL());
            Colores();
            btn_insumo.BackColor = Color.FromArgb(4, 21, 31);
            btn_insumo.ForeColor = Color.FromArgb(196, 73, 0);
        }


        private void btn_producto_Click(object sender, EventArgs e)
        {
            openchildrenform(new ProductoPL());
            Colores();
            btn_producto.BackColor = Color.FromArgb(4, 21, 31);
            btn_producto.ForeColor = Color.FromArgb(196, 73, 0);
        }

        private void btn_receta_Click(object sender, EventArgs e)
        {
            openchildrenform(new InsumoPL());
            Colores();
            btn_receta.BackColor = Color.FromArgb(4, 21, 31);
            btn_receta.ForeColor = Color.FromArgb(196, 73, 0);
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            DateTime dtfecha = Fecha.Value;
            fecha = dtfecha.ToString("yyyy-MM-dd");
            openchildrenform(new EmpleadoPL());
            Colores();
            btn_personal.BackColor = Color.FromArgb(4, 21, 31);
            btn_personal.ForeColor = Color.FromArgb(196, 73, 0);
        }





        private Form activeform = null;
        private void openchildrenform(Form childrenform)
        {
            if (activeform != null)
                    activeform.Close();

             activeform = childrenform;
             childrenform.TopLevel = false;
             childrenform.FormBorderStyle = FormBorderStyle.None;
             panel2.Controls.Add(childrenform);
             panel2.Tag = childrenform;
             childrenform.BringToFront();
             childrenform.Dock = DockStyle.Fill;
             childrenform.Show();
            
        }

        private void Colores()
        {
            btn_comanda.BackColor = Color.FromArgb(67, 37, 52);
            btn_compra.BackColor = Color.FromArgb(67, 37, 52);
            btn_jornal.BackColor = Color.FromArgb(67, 37, 52);
            btn_sueldo.BackColor = Color.FromArgb(67, 37, 52);
            btn_cierre.BackColor = Color.FromArgb(67, 37, 52);
            btn_insumo.BackColor = Color.FromArgb(67, 37, 52);
            btn_producto.BackColor = Color.FromArgb(67, 37, 52);
            btn_receta.BackColor = Color.FromArgb(67, 37, 52);
            btn_personal.BackColor = Color.FromArgb(67, 37, 52);

            btn_comanda.ForeColor = Color.FromArgb(255, 255, 255);
            btn_compra.ForeColor = Color.FromArgb(255, 255, 255);
            btn_jornal.ForeColor = Color.FromArgb(255, 255, 255);
            btn_sueldo.ForeColor = Color.FromArgb(255, 255, 255);
            btn_cierre.ForeColor = Color.FromArgb(255, 255, 255);
            btn_insumo.ForeColor = Color.FromArgb(255, 255, 255);
            btn_producto.ForeColor = Color.FromArgb(255, 255, 255);
            btn_receta.ForeColor = Color.FromArgb(255, 255, 255);
            btn_personal.ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            if (txtClave.Text == "1793")
            {
                txtClave.Text = "";
            }
            else
            {
                Fecha.Value = DateTime.Today;
            }
        }
    }
}

