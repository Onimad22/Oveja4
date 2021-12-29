
namespace VEPO.PL
{
    partial class JornalPL

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_agregar_esp = new System.Windows.Forms.Button();
            this.btn_borrar_esp = new System.Windows.Forms.Button();
            this.btn_modificar_esp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_id_compra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_insumo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_entrada = new System.Windows.Forms.MaskedTextBox();
            this.txt_salida = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(78, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(340, 359);
            this.dataGridView1.TabIndex = 0;
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
            this.btn_agregar_esp.Location = new System.Drawing.Point(446, 178);
            this.btn_agregar_esp.Name = "btn_agregar_esp";
            this.btn_agregar_esp.Size = new System.Drawing.Size(114, 42);
            this.btn_agregar_esp.TabIndex = 2;
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
            this.btn_borrar_esp.Location = new System.Drawing.Point(446, 368);
            this.btn_borrar_esp.Name = "btn_borrar_esp";
            this.btn_borrar_esp.Size = new System.Drawing.Size(114, 42);
            this.btn_borrar_esp.TabIndex = 3;
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
            this.btn_modificar_esp.Location = new System.Drawing.Point(446, 270);
            this.btn_modificar_esp.Name = "btn_modificar_esp";
            this.btn_modificar_esp.Size = new System.Drawing.Size(114, 42);
            this.btn_modificar_esp.TabIndex = 4;
            this.btn_modificar_esp.Text = "Modificar";
            this.btn_modificar_esp.UseVisualStyleBackColor = false;
            this.btn_modificar_esp.Click += new System.EventHandler(this.btn_modificar_esp_Click);
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
            // lb_id_compra
            // 
            this.lb_id_compra.AutoSize = true;
            this.lb_id_compra.Location = new System.Drawing.Point(49, 91);
            this.lb_id_compra.Name = "lb_id_compra";
            this.lb_id_compra.Size = new System.Drawing.Size(13, 15);
            this.lb_id_compra.TabIndex = 15;
            this.lb_id_compra.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entrada";
            // 
            // cb_insumo
            // 
            this.cb_insumo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_insumo.FormattingEnabled = true;
            this.cb_insumo.Location = new System.Drawing.Point(78, 78);
            this.cb_insumo.Name = "cb_insumo";
            this.cb_insumo.Size = new System.Drawing.Size(121, 28);
            this.cb_insumo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(411, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Salida";
            // 
            // txt_entrada
            // 
            this.txt_entrada.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_entrada.Location = new System.Drawing.Point(264, 78);
            this.txt_entrada.Mask = "00:00";
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(41, 27);
            this.txt_entrada.TabIndex = 21;
            this.txt_entrada.ValidatingType = typeof(System.DateTime);
            // 
            // txt_salida
            // 
            this.txt_salida.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_salida.Location = new System.Drawing.Point(411, 78);
            this.txt_salida.Mask = "00:00";
            this.txt_salida.Name = "txt_salida";
            this.txt_salida.Size = new System.Drawing.Size(41, 27);
            this.txt_salida.TabIndex = 22;
            this.txt_salida.ValidatingType = typeof(System.DateTime);
            // 
            // JornalPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1132, 708);
            this.Controls.Add(this.txt_salida);
            this.Controls.Add(this.txt_entrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_insumo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_id_compra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_modificar_esp);
            this.Controls.Add(this.btn_borrar_esp);
            this.Controls.Add(this.btn_agregar_esp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JornalPL";
            this.Text = "especiePL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_agregar_esp;
        private System.Windows.Forms.Button btn_borrar_esp;
        private System.Windows.Forms.Button btn_modificar_esp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_id_compra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_insumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_entrada;
        private System.Windows.Forms.MaskedTextBox txt_salida;
    }
}