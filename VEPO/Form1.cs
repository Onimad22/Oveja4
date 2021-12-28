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
        
        private void button2_Click(object sender, EventArgs e)
        {
            openchildrenform(new InsumoPL());
            Colores();
            button2.BackColor = Color.FromArgb(4, 21, 31);
            button2.ForeColor = Color.FromArgb(196, 73, 0);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime dtfecha =Fecha.Value;
            fecha = dtfecha.ToString("yyyy-MM-dd");
            openchildrenform(new CompraPL(fecha));
            Colores();
            button6.BackColor = Color.FromArgb(4, 21, 31);
            button6.ForeColor = Color.FromArgb(196, 73, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchildrenform(new InsumoPL());
            Colores();
            button4.BackColor = Color.FromArgb(4, 21, 31);
            button4.ForeColor = Color.FromArgb(196, 73, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openchildrenform(new InsumoPL());
            Colores();
            button5.BackColor = Color.FromArgb(4, 21, 31);
            button5.ForeColor = Color.FromArgb(196, 73, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openchildrenform(new ProductoPL());
            Colores();
            button7.BackColor = Color.FromArgb(4, 21, 31);
            button7.ForeColor = Color.FromArgb(196, 73, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openchildrenform(new InsumoPL());
            Colores();
            button1.BackColor = Color.FromArgb(4, 21, 31);
            button1.ForeColor = Color.FromArgb(196, 73, 0);
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
            button2.BackColor = Color.FromArgb(67, 37, 52);
            button4.BackColor = Color.FromArgb(67, 37, 52);
            button5.BackColor = Color.FromArgb(67, 37, 52);
            button6.BackColor = Color.FromArgb(67, 37, 52);
            button7.BackColor = Color.FromArgb(67, 37, 52);
            button1.BackColor = Color.FromArgb(67, 37, 52);

            button2.ForeColor = Color.FromArgb(255, 255, 255);
            button4.ForeColor = Color.FromArgb(255, 255, 255);
            button5.ForeColor = Color.FromArgb(255, 255, 255);
            button6.ForeColor = Color.FromArgb(255, 255, 255);
            button7.ForeColor = Color.FromArgb(255, 255, 255);
            button1.ForeColor = Color.FromArgb(255, 255, 255);

        }

       
    }
}

