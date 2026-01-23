namespace ABM_POO
{
    partial class formIngreso_Egreso
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
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.gpbx_Datos = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBtnGuardar = new System.Windows.Forms.Panel();
            this.btn_CancelarIg_Eg = new System.Windows.Forms.Button();
            this.btn_GuardarIn_Eg = new System.Windows.Forms.Button();
            this.cmbx_Responsable = new System.Windows.Forms.ComboBox();
            this.lbl_Responsable = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.txt_Detalle = new System.Windows.Forms.TextBox();
            this.lbl_Detalle = new System.Windows.Forms.Label();
            this.rdbtn_Egreso = new System.Windows.Forms.RadioButton();
            this.rdbtn_Ingreso = new System.Windows.Forms.RadioButton();
            this.lbl_Listado = new System.Windows.Forms.Label();
            this.dgv_ListaIng_Egre = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gpbx_Filtrar = new System.Windows.Forms.GroupBox();
            this.panelBtnBuscar = new System.Windows.Forms.Panel();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.rdbtn_EgFiltro = new System.Windows.Forms.RadioButton();
            this.rdbtn_IngFiltro = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BalanceGeneral = new System.Windows.Forms.Button();
            this.gpbx_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaIng_Egre)).BeginInit();
            this.gpbx_Filtrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.ForeColor = System.Drawing.Color.White;
            this.lbl_Balance.Location = new System.Drawing.Point(429, 9);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(232, 36);
            this.lbl_Balance.TabIndex = 1;
            this.lbl_Balance.Text = "INGRESO/EGRESO";
            // 
            // gpbx_Datos
            // 
            this.gpbx_Datos.Controls.Add(this.panel2);
            this.gpbx_Datos.Controls.Add(this.panelBtnGuardar);
            this.gpbx_Datos.Controls.Add(this.btn_CancelarIg_Eg);
            this.gpbx_Datos.Controls.Add(this.btn_GuardarIn_Eg);
            this.gpbx_Datos.Controls.Add(this.cmbx_Responsable);
            this.gpbx_Datos.Controls.Add(this.lbl_Responsable);
            this.gpbx_Datos.Controls.Add(this.txt_Monto);
            this.gpbx_Datos.Controls.Add(this.lbl_Monto);
            this.gpbx_Datos.Controls.Add(this.txt_Detalle);
            this.gpbx_Datos.Controls.Add(this.lbl_Detalle);
            this.gpbx_Datos.Controls.Add(this.rdbtn_Egreso);
            this.gpbx_Datos.Controls.Add(this.rdbtn_Ingreso);
            this.gpbx_Datos.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbx_Datos.ForeColor = System.Drawing.Color.White;
            this.gpbx_Datos.Location = new System.Drawing.Point(12, 61);
            this.gpbx_Datos.Name = "gpbx_Datos";
            this.gpbx_Datos.Size = new System.Drawing.Size(966, 185);
            this.gpbx_Datos.TabIndex = 2;
            this.gpbx_Datos.TabStop = false;
            this.gpbx_Datos.Text = "Datos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(823, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 30);
            this.panel2.TabIndex = 20;
            // 
            // panelBtnGuardar
            // 
            this.panelBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.panelBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.panelBtnGuardar.Location = new System.Drawing.Point(684, 122);
            this.panelBtnGuardar.Name = "panelBtnGuardar";
            this.panelBtnGuardar.Size = new System.Drawing.Size(5, 30);
            this.panelBtnGuardar.TabIndex = 19;
            // 
            // btn_CancelarIg_Eg
            // 
            this.btn_CancelarIg_Eg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarIg_Eg.FlatAppearance.BorderSize = 0;
            this.btn_CancelarIg_Eg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(24)))), ((int)(((byte)(13)))));
            this.btn_CancelarIg_Eg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_CancelarIg_Eg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarIg_Eg.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarIg_Eg.Location = new System.Drawing.Point(826, 122);
            this.btn_CancelarIg_Eg.Name = "btn_CancelarIg_Eg";
            this.btn_CancelarIg_Eg.Size = new System.Drawing.Size(124, 30);
            this.btn_CancelarIg_Eg.TabIndex = 18;
            this.btn_CancelarIg_Eg.Text = "Cancelar";
            this.btn_CancelarIg_Eg.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarIn_Eg
            // 
            this.btn_GuardarIn_Eg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GuardarIn_Eg.FlatAppearance.BorderSize = 0;
            this.btn_GuardarIn_Eg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_GuardarIn_Eg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.btn_GuardarIn_Eg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarIn_Eg.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarIn_Eg.Location = new System.Drawing.Point(687, 122);
            this.btn_GuardarIn_Eg.Name = "btn_GuardarIn_Eg";
            this.btn_GuardarIn_Eg.Size = new System.Drawing.Size(124, 30);
            this.btn_GuardarIn_Eg.TabIndex = 17;
            this.btn_GuardarIn_Eg.Text = "Guardar";
            this.btn_GuardarIn_Eg.UseVisualStyleBackColor = true;
            // 
            // cmbx_Responsable
            // 
            this.cmbx_Responsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Responsable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Responsable.FormattingEnabled = true;
            this.cmbx_Responsable.Location = new System.Drawing.Point(444, 125);
            this.cmbx_Responsable.Name = "cmbx_Responsable";
            this.cmbx_Responsable.Size = new System.Drawing.Size(212, 27);
            this.cmbx_Responsable.TabIndex = 7;
            // 
            // lbl_Responsable
            // 
            this.lbl_Responsable.AutoSize = true;
            this.lbl_Responsable.Location = new System.Drawing.Point(439, 93);
            this.lbl_Responsable.Name = "lbl_Responsable";
            this.lbl_Responsable.Size = new System.Drawing.Size(141, 29);
            this.lbl_Responsable.TabIndex = 6;
            this.lbl_Responsable.Text = "Responsable";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Monto.Location = new System.Drawing.Point(168, 125);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(253, 27);
            this.txt_Monto.TabIndex = 5;
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Location = new System.Drawing.Point(163, 93);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(81, 29);
            this.lbl_Monto.TabIndex = 4;
            this.lbl_Monto.Text = "Monto";
            // 
            // txt_Detalle
            // 
            this.txt_Detalle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Detalle.Location = new System.Drawing.Point(168, 53);
            this.txt_Detalle.Name = "txt_Detalle";
            this.txt_Detalle.Size = new System.Drawing.Size(679, 27);
            this.txt_Detalle.TabIndex = 3;
            // 
            // lbl_Detalle
            // 
            this.lbl_Detalle.AutoSize = true;
            this.lbl_Detalle.Location = new System.Drawing.Point(163, 21);
            this.lbl_Detalle.Name = "lbl_Detalle";
            this.lbl_Detalle.Size = new System.Drawing.Size(84, 29);
            this.lbl_Detalle.TabIndex = 2;
            this.lbl_Detalle.Text = "Detalle";
            // 
            // rdbtn_Egreso
            // 
            this.rdbtn_Egreso.AutoSize = true;
            this.rdbtn_Egreso.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Egreso.Location = new System.Drawing.Point(34, 108);
            this.rdbtn_Egreso.Name = "rdbtn_Egreso";
            this.rdbtn_Egreso.Size = new System.Drawing.Size(87, 30);
            this.rdbtn_Egreso.TabIndex = 1;
            this.rdbtn_Egreso.TabStop = true;
            this.rdbtn_Egreso.Text = "Egreso";
            this.rdbtn_Egreso.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Ingreso
            // 
            this.rdbtn_Ingreso.AutoSize = true;
            this.rdbtn_Ingreso.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Ingreso.Location = new System.Drawing.Point(34, 49);
            this.rdbtn_Ingreso.Name = "rdbtn_Ingreso";
            this.rdbtn_Ingreso.Size = new System.Drawing.Size(94, 30);
            this.rdbtn_Ingreso.TabIndex = 0;
            this.rdbtn_Ingreso.TabStop = true;
            this.rdbtn_Ingreso.Text = "Ingreso";
            this.rdbtn_Ingreso.UseVisualStyleBackColor = true;
            // 
            // lbl_Listado
            // 
            this.lbl_Listado.AutoSize = true;
            this.lbl_Listado.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Listado.ForeColor = System.Drawing.Color.White;
            this.lbl_Listado.Location = new System.Drawing.Point(463, 249);
            this.lbl_Listado.Name = "lbl_Listado";
            this.lbl_Listado.Size = new System.Drawing.Size(96, 29);
            this.lbl_Listado.TabIndex = 3;
            this.lbl_Listado.Text = "LISTADO";
            // 
            // dgv_ListaIng_Egre
            // 
            this.dgv_ListaIng_Egre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaIng_Egre.Location = new System.Drawing.Point(12, 410);
            this.dgv_ListaIng_Egre.Name = "dgv_ListaIng_Egre";
            this.dgv_ListaIng_Egre.Size = new System.Drawing.Size(966, 136);
            this.dgv_ListaIng_Egre.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 31);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // gpbx_Filtrar
            // 
            this.gpbx_Filtrar.Controls.Add(this.panelBtnBuscar);
            this.gpbx_Filtrar.Controls.Add(this.btn_Buscar);
            this.gpbx_Filtrar.Controls.Add(this.rdbtn_EgFiltro);
            this.gpbx_Filtrar.Controls.Add(this.rdbtn_IngFiltro);
            this.gpbx_Filtrar.Controls.Add(this.dateTimePicker2);
            this.gpbx_Filtrar.Controls.Add(this.lbl_Hasta);
            this.gpbx_Filtrar.Controls.Add(this.lbl_Desde);
            this.gpbx_Filtrar.Controls.Add(this.dateTimePicker1);
            this.gpbx_Filtrar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbx_Filtrar.ForeColor = System.Drawing.Color.White;
            this.gpbx_Filtrar.Location = new System.Drawing.Point(12, 281);
            this.gpbx_Filtrar.Name = "gpbx_Filtrar";
            this.gpbx_Filtrar.Size = new System.Drawing.Size(966, 123);
            this.gpbx_Filtrar.TabIndex = 6;
            this.gpbx_Filtrar.TabStop = false;
            this.gpbx_Filtrar.Text = "Filtrar";
            // 
            // panelBtnBuscar
            // 
            this.panelBtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.panelBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.panelBtnBuscar.Location = new System.Drawing.Point(799, 62);
            this.panelBtnBuscar.Name = "panelBtnBuscar";
            this.panelBtnBuscar.Size = new System.Drawing.Size(5, 30);
            this.panelBtnBuscar.TabIndex = 26;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Location = new System.Drawing.Point(803, 62);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(120, 30);
            this.btn_Buscar.TabIndex = 25;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // rdbtn_EgFiltro
            // 
            this.rdbtn_EgFiltro.AutoSize = true;
            this.rdbtn_EgFiltro.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_EgFiltro.Location = new System.Drawing.Point(653, 62);
            this.rdbtn_EgFiltro.Name = "rdbtn_EgFiltro";
            this.rdbtn_EgFiltro.Size = new System.Drawing.Size(87, 30);
            this.rdbtn_EgFiltro.TabIndex = 9;
            this.rdbtn_EgFiltro.TabStop = true;
            this.rdbtn_EgFiltro.Text = "Egreso";
            this.rdbtn_EgFiltro.UseVisualStyleBackColor = true;
            // 
            // rdbtn_IngFiltro
            // 
            this.rdbtn_IngFiltro.AutoSize = true;
            this.rdbtn_IngFiltro.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_IngFiltro.Location = new System.Drawing.Point(534, 62);
            this.rdbtn_IngFiltro.Name = "rdbtn_IngFiltro";
            this.rdbtn_IngFiltro.Size = new System.Drawing.Size(94, 30);
            this.rdbtn_IngFiltro.TabIndex = 8;
            this.rdbtn_IngFiltro.TabStop = true;
            this.rdbtn_IngFiltro.Text = "Ingreso";
            this.rdbtn_IngFiltro.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(267, 62);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 31);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hasta.Location = new System.Drawing.Point(262, 33);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(60, 26);
            this.lbl_Hasta.TabIndex = 6;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desde.Location = new System.Drawing.Point(29, 33);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(66, 26);
            this.lbl_Desde.TabIndex = 3;
            this.lbl_Desde.Text = "Desde";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(51)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(366, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 30);
            this.panel1.TabIndex = 28;
            // 
            // btn_BalanceGeneral
            // 
            this.btn_BalanceGeneral.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_BalanceGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BalanceGeneral.FlatAppearance.BorderSize = 0;
            this.btn_BalanceGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(205)))), ((int)(((byte)(45)))));
            this.btn_BalanceGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(51)))));
            this.btn_BalanceGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BalanceGeneral.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BalanceGeneral.ForeColor = System.Drawing.Color.White;
            this.btn_BalanceGeneral.Location = new System.Drawing.Point(370, 564);
            this.btn_BalanceGeneral.Name = "btn_BalanceGeneral";
            this.btn_BalanceGeneral.Size = new System.Drawing.Size(270, 30);
            this.btn_BalanceGeneral.TabIndex = 27;
            this.btn_BalanceGeneral.Text = "Ver Balance General";
            this.btn_BalanceGeneral.UseVisualStyleBackColor = true;
            this.btn_BalanceGeneral.Click += new System.EventHandler(this.btn_BalanceGeneral_Click);
            // 
            // formIngreso_Egreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(990, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_BalanceGeneral);
            this.Controls.Add(this.gpbx_Filtrar);
            this.Controls.Add(this.dgv_ListaIng_Egre);
            this.Controls.Add(this.lbl_Listado);
            this.Controls.Add(this.gpbx_Datos);
            this.Controls.Add(this.lbl_Balance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formIngreso_Egreso";
            this.Text = "formBalance";
            this.gpbx_Datos.ResumeLayout(false);
            this.gpbx_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaIng_Egre)).EndInit();
            this.gpbx_Filtrar.ResumeLayout(false);
            this.gpbx_Filtrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.GroupBox gpbx_Datos;
        private System.Windows.Forms.RadioButton rdbtn_Egreso;
        private System.Windows.Forms.RadioButton rdbtn_Ingreso;
        private System.Windows.Forms.TextBox txt_Detalle;
        private System.Windows.Forms.Label lbl_Detalle;
        private System.Windows.Forms.ComboBox cmbx_Responsable;
        private System.Windows.Forms.Label lbl_Responsable;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBtnGuardar;
        private System.Windows.Forms.Button btn_CancelarIg_Eg;
        private System.Windows.Forms.Button btn_GuardarIn_Eg;
        private System.Windows.Forms.Label lbl_Listado;
        private System.Windows.Forms.DataGridView dgv_ListaIng_Egre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gpbx_Filtrar;
        private System.Windows.Forms.RadioButton rdbtn_EgFiltro;
        private System.Windows.Forms.RadioButton rdbtn_IngFiltro;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.Panel panelBtnBuscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_BalanceGeneral;
    }
}