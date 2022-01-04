
namespace VEPO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.p_lateral = new System.Windows.Forms.Panel();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_receta = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_insumo = new System.Windows.Forms.Button();
            this.btn_cierre = new System.Windows.Forms.Button();
            this.btn_sueldo = new System.Windows.Forms.Button();
            this.btn_jornal = new System.Windows.Forms.Button();
            this.btn_compra = new System.Windows.Forms.Button();
            this.btn_comanda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.p_lateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p_lateral
            // 
            this.p_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.p_lateral.Controls.Add(this.Fecha);
            this.p_lateral.Controls.Add(this.btn_personal);
            this.p_lateral.Controls.Add(this.btn_receta);
            this.p_lateral.Controls.Add(this.btn_producto);
            this.p_lateral.Controls.Add(this.btn_insumo);
            this.p_lateral.Controls.Add(this.btn_cierre);
            this.p_lateral.Controls.Add(this.btn_sueldo);
            this.p_lateral.Controls.Add(this.btn_jornal);
            this.p_lateral.Controls.Add(this.btn_compra);
            this.p_lateral.Controls.Add(this.btn_comanda);
            this.p_lateral.Controls.Add(this.panel1);
            this.p_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_lateral.Location = new System.Drawing.Point(0, 0);
            this.p_lateral.Name = "p_lateral";
            this.p_lateral.Size = new System.Drawing.Size(234, 749);
            this.p_lateral.TabIndex = 6;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(0, 145);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(234, 23);
            this.Fecha.TabIndex = 0;
            this.Fecha.TabStop = false;
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            // 
            // btn_personal
            // 
            this.btn_personal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_personal.FlatAppearance.BorderSize = 0;
            this.btn_personal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_personal.ForeColor = System.Drawing.Color.White;
            this.btn_personal.Location = new System.Drawing.Point(0, 696);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_personal.Size = new System.Drawing.Size(234, 66);
            this.btn_personal.TabIndex = 12;
            this.btn_personal.TabStop = false;
            this.btn_personal.Text = "Personal";
            this.btn_personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personal.UseVisualStyleBackColor = true;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // btn_receta
            // 
            this.btn_receta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_receta.FlatAppearance.BorderSize = 0;
            this.btn_receta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_receta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receta.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_receta.ForeColor = System.Drawing.Color.White;
            this.btn_receta.Location = new System.Drawing.Point(0, 630);
            this.btn_receta.Name = "btn_receta";
            this.btn_receta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_receta.Size = new System.Drawing.Size(234, 66);
            this.btn_receta.TabIndex = 11;
            this.btn_receta.TabStop = false;
            this.btn_receta.Text = "Receta";
            this.btn_receta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_receta.UseVisualStyleBackColor = true;
            this.btn_receta.Click += new System.EventHandler(this.btn_receta_Click);
            // 
            // btn_producto
            // 
            this.btn_producto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_producto.FlatAppearance.BorderSize = 0;
            this.btn_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_producto.ForeColor = System.Drawing.Color.White;
            this.btn_producto.Location = new System.Drawing.Point(0, 564);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_producto.Size = new System.Drawing.Size(234, 66);
            this.btn_producto.TabIndex = 10;
            this.btn_producto.TabStop = false;
            this.btn_producto.Text = "Producto";
            this.btn_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // btn_insumo
            // 
            this.btn_insumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_insumo.FlatAppearance.BorderSize = 0;
            this.btn_insumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_insumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insumo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_insumo.ForeColor = System.Drawing.Color.White;
            this.btn_insumo.Location = new System.Drawing.Point(0, 504);
            this.btn_insumo.Name = "btn_insumo";
            this.btn_insumo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_insumo.Size = new System.Drawing.Size(234, 60);
            this.btn_insumo.TabIndex = 9;
            this.btn_insumo.TabStop = false;
            this.btn_insumo.Text = "Insumo";
            this.btn_insumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insumo.UseVisualStyleBackColor = true;
            this.btn_insumo.Click += new System.EventHandler(this.btn_insumo_Click);
            // 
            // btn_cierre
            // 
            this.btn_cierre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cierre.FlatAppearance.BorderSize = 0;
            this.btn_cierre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_cierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cierre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cierre.ForeColor = System.Drawing.Color.White;
            this.btn_cierre.Location = new System.Drawing.Point(0, 435);
            this.btn_cierre.Name = "btn_cierre";
            this.btn_cierre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_cierre.Size = new System.Drawing.Size(234, 69);
            this.btn_cierre.TabIndex = 8;
            this.btn_cierre.TabStop = false;
            this.btn_cierre.Text = "Cierre";
            this.btn_cierre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cierre.UseVisualStyleBackColor = true;
            this.btn_cierre.Click += new System.EventHandler(this.btn_cierre_Click);
            // 
            // btn_sueldo
            // 
            this.btn_sueldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sueldo.FlatAppearance.BorderSize = 0;
            this.btn_sueldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_sueldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sueldo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sueldo.ForeColor = System.Drawing.Color.White;
            this.btn_sueldo.Location = new System.Drawing.Point(0, 369);
            this.btn_sueldo.Name = "btn_sueldo";
            this.btn_sueldo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_sueldo.Size = new System.Drawing.Size(234, 66);
            this.btn_sueldo.TabIndex = 7;
            this.btn_sueldo.TabStop = false;
            this.btn_sueldo.Text = "Sueldo";
            this.btn_sueldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sueldo.UseVisualStyleBackColor = true;
            this.btn_sueldo.Click += new System.EventHandler(this.btn_sueldo_Click);
            // 
            // btn_jornal
            // 
            this.btn_jornal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_jornal.FlatAppearance.BorderSize = 0;
            this.btn_jornal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_jornal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jornal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_jornal.ForeColor = System.Drawing.Color.White;
            this.btn_jornal.Location = new System.Drawing.Point(0, 300);
            this.btn_jornal.Name = "btn_jornal";
            this.btn_jornal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_jornal.Size = new System.Drawing.Size(234, 69);
            this.btn_jornal.TabIndex = 6;
            this.btn_jornal.TabStop = false;
            this.btn_jornal.Text = "Jornal";
            this.btn_jornal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_jornal.UseVisualStyleBackColor = true;
            this.btn_jornal.Click += new System.EventHandler(this.btn_jornal_Click);
            // 
            // btn_compra
            // 
            this.btn_compra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_compra.FlatAppearance.BorderSize = 0;
            this.btn_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compra.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_compra.ForeColor = System.Drawing.Color.White;
            this.btn_compra.Location = new System.Drawing.Point(0, 236);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_compra.Size = new System.Drawing.Size(234, 64);
            this.btn_compra.TabIndex = 5;
            this.btn_compra.TabStop = false;
            this.btn_compra.Text = "Compra";
            this.btn_compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_compra.UseVisualStyleBackColor = true;
            this.btn_compra.Click += new System.EventHandler(this.btn_compra_Click);
            // 
            // btn_comanda
            // 
            this.btn_comanda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_comanda.FlatAppearance.BorderSize = 0;
            this.btn_comanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_comanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comanda.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_comanda.ForeColor = System.Drawing.Color.White;
            this.btn_comanda.Location = new System.Drawing.Point(0, 168);
            this.btn_comanda.Name = "btn_comanda";
            this.btn_comanda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_comanda.Size = new System.Drawing.Size(234, 68);
            this.btn_comanda.TabIndex = 3;
            this.btn_comanda.TabStop = false;
            this.btn_comanda.Text = "Comanda";
            this.btn_comanda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_comanda.UseVisualStyleBackColor = true;
            this.btn_comanda.Click += new System.EventHandler(this.btn_comanda_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 168);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VEPO.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 749);
            this.panel2.TabIndex = 7;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtClave.Location = new System.Drawing.Point(3, 0);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(78, 23);
            this.txtClave.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.p_lateral);
            this.Name = "Form1";
            this.Text = "El Mana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.p_lateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_lateral;
        private System.Windows.Forms.Button btn_cierre;
        private System.Windows.Forms.Button btn_sueldo;
        private System.Windows.Forms.Button btn_jornal;
        private System.Windows.Forms.Button btn_compra;
        private System.Windows.Forms.Button btn_comanda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_insumo;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_receta;
        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.TextBox txtClave;
    }
}

