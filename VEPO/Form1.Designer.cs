
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
            this.btn_insumo = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_cierre = new System.Windows.Forms.Button();
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_compra = new System.Windows.Forms.Button();
            this.btn_comanda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p_lateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p_lateral
            // 
            this.p_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.p_lateral.Controls.Add(this.btn_insumo);
            this.p_lateral.Controls.Add(this.btn_producto);
            this.p_lateral.Controls.Add(this.btn_cierre);
            this.p_lateral.Controls.Add(this.btn_personal);
            this.p_lateral.Controls.Add(this.btn_compra);
            this.p_lateral.Controls.Add(this.btn_comanda);
            this.p_lateral.Controls.Add(this.panel1);
            this.p_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_lateral.Location = new System.Drawing.Point(0, 0);
            this.p_lateral.Name = "p_lateral";
            this.p_lateral.Size = new System.Drawing.Size(250, 852);
            this.p_lateral.TabIndex = 6;
            // 
            // btn_insumo
            // 
            this.btn_insumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_insumo.FlatAppearance.BorderSize = 0;
            this.btn_insumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_insumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insumo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_insumo.ForeColor = System.Drawing.Color.White;
            this.btn_insumo.Location = new System.Drawing.Point(0, 600);
            this.btn_insumo.Name = "btn_insumo";
            this.btn_insumo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_insumo.Size = new System.Drawing.Size(250, 90);
            this.btn_insumo.TabIndex = 9;
            this.btn_insumo.Text = "Insumos";
            this.btn_insumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insumo.UseVisualStyleBackColor = true;
            this.btn_insumo.Click += new System.EventHandler(this.btn_insumo_Click);
            // 
            // btn_producto
            // 
            this.btn_producto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_producto.FlatAppearance.BorderSize = 0;
            this.btn_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_producto.ForeColor = System.Drawing.Color.White;
            this.btn_producto.Location = new System.Drawing.Point(0, 510);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_producto.Size = new System.Drawing.Size(250, 90);
            this.btn_producto.TabIndex = 8;
            this.btn_producto.Text = "Productos";
            this.btn_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // btn_cierre
            // 
            this.btn_cierre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cierre.FlatAppearance.BorderSize = 0;
            this.btn_cierre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_cierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cierre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cierre.ForeColor = System.Drawing.Color.White;
            this.btn_cierre.Location = new System.Drawing.Point(0, 420);
            this.btn_cierre.Name = "btn_cierre";
            this.btn_cierre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_cierre.Size = new System.Drawing.Size(250, 90);
            this.btn_cierre.TabIndex = 7;
            this.btn_cierre.Text = "Cierre";
            this.btn_cierre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cierre.UseVisualStyleBackColor = true;
            this.btn_cierre.Click += new System.EventHandler(this.btn_cierre_Click);
            // 
            // btn_personal
            // 
            this.btn_personal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_personal.FlatAppearance.BorderSize = 0;
            this.btn_personal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_personal.ForeColor = System.Drawing.Color.White;
            this.btn_personal.Location = new System.Drawing.Point(0, 330);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_personal.Size = new System.Drawing.Size(250, 90);
            this.btn_personal.TabIndex = 6;
            this.btn_personal.Text = "Personal";
            this.btn_personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personal.UseVisualStyleBackColor = true;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // btn_compra
            // 
            this.btn_compra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_compra.FlatAppearance.BorderSize = 0;
            this.btn_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compra.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_compra.ForeColor = System.Drawing.Color.White;
            this.btn_compra.Location = new System.Drawing.Point(0, 240);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_compra.Size = new System.Drawing.Size(250, 90);
            this.btn_compra.TabIndex = 5;
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
            this.btn_comanda.Location = new System.Drawing.Point(0, 150);
            this.btn_comanda.Name = "btn_comanda";
            this.btn_comanda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_comanda.Size = new System.Drawing.Size(250, 90);
            this.btn_comanda.TabIndex = 3;
            this.btn_comanda.Text = "Comanda";
            this.btn_comanda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_comanda.UseVisualStyleBackColor = true;
            this.btn_comanda.Click += new System.EventHandler(this.btn_comanda_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 150);
            this.panel1.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(0, 124);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(247, 23);
            this.Fecha.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VEPO.Properties.Resources.elmana;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 852);
            this.panel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 852);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.p_lateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "El Mana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.p_lateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_lateral;
        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Button btn_cierre;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_compra;
        private System.Windows.Forms.Button btn_comanda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_insumo;
        private System.Windows.Forms.DateTimePicker Fecha;
    }
}

