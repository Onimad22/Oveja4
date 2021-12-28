
namespace VEPO.PL
{
    partial class ProductoPL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_agregar_esp = new System.Windows.Forms.Button();
            this.btn_borrar_esp = new System.Windows.Forms.Button();
            this.btn_modificar_esp = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_id_producto = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_local = new System.Windows.Forms.MaskedTextBox();
            this.txt_peya = new System.Windows.Forms.MaskedTextBox();
            this.txt_carne = new System.Windows.Forms.MaskedTextBox();
            this.txt_papa = new System.Windows.Forms.MaskedTextBox();
            this.txt_bono = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(78, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 536);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_agregar_esp
            // 
            this.btn_agregar_esp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_agregar_esp.FlatAppearance.BorderSize = 3;
            this.btn_agregar_esp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btn_agregar_esp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_esp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar_esp.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_esp.Location = new System.Drawing.Point(760, 177);
            this.btn_agregar_esp.Name = "btn_agregar_esp";
            this.btn_agregar_esp.Size = new System.Drawing.Size(114, 42);
            this.btn_agregar_esp.TabIndex = 7;
            this.btn_agregar_esp.Text = "Agregar";
            this.btn_agregar_esp.UseVisualStyleBackColor = false;
            this.btn_agregar_esp.Click += new System.EventHandler(this.btn_agregar_esp_Click);
            // 
            // btn_borrar_esp
            // 
            this.btn_borrar_esp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_borrar_esp.FlatAppearance.BorderSize = 3;
            this.btn_borrar_esp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btn_borrar_esp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar_esp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_borrar_esp.ForeColor = System.Drawing.Color.White;
            this.btn_borrar_esp.Location = new System.Drawing.Point(760, 367);
            this.btn_borrar_esp.Name = "btn_borrar_esp";
            this.btn_borrar_esp.Size = new System.Drawing.Size(114, 42);
            this.btn_borrar_esp.TabIndex = 9;
            this.btn_borrar_esp.Text = "Borrar";
            this.btn_borrar_esp.UseVisualStyleBackColor = false;
            this.btn_borrar_esp.Click += new System.EventHandler(this.btn_borrar_esp_Click);
            // 
            // btn_modificar_esp
            // 
            this.btn_modificar_esp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(73)))), ((int)(((byte)(0)))));
            this.btn_modificar_esp.FlatAppearance.BorderSize = 3;
            this.btn_modificar_esp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.btn_modificar_esp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar_esp.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_modificar_esp.ForeColor = System.Drawing.Color.White;
            this.btn_modificar_esp.Location = new System.Drawing.Point(760, 269);
            this.btn_modificar_esp.Name = "btn_modificar_esp";
            this.btn_modificar_esp.Size = new System.Drawing.Size(114, 42);
            this.btn_modificar_esp.TabIndex = 8;
            this.btn_modificar_esp.Text = "Modificar";
            this.btn_modificar_esp.UseVisualStyleBackColor = false;
            this.btn_modificar_esp.Click += new System.EventHandler(this.btn_modificar_esp_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombre.Location = new System.Drawing.Point(78, 79);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(152, 27);
            this.txt_nombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // lb_id_producto
            // 
            this.lb_id_producto.AutoSize = true;
            this.lb_id_producto.Location = new System.Drawing.Point(49, 91);
            this.lb_id_producto.Name = "lb_id_producto";
            this.lb_id_producto.Size = new System.Drawing.Size(13, 15);
            this.lb_id_producto.TabIndex = 15;
            this.lb_id_producto.Text = "0";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_categoria.Location = new System.Drawing.Point(722, 79);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(152, 27);
            this.txt_categoria.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(722, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(248, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "$ Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(342, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "$ Peya";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(435, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Carne";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(526, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Papa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(619, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Bono";
            // 
            // txt_local
            // 
            this.txt_local.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_local.Location = new System.Drawing.Point(248, 79);
            this.txt_local.Mask = "99";
            this.txt_local.Name = "txt_local";
            this.txt_local.Size = new System.Drawing.Size(76, 27);
            this.txt_local.TabIndex = 1;
            this.txt_local.Tag = "";
            this.txt_local.ValidatingType = typeof(int);
            // 
            // txt_peya
            // 
            this.txt_peya.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_peya.Location = new System.Drawing.Point(342, 79);
            this.txt_peya.Mask = "99";
            this.txt_peya.Name = "txt_peya";
            this.txt_peya.Size = new System.Drawing.Size(76, 27);
            this.txt_peya.TabIndex = 2;
            this.txt_peya.Tag = "";
            this.txt_peya.ValidatingType = typeof(int);
            // 
            // txt_carne
            // 
            this.txt_carne.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_carne.Location = new System.Drawing.Point(435, 79);
            this.txt_carne.Mask = "9";
            this.txt_carne.Name = "txt_carne";
            this.txt_carne.Size = new System.Drawing.Size(76, 27);
            this.txt_carne.TabIndex = 3;
            this.txt_carne.Tag = "";
            this.txt_carne.ValidatingType = typeof(int);
            // 
            // txt_papa
            // 
            this.txt_papa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_papa.Location = new System.Drawing.Point(526, 79);
            this.txt_papa.Mask = "9";
            this.txt_papa.Name = "txt_papa";
            this.txt_papa.Size = new System.Drawing.Size(76, 27);
            this.txt_papa.TabIndex = 4;
            this.txt_papa.Tag = "";
            this.txt_papa.ValidatingType = typeof(int);
            // 
            // txt_bono
            // 
            this.txt_bono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_bono.Location = new System.Drawing.Point(619, 79);
            this.txt_bono.Mask = "9.99";
            this.txt_bono.Name = "txt_bono";
            this.txt_bono.Size = new System.Drawing.Size(76, 27);
            this.txt_bono.TabIndex = 5;
            this.txt_bono.Tag = "";
            this.txt_bono.ValidatingType = typeof(int);
            // 
            // ProductoPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1132, 708);
            this.Controls.Add(this.txt_bono);
            this.Controls.Add(this.txt_papa);
            this.Controls.Add(this.txt_carne);
            this.Controls.Add(this.txt_peya);
            this.Controls.Add(this.txt_local);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.lb_id_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_modificar_esp);
            this.Controls.Add(this.btn_borrar_esp);
            this.Controls.Add(this.btn_agregar_esp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductoPL";
            this.Text = "productoPL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_agregar_esp;
        private System.Windows.Forms.Button btn_borrar_esp;
        private System.Windows.Forms.Button btn_modificar_esp;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_id_producto;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_local;
        private System.Windows.Forms.MaskedTextBox txt_peya;
        private System.Windows.Forms.MaskedTextBox txt_carne;
        private System.Windows.Forms.MaskedTextBox txt_papa;
        private System.Windows.Forms.MaskedTextBox txt_bono;
    }
}