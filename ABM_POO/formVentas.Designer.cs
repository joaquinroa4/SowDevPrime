namespace ABM_POO
{
    partial class formVentas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_GeneraRemito = new System.Windows.Forms.Label();
            this.cmbx_TipoCliente = new System.Windows.Forms.ComboBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.gpbx_DatosCliente = new System.Windows.Forms.GroupBox();
            this.lbl_IDCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBtnGuardar = new System.Windows.Forms.Panel();
            this.btn_CancelarRemito = new System.Windows.Forms.Button();
            this.btn_GuardarRemito = new System.Windows.Forms.Button();
            this.txt_DirecRemito = new System.Windows.Forms.TextBox();
            this.txt_EmailRemito = new System.Windows.Forms.TextBox();
            this.txt_CuitRemito = new System.Windows.Forms.TextBox();
            this.txt_TelfRemito = new System.Windows.Forms.TextBox();
            this.txt_NombreRemito = new System.Windows.Forms.TextBox();
            this.lbl_DirecRemito = new System.Windows.Forms.Label();
            this.lbl_CuitRemito = new System.Windows.Forms.Label();
            this.lbl_EmailRemito = new System.Windows.Forms.Label();
            this.lbl_TelfRemito = new System.Windows.Forms.Label();
            this.lbl_NombreRemito = new System.Windows.Forms.Label();
            this.gpbx_DatosArticulo = new System.Windows.Forms.GroupBox();
            this.dgv_Arts = new System.Windows.Forms.DataGridView();
            this.lbl_PrecioUnidad = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.cmbx_codDescrip = new System.Windows.Forms.ComboBox();
            this.cmbx_codProductos = new System.Windows.Forms.ComboBox();
            this.lbl_ID_Remito = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numUpDown_Cant = new System.Windows.Forms.NumericUpDown();
            this.btn_AgregarArt = new System.Windows.Forms.Button();
            this.lbl_CantArt = new System.Windows.Forms.Label();
            this.lbl_DescArt = new System.Windows.Forms.Label();
            this.lbl_CodigoArt = new System.Windows.Forms.Label();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Vendedor = new System.Windows.Forms.Label();
            this.cmbx_Vendedores = new System.Windows.Forms.ComboBox();
            this.lbl_tipoCLiente = new System.Windows.Forms.Label();
            this.lbl_CuitBuscar = new System.Windows.Forms.Label();
            this.txt_CuitBuscar = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.panelBtnBuscar = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_FechaHora = new System.Windows.Forms.Label();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.numUpDownDesc = new System.Windows.Forms.NumericUpDown();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioXUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbx_DatosCliente.SuspendLayout();
            this.gpbx_DatosArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Arts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Cant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_GeneraRemito
            // 
            this.lbl_GeneraRemito.AutoSize = true;
            this.lbl_GeneraRemito.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GeneraRemito.ForeColor = System.Drawing.Color.White;
            this.lbl_GeneraRemito.Location = new System.Drawing.Point(464, 9);
            this.lbl_GeneraRemito.Name = "lbl_GeneraRemito";
            this.lbl_GeneraRemito.Size = new System.Drawing.Size(109, 36);
            this.lbl_GeneraRemito.TabIndex = 0;
            this.lbl_GeneraRemito.Text = "VENTAS";
            // 
            // cmbx_TipoCliente
            // 
            this.cmbx_TipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_TipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbx_TipoCliente.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_TipoCliente.FormattingEnabled = true;
            this.cmbx_TipoCliente.Items.AddRange(new object[] {
            "Cliente Nuevo",
            "Cliente Existente"});
            this.cmbx_TipoCliente.Location = new System.Drawing.Point(41, 70);
            this.cmbx_TipoCliente.Name = "cmbx_TipoCliente";
            this.cmbx_TipoCliente.Size = new System.Drawing.Size(231, 27);
            this.cmbx_TipoCliente.TabIndex = 1;
            this.cmbx_TipoCliente.SelectedIndexChanged += new System.EventHandler(this.cmbx_TipoCliente_SelectedIndexChanged);
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
            this.btn_Buscar.Location = new System.Drawing.Point(748, 67);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(120, 30);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // gpbx_DatosCliente
            // 
            this.gpbx_DatosCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpbx_DatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(109)))));
            this.gpbx_DatosCliente.Controls.Add(this.lbl_IDCliente);
            this.gpbx_DatosCliente.Controls.Add(this.panel2);
            this.gpbx_DatosCliente.Controls.Add(this.panelBtnGuardar);
            this.gpbx_DatosCliente.Controls.Add(this.btn_CancelarRemito);
            this.gpbx_DatosCliente.Controls.Add(this.btn_GuardarRemito);
            this.gpbx_DatosCliente.Controls.Add(this.txt_DirecRemito);
            this.gpbx_DatosCliente.Controls.Add(this.txt_EmailRemito);
            this.gpbx_DatosCliente.Controls.Add(this.txt_CuitRemito);
            this.gpbx_DatosCliente.Controls.Add(this.txt_TelfRemito);
            this.gpbx_DatosCliente.Controls.Add(this.txt_NombreRemito);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_DirecRemito);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_CuitRemito);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_EmailRemito);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_TelfRemito);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_NombreRemito);
            this.gpbx_DatosCliente.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbx_DatosCliente.ForeColor = System.Drawing.Color.White;
            this.gpbx_DatosCliente.Location = new System.Drawing.Point(12, 105);
            this.gpbx_DatosCliente.Name = "gpbx_DatosCliente";
            this.gpbx_DatosCliente.Size = new System.Drawing.Size(966, 153);
            this.gpbx_DatosCliente.TabIndex = 6;
            this.gpbx_DatosCliente.TabStop = false;
            this.gpbx_DatosCliente.Text = "Datos de Cliente";
            // 
            // lbl_IDCliente
            // 
            this.lbl_IDCliente.AutoSize = true;
            this.lbl_IDCliente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDCliente.Location = new System.Drawing.Point(214, 24);
            this.lbl_IDCliente.Name = "lbl_IDCliente";
            this.lbl_IDCliente.Size = new System.Drawing.Size(0, 26);
            this.lbl_IDCliente.TabIndex = 17;
            this.lbl_IDCliente.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(818, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 30);
            this.panel2.TabIndex = 16;
            // 
            // panelBtnGuardar
            // 
            this.panelBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.panelBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.panelBtnGuardar.Location = new System.Drawing.Point(679, 106);
            this.panelBtnGuardar.Name = "panelBtnGuardar";
            this.panelBtnGuardar.Size = new System.Drawing.Size(5, 30);
            this.panelBtnGuardar.TabIndex = 15;
            // 
            // btn_CancelarRemito
            // 
            this.btn_CancelarRemito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarRemito.FlatAppearance.BorderSize = 0;
            this.btn_CancelarRemito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(24)))), ((int)(((byte)(13)))));
            this.btn_CancelarRemito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_CancelarRemito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarRemito.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarRemito.Location = new System.Drawing.Point(821, 106);
            this.btn_CancelarRemito.Name = "btn_CancelarRemito";
            this.btn_CancelarRemito.Size = new System.Drawing.Size(124, 30);
            this.btn_CancelarRemito.TabIndex = 14;
            this.btn_CancelarRemito.Text = "Cancelar";
            this.btn_CancelarRemito.UseVisualStyleBackColor = true;
            this.btn_CancelarRemito.Click += new System.EventHandler(this.btn_CancelarRemito_Click);
            // 
            // btn_GuardarRemito
            // 
            this.btn_GuardarRemito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GuardarRemito.FlatAppearance.BorderSize = 0;
            this.btn_GuardarRemito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_GuardarRemito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.btn_GuardarRemito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarRemito.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarRemito.Location = new System.Drawing.Point(682, 106);
            this.btn_GuardarRemito.Name = "btn_GuardarRemito";
            this.btn_GuardarRemito.Size = new System.Drawing.Size(124, 30);
            this.btn_GuardarRemito.TabIndex = 13;
            this.btn_GuardarRemito.Text = "Guardar";
            this.btn_GuardarRemito.UseVisualStyleBackColor = true;
            this.btn_GuardarRemito.Click += new System.EventHandler(this.btn_GuardarRemito_Click);
            // 
            // txt_DirecRemito
            // 
            this.txt_DirecRemito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DirecRemito.Location = new System.Drawing.Point(341, 108);
            this.txt_DirecRemito.Name = "txt_DirecRemito";
            this.txt_DirecRemito.Size = new System.Drawing.Size(325, 26);
            this.txt_DirecRemito.TabIndex = 12;
            // 
            // txt_EmailRemito
            // 
            this.txt_EmailRemito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailRemito.Location = new System.Drawing.Point(29, 108);
            this.txt_EmailRemito.Name = "txt_EmailRemito";
            this.txt_EmailRemito.Size = new System.Drawing.Size(289, 26);
            this.txt_EmailRemito.TabIndex = 11;
            // 
            // txt_CuitRemito
            // 
            this.txt_CuitRemito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CuitRemito.Location = new System.Drawing.Point(682, 53);
            this.txt_CuitRemito.Name = "txt_CuitRemito";
            this.txt_CuitRemito.Size = new System.Drawing.Size(258, 26);
            this.txt_CuitRemito.TabIndex = 10;
            // 
            // txt_TelfRemito
            // 
            this.txt_TelfRemito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelfRemito.Location = new System.Drawing.Point(341, 53);
            this.txt_TelfRemito.Name = "txt_TelfRemito";
            this.txt_TelfRemito.Size = new System.Drawing.Size(325, 26);
            this.txt_TelfRemito.TabIndex = 9;
            // 
            // txt_NombreRemito
            // 
            this.txt_NombreRemito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreRemito.Location = new System.Drawing.Point(29, 53);
            this.txt_NombreRemito.Name = "txt_NombreRemito";
            this.txt_NombreRemito.Size = new System.Drawing.Size(289, 26);
            this.txt_NombreRemito.TabIndex = 8;
            // 
            // lbl_DirecRemito
            // 
            this.lbl_DirecRemito.AutoSize = true;
            this.lbl_DirecRemito.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DirecRemito.Location = new System.Drawing.Point(336, 83);
            this.lbl_DirecRemito.Name = "lbl_DirecRemito";
            this.lbl_DirecRemito.Size = new System.Drawing.Size(93, 26);
            this.lbl_DirecRemito.TabIndex = 7;
            this.lbl_DirecRemito.Text = "Dirección";
            // 
            // lbl_CuitRemito
            // 
            this.lbl_CuitRemito.AutoSize = true;
            this.lbl_CuitRemito.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CuitRemito.Location = new System.Drawing.Point(677, 24);
            this.lbl_CuitRemito.Name = "lbl_CuitRemito";
            this.lbl_CuitRemito.Size = new System.Drawing.Size(53, 26);
            this.lbl_CuitRemito.TabIndex = 6;
            this.lbl_CuitRemito.Text = "CUIT";
            // 
            // lbl_EmailRemito
            // 
            this.lbl_EmailRemito.AutoSize = true;
            this.lbl_EmailRemito.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailRemito.Location = new System.Drawing.Point(24, 82);
            this.lbl_EmailRemito.Name = "lbl_EmailRemito";
            this.lbl_EmailRemito.Size = new System.Drawing.Size(59, 26);
            this.lbl_EmailRemito.TabIndex = 5;
            this.lbl_EmailRemito.Text = "Email";
            // 
            // lbl_TelfRemito
            // 
            this.lbl_TelfRemito.AutoSize = true;
            this.lbl_TelfRemito.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelfRemito.Location = new System.Drawing.Point(336, 27);
            this.lbl_TelfRemito.Name = "lbl_TelfRemito";
            this.lbl_TelfRemito.Size = new System.Drawing.Size(87, 26);
            this.lbl_TelfRemito.TabIndex = 4;
            this.lbl_TelfRemito.Text = "Teléfono";
            // 
            // lbl_NombreRemito
            // 
            this.lbl_NombreRemito.AutoSize = true;
            this.lbl_NombreRemito.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreRemito.Location = new System.Drawing.Point(24, 27);
            this.lbl_NombreRemito.Name = "lbl_NombreRemito";
            this.lbl_NombreRemito.Size = new System.Drawing.Size(83, 26);
            this.lbl_NombreRemito.TabIndex = 3;
            this.lbl_NombreRemito.Text = "Nombre";
            // 
            // gpbx_DatosArticulo
            // 
            this.gpbx_DatosArticulo.Controls.Add(this.dgv_Arts);
            this.gpbx_DatosArticulo.Controls.Add(this.lbl_PrecioUnidad);
            this.gpbx_DatosArticulo.Controls.Add(this.txt_Precio);
            this.gpbx_DatosArticulo.Controls.Add(this.lbl_Precio);
            this.gpbx_DatosArticulo.Controls.Add(this.cmbx_codDescrip);
            this.gpbx_DatosArticulo.Controls.Add(this.cmbx_codProductos);
            this.gpbx_DatosArticulo.Controls.Add(this.lbl_ID_Remito);
            this.gpbx_DatosArticulo.Controls.Add(this.panel5);
            this.gpbx_DatosArticulo.Controls.Add(this.numUpDown_Cant);
            this.gpbx_DatosArticulo.Controls.Add(this.btn_AgregarArt);
            this.gpbx_DatosArticulo.Controls.Add(this.lbl_CantArt);
            this.gpbx_DatosArticulo.Controls.Add(this.lbl_DescArt);
            this.gpbx_DatosArticulo.Controls.Add(this.lbl_CodigoArt);
            this.gpbx_DatosArticulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpbx_DatosArticulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbx_DatosArticulo.ForeColor = System.Drawing.Color.White;
            this.gpbx_DatosArticulo.Location = new System.Drawing.Point(12, 264);
            this.gpbx_DatosArticulo.Name = "gpbx_DatosArticulo";
            this.gpbx_DatosArticulo.Size = new System.Drawing.Size(966, 215);
            this.gpbx_DatosArticulo.TabIndex = 7;
            this.gpbx_DatosArticulo.TabStop = false;
            this.gpbx_DatosArticulo.Text = "Datos de Artículo";
            // 
            // dgv_Arts
            // 
            this.dgv_Arts.AllowUserToAddRows = false;
            this.dgv_Arts.AllowUserToDeleteRows = false;
            this.dgv_Arts.AllowUserToResizeColumns = false;
            this.dgv_Arts.AllowUserToResizeRows = false;
            this.dgv_Arts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Arts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Arts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProd,
            this.CodProd,
            this.Descripcion,
            this.PrecioXUnidad,
            this.CantidadProd,
            this.SubtotalProd});
            this.dgv_Arts.Location = new System.Drawing.Point(13, 94);
            this.dgv_Arts.Name = "dgv_Arts";
            this.dgv_Arts.Size = new System.Drawing.Size(936, 115);
            this.dgv_Arts.TabIndex = 26;
            // 
            // lbl_PrecioUnidad
            // 
            this.lbl_PrecioUnidad.AutoSize = true;
            this.lbl_PrecioUnidad.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioUnidad.Location = new System.Drawing.Point(363, 21);
            this.lbl_PrecioUnidad.Name = "lbl_PrecioUnidad";
            this.lbl_PrecioUnidad.Size = new System.Drawing.Size(0, 26);
            this.lbl_PrecioUnidad.TabIndex = 25;
            this.lbl_PrecioUnidad.Visible = false;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio.Location = new System.Drawing.Point(637, 60);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.ReadOnly = true;
            this.txt_Precio.Size = new System.Drawing.Size(186, 26);
            this.txt_Precio.TabIndex = 24;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(632, 33);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(66, 26);
            this.lbl_Precio.TabIndex = 23;
            this.lbl_Precio.Text = "Precio";
            // 
            // cmbx_codDescrip
            // 
            this.cmbx_codDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_codDescrip.FormattingEnabled = true;
            this.cmbx_codDescrip.Location = new System.Drawing.Point(219, 59);
            this.cmbx_codDescrip.Name = "cmbx_codDescrip";
            this.cmbx_codDescrip.Size = new System.Drawing.Size(237, 28);
            this.cmbx_codDescrip.TabIndex = 22;
            // 
            // cmbx_codProductos
            // 
            this.cmbx_codProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_codProductos.FormattingEnabled = true;
            this.cmbx_codProductos.Location = new System.Drawing.Point(17, 60);
            this.cmbx_codProductos.Name = "cmbx_codProductos";
            this.cmbx_codProductos.Size = new System.Drawing.Size(183, 28);
            this.cmbx_codProductos.TabIndex = 21;
            this.cmbx_codProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbx_codProductos_KeyPress);
            // 
            // lbl_ID_Remito
            // 
            this.lbl_ID_Remito.AutoSize = true;
            this.lbl_ID_Remito.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_Remito.Location = new System.Drawing.Point(404, 21);
            this.lbl_ID_Remito.Name = "lbl_ID_Remito";
            this.lbl_ID_Remito.Size = new System.Drawing.Size(0, 26);
            this.lbl_ID_Remito.TabIndex = 20;
            this.lbl_ID_Remito.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(833, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 30);
            this.panel5.TabIndex = 19;
            // 
            // numUpDown_Cant
            // 
            this.numUpDown_Cant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDown_Cant.Location = new System.Drawing.Point(470, 59);
            this.numUpDown_Cant.Name = "numUpDown_Cant";
            this.numUpDown_Cant.Size = new System.Drawing.Size(148, 27);
            this.numUpDown_Cant.TabIndex = 17;
            this.numUpDown_Cant.ValueChanged += new System.EventHandler(this.numUpDown_Cant_ValueChanged);
            // 
            // btn_AgregarArt
            // 
            this.btn_AgregarArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarArt.FlatAppearance.BorderSize = 0;
            this.btn_AgregarArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.btn_AgregarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarArt.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarArt.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarArt.Location = new System.Drawing.Point(836, 56);
            this.btn_AgregarArt.Name = "btn_AgregarArt";
            this.btn_AgregarArt.Size = new System.Drawing.Size(124, 30);
            this.btn_AgregarArt.TabIndex = 16;
            this.btn_AgregarArt.Text = "Agregar";
            this.btn_AgregarArt.UseVisualStyleBackColor = true;
            this.btn_AgregarArt.Click += new System.EventHandler(this.btn_AgregarArt_Click);
            // 
            // lbl_CantArt
            // 
            this.lbl_CantArt.AutoSize = true;
            this.lbl_CantArt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CantArt.Location = new System.Drawing.Point(465, 32);
            this.lbl_CantArt.Name = "lbl_CantArt";
            this.lbl_CantArt.Size = new System.Drawing.Size(88, 26);
            this.lbl_CantArt.TabIndex = 13;
            this.lbl_CantArt.Text = "Cantidad";
            // 
            // lbl_DescArt
            // 
            this.lbl_DescArt.AutoSize = true;
            this.lbl_DescArt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescArt.Location = new System.Drawing.Point(214, 33);
            this.lbl_DescArt.Name = "lbl_DescArt";
            this.lbl_DescArt.Size = new System.Drawing.Size(112, 26);
            this.lbl_DescArt.TabIndex = 10;
            this.lbl_DescArt.Text = "Descripción";
            // 
            // lbl_CodigoArt
            // 
            this.lbl_CodigoArt.AutoSize = true;
            this.lbl_CodigoArt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodigoArt.Location = new System.Drawing.Point(12, 33);
            this.lbl_CodigoArt.Name = "lbl_CodigoArt";
            this.lbl_CodigoArt.Size = new System.Drawing.Size(71, 26);
            this.lbl_CodigoArt.TabIndex = 4;
            this.lbl_CodigoArt.Text = "Código";
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.AutoSize = true;
            this.lbl_SubTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTotal.ForeColor = System.Drawing.Color.White;
            this.lbl_SubTotal.Location = new System.Drawing.Point(70, 492);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(84, 26);
            this.lbl_SubTotal.TabIndex = 9;
            this.lbl_SubTotal.Text = "Subtotal";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.AcceptsReturn = true;
            this.txt_Subtotal.BackColor = System.Drawing.Color.White;
            this.txt_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subtotal.Location = new System.Drawing.Point(75, 521);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.ReadOnly = true;
            this.txt_Subtotal.Size = new System.Drawing.Size(155, 26);
            this.txt_Subtotal.TabIndex = 10;
            this.txt_Subtotal.Text = "0";
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descuento.ForeColor = System.Drawing.Color.White;
            this.lbl_Descuento.Location = new System.Drawing.Point(271, 495);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(104, 26);
            this.lbl_Descuento.TabIndex = 11;
            this.lbl_Descuento.Text = "Descuento";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Total.Location = new System.Drawing.Point(676, 509);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(69, 29);
            this.lbl_Total.TabIndex = 13;
            this.lbl_Total.Text = "Total:";
            // 
            // lbl_Vendedor
            // 
            this.lbl_Vendedor.AutoSize = true;
            this.lbl_Vendedor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vendedor.ForeColor = System.Drawing.Color.White;
            this.lbl_Vendedor.Location = new System.Drawing.Point(477, 495);
            this.lbl_Vendedor.Name = "lbl_Vendedor";
            this.lbl_Vendedor.Size = new System.Drawing.Size(96, 26);
            this.lbl_Vendedor.TabIndex = 17;
            this.lbl_Vendedor.Text = "Vendedor";
            // 
            // cmbx_Vendedores
            // 
            this.cmbx_Vendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Vendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Vendedores.FormattingEnabled = true;
            this.cmbx_Vendedores.Location = new System.Drawing.Point(482, 524);
            this.cmbx_Vendedores.Name = "cmbx_Vendedores";
            this.cmbx_Vendedores.Size = new System.Drawing.Size(177, 26);
            this.cmbx_Vendedores.TabIndex = 18;
            // 
            // lbl_tipoCLiente
            // 
            this.lbl_tipoCLiente.AutoSize = true;
            this.lbl_tipoCLiente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoCLiente.ForeColor = System.Drawing.Color.White;
            this.lbl_tipoCLiente.Location = new System.Drawing.Point(36, 43);
            this.lbl_tipoCLiente.Name = "lbl_tipoCLiente";
            this.lbl_tipoCLiente.Size = new System.Drawing.Size(148, 26);
            this.lbl_tipoCLiente.TabIndex = 19;
            this.lbl_tipoCLiente.Text = "Tipo de Cliente:";
            // 
            // lbl_CuitBuscar
            // 
            this.lbl_CuitBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CuitBuscar.AutoSize = true;
            this.lbl_CuitBuscar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CuitBuscar.ForeColor = System.Drawing.Color.White;
            this.lbl_CuitBuscar.Location = new System.Drawing.Point(332, 67);
            this.lbl_CuitBuscar.Name = "lbl_CuitBuscar";
            this.lbl_CuitBuscar.Size = new System.Drawing.Size(53, 26);
            this.lbl_CuitBuscar.TabIndex = 20;
            this.lbl_CuitBuscar.Text = "CUIT";
            // 
            // txt_CuitBuscar
            // 
            this.txt_CuitBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_CuitBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CuitBuscar.Location = new System.Drawing.Point(400, 68);
            this.txt_CuitBuscar.Name = "txt_CuitBuscar";
            this.txt_CuitBuscar.Size = new System.Drawing.Size(293, 26);
            this.txt_CuitBuscar.TabIndex = 21;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(24)))), ((int)(((byte)(13)))));
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(837, 562);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(124, 30);
            this.btn_Cancelar.TabIndex = 23;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(691, 562);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(124, 30);
            this.btn_Guardar.TabIndex = 22;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // panelBtnBuscar
            // 
            this.panelBtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.panelBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.panelBtnBuscar.Location = new System.Drawing.Point(744, 67);
            this.panelBtnBuscar.Name = "panelBtnBuscar";
            this.panelBtnBuscar.Size = new System.Drawing.Size(5, 30);
            this.panelBtnBuscar.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(688, 562);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 30);
            this.panel6.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(834, 562);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 30);
            this.panel7.TabIndex = 26;
            // 
            // lbl_FechaHora
            // 
            this.lbl_FechaHora.AutoSize = true;
            this.lbl_FechaHora.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaHora.ForeColor = System.Drawing.Color.White;
            this.lbl_FechaHora.Location = new System.Drawing.Point(765, 9);
            this.lbl_FechaHora.Name = "lbl_FechaHora";
            this.lbl_FechaHora.Size = new System.Drawing.Size(0, 26);
            this.lbl_FechaHora.TabIndex = 27;
            // 
            // tmrFechaHora
            // 
            this.tmrFechaHora.Enabled = true;
            this.tmrFechaHora.Tick += new System.EventHandler(this.tmrFechaHora_Tick);
            // 
            // numUpDownDesc
            // 
            this.numUpDownDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownDesc.Location = new System.Drawing.Point(276, 522);
            this.numUpDownDesc.Name = "numUpDownDesc";
            this.numUpDownDesc.Size = new System.Drawing.Size(158, 27);
            this.numUpDownDesc.TabIndex = 28;
            this.numUpDownDesc.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 170;
            // 
            // ID_Prod
            // 
            this.ID_Prod.HeaderText = "ID";
            this.ID_Prod.Name = "ID_Prod";
            this.ID_Prod.Visible = false;
            // 
            // DescProd
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescProd.DefaultCellStyle = dataGridViewCellStyle5;
            this.DescProd.FillWeight = 17.13197F;
            this.DescProd.HeaderText = "Descripción";
            this.DescProd.Name = "DescProd";
            this.DescProd.Width = 179;
            // 
            // PrecioUnitario
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle6;
            this.PrecioUnitario.FillWeight = 17.13197F;
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 180;
            // 
            // IDProd
            // 
            this.IDProd.HeaderText = "ID";
            this.IDProd.Name = "IDProd";
            this.IDProd.Visible = false;
            // 
            // CodProd
            // 
            this.CodProd.HeaderText = "Código";
            this.CodProd.Name = "CodProd";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // PrecioXUnidad
            // 
            this.PrecioXUnidad.HeaderText = "Precio";
            this.PrecioXUnidad.Name = "PrecioXUnidad";
            // 
            // CantidadProd
            // 
            this.CantidadProd.HeaderText = "Cantidad";
            this.CantidadProd.Name = "CantidadProd";
            // 
            // SubtotalProd
            // 
            this.SubtotalProd.HeaderText = "Subtotal";
            this.SubtotalProd.Name = "SubtotalProd";
            // 
            // formVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(990, 615);
            this.Controls.Add(this.numUpDownDesc);
            this.Controls.Add(this.lbl_FechaHora);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelBtnBuscar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_CuitBuscar);
            this.Controls.Add(this.lbl_CuitBuscar);
            this.Controls.Add(this.lbl_tipoCLiente);
            this.Controls.Add(this.cmbx_TipoCliente);
            this.Controls.Add(this.cmbx_Vendedores);
            this.Controls.Add(this.lbl_Vendedor);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Descuento);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.lbl_SubTotal);
            this.Controls.Add(this.gpbx_DatosArticulo);
            this.Controls.Add(this.gpbx_DatosCliente);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.lbl_GeneraRemito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.formVentas_Load);
            this.gpbx_DatosCliente.ResumeLayout(false);
            this.gpbx_DatosCliente.PerformLayout();
            this.gpbx_DatosArticulo.ResumeLayout(false);
            this.gpbx_DatosArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Arts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Cant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GeneraRemito;
        private System.Windows.Forms.ComboBox cmbx_TipoCliente;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox gpbx_DatosCliente;
        private System.Windows.Forms.Label lbl_NombreRemito;
        private System.Windows.Forms.Label lbl_DirecRemito;
        private System.Windows.Forms.Label lbl_CuitRemito;
        private System.Windows.Forms.Label lbl_EmailRemito;
        private System.Windows.Forms.Label lbl_TelfRemito;
        private System.Windows.Forms.Button btn_CancelarRemito;
        private System.Windows.Forms.Button btn_GuardarRemito;
        private System.Windows.Forms.TextBox txt_DirecRemito;
        private System.Windows.Forms.TextBox txt_EmailRemito;
        private System.Windows.Forms.TextBox txt_CuitRemito;
        private System.Windows.Forms.TextBox txt_TelfRemito;
        private System.Windows.Forms.TextBox txt_NombreRemito;
        private System.Windows.Forms.GroupBox gpbx_DatosArticulo;
        private System.Windows.Forms.Button btn_AgregarArt;
        private System.Windows.Forms.Label lbl_CantArt;
        private System.Windows.Forms.Label lbl_DescArt;
        private System.Windows.Forms.Label lbl_CodigoArt;
        private System.Windows.Forms.Label lbl_SubTotal;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Vendedor;
        private System.Windows.Forms.ComboBox cmbx_Vendedores;
        private System.Windows.Forms.Label lbl_tipoCLiente;
        private System.Windows.Forms.NumericUpDown numUpDown_Cant;
        private System.Windows.Forms.Label lbl_CuitBuscar;
        private System.Windows.Forms.TextBox txt_CuitBuscar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBtnGuardar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelBtnBuscar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_FechaHora;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.Label lbl_ID_Remito;
        private System.Windows.Forms.Label lbl_IDCliente;
        private System.Windows.Forms.ComboBox cmbx_codDescrip;
        private System.Windows.Forms.ComboBox cmbx_codProductos;
        private System.Windows.Forms.Label lbl_PrecioUnidad;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.NumericUpDown numUpDownDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridView dgv_Arts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioXUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalProd;
    }
}