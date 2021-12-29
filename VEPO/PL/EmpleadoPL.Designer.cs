
namespace VEPO.PL
{
    partial class EmpleadoPL
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
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_id_especie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_convenio = new System.Windows.Forms.MaskedTextBox();
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
            // txt_empleado
            // 
            this.txt_empleado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_empleado.Location = new System.Drawing.Point(78, 79);
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.Size = new System.Drawing.Size(152, 27);
            this.txt_empleado.TabIndex = 8;
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
            // lb_id_especie
            // 
            this.lb_id_especie.AutoSize = true;
            this.lb_id_especie.Location = new System.Drawing.Point(49, 91);
            this.lb_id_especie.Name = "lb_id_especie";
            this.lb_id_especie.Size = new System.Drawing.Size(13, 15);
            this.lb_id_especie.TabIndex = 15;
            this.lb_id_especie.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "$/H";
            // 
            // txt_convenio
            // 
            this.txt_convenio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_convenio.Location = new System.Drawing.Point(266, 79);
            this.txt_convenio.Mask = "99.00";
            this.txt_convenio.Name = "txt_convenio";
            this.txt_convenio.Size = new System.Drawing.Size(46, 27);
            this.txt_convenio.TabIndex = 18;
            this.txt_convenio.ValidatingType = typeof(int);
            // 
            // EmpleadoPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1132, 708);
            this.Controls.Add(this.txt_convenio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_id_especie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_empleado);
            this.Controls.Add(this.btn_modificar_esp);
            this.Controls.Add(this.btn_borrar_esp);
            this.Controls.Add(this.btn_agregar_esp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmpleadoPL";
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
        private System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_id_especie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_convenio;
    }
}