namespace ABM_POO
{
    partial class formCompras
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
            this.lbl_Compras = new System.Windows.Forms.Label();
            this.gpbx_DatosProov = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBtnGuardar = new System.Windows.Forms.Panel();
            this.btn_CancelarRemito = new System.Windows.Forms.Button();
            this.btn_GuardarRemito = new System.Windows.Forms.Button();
            this.txt_DirecProov = new System.Windows.Forms.TextBox();
            this.txt_EmailProov = new System.Windows.Forms.TextBox();
            this.txt_CuitProov = new System.Windows.Forms.TextBox();
            this.txt_TelfProov = new System.Windows.Forms.TextBox();
            this.txt_NombreProov = new System.Windows.Forms.TextBox();
            this.lbl_DirecProov = new System.Windows.Forms.Label();
            this.lbl_CuitProov = new System.Windows.Forms.Label();
            this.lbl_EmailProov = new System.Windows.Forms.Label();
            this.lbl_TelfProov = new System.Windows.Forms.Label();
            this.lbl_NombreProov = new System.Windows.Forms.Label();
            this.lbl_TipoProov = new System.Windows.Forms.Label();
            this.cmbx_TipoProov = new System.Windows.Forms.ComboBox();
            this.panelBtnBuscar = new System.Windows.Forms.Panel();
            this.txt_CuitBuscar = new System.Windows.Forms.TextBox();
            this.lbl_CuitBuscar = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.gpbx_DatosCompra = new System.Windows.Forms.GroupBox();
            this.dgv_Arts = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_AgregarArt = new System.Windows.Forms.Button();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.numUpDownCant = new System.Windows.Forms.NumericUpDown();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_CantCompra = new System.Windows.Forms.Label();
            this.txt_DescProd = new System.Windows.Forms.TextBox();
            this.lbl_DescCompra = new System.Windows.Forms.Label();
            this.txt_CodProd = new System.Windows.Forms.TextBox();
            this.lbl_CodCompra = new System.Windows.Forms.Label();
            this.lbl_FechaHora = new System.Windows.Forms.Label();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.lbl_Comprador = new System.Windows.Forms.Label();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lbl_TotalCompra = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gpbx_DatosProov.SuspendLayout();
            this.gpbx_DatosCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Arts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Compras
            // 
            this.lbl_Compras.AutoSize = true;
            this.lbl_Compras.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Compras.ForeColor = System.Drawing.Color.White;
            this.lbl_Compras.Location = new System.Drawing.Point(441, 9);
            this.lbl_Compras.Name = "lbl_Compras";
            this.lbl_Compras.Size = new System.Drawing.Size(138, 36);
            this.lbl_Compras.TabIndex = 0;
            this.lbl_Compras.Text = "COMPRAS";
            // 
            // gpbx_DatosProov
            // 
            this.gpbx_DatosProov.Controls.Add(this.panel2);
            this.gpbx_DatosProov.Controls.Add(this.panelBtnGuardar);
            this.gpbx_DatosProov.Controls.Add(this.btn_CancelarRemito);
            this.gpbx_DatosProov.Controls.Add(this.btn_GuardarRemito);
            this.gpbx_DatosProov.Controls.Add(this.txt_DirecProov);
            this.gpbx_DatosProov.Controls.Add(this.txt_EmailProov);
            this.gpbx_DatosProov.Controls.Add(this.txt_CuitProov);
            this.gpbx_DatosProov.Controls.Add(this.txt_TelfProov);
            this.gpbx_DatosProov.Controls.Add(this.txt_NombreProov);
            this.gpbx_DatosProov.Controls.Add(this.lbl_DirecProov);
            this.gpbx_DatosProov.Controls.Add(this.lbl_CuitProov);
            this.gpbx_DatosProov.Controls.Add(this.lbl_EmailProov);
            this.gpbx_DatosProov.Controls.Add(this.lbl_TelfProov);
            this.gpbx_DatosProov.Controls.Add(this.lbl_NombreProov);
            this.gpbx_DatosProov.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbx_DatosProov.ForeColor = System.Drawing.Color.White;
            this.gpbx_DatosProov.Location = new System.Drawing.Point(12, 115);
            this.gpbx_DatosProov.Name = "gpbx_DatosProov";
            this.gpbx_DatosProov.Size = new System.Drawing.Size(955, 155);
            this.gpbx_DatosProov.TabIndex = 1;
            this.gpbx_DatosProov.TabStop = false;
            this.gpbx_DatosProov.Text = "Datos del Proovedor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(813, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 30);
            this.panel2.TabIndex = 30;
            // 
            // panelBtnGuardar
            // 
            this.panelBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.panelBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.panelBtnGuardar.Location = new System.Drawing.Point(674, 109);
            this.panelBtnGuardar.Name = "panelBtnGuardar";
            this.panelBtnGuardar.Size = new System.Drawing.Size(5, 30);
            this.panelBtnGuardar.TabIndex = 29;
            // 
            // btn_CancelarRemito
            // 
            this.btn_CancelarRemito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarRemito.FlatAppearance.BorderSize = 0;
            this.btn_CancelarRemito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(24)))), ((int)(((byte)(13)))));
            this.btn_CancelarRemito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_CancelarRemito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarRemito.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarRemito.Location = new System.Drawing.Point(816, 109);
            this.btn_CancelarRemito.Name = "btn_CancelarRemito";
            this.btn_CancelarRemito.Size = new System.Drawing.Size(124, 30);
            this.btn_CancelarRemito.TabIndex = 28;
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
            this.btn_GuardarRemito.Location = new System.Drawing.Point(677, 109);
            this.btn_GuardarRemito.Name = "btn_GuardarRemito";
            this.btn_GuardarRemito.Size = new System.Drawing.Size(124, 30);
            this.btn_GuardarRemito.TabIndex = 27;
            this.btn_GuardarRemito.Text = "Guardar";
            this.btn_GuardarRemito.UseVisualStyleBackColor = true;
            this.btn_GuardarRemito.Click += new System.EventHandler(this.btn_GuardarRemito_Click);
            // 
            // txt_DirecProov
            // 
            this.txt_DirecProov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DirecProov.Location = new System.Drawing.Point(336, 111);
            this.txt_DirecProov.Name = "txt_DirecProov";
            this.txt_DirecProov.Size = new System.Drawing.Size(325, 26);
            this.txt_DirecProov.TabIndex = 26;
            // 
            // txt_EmailProov
            // 
            this.txt_EmailProov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailProov.Location = new System.Drawing.Point(24, 111);
            this.txt_EmailProov.Name = "txt_EmailProov";
            this.txt_EmailProov.Size = new System.Drawing.Size(289, 26);
            this.txt_EmailProov.TabIndex = 25;
            // 
            // txt_CuitProov
            // 
            this.txt_CuitProov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CuitProov.Location = new System.Drawing.Point(677, 56);
            this.txt_CuitProov.Name = "txt_CuitProov";
            this.txt_CuitProov.Size = new System.Drawing.Size(258, 26);
            this.txt_CuitProov.TabIndex = 24;
            // 
            // txt_TelfProov
            // 
            this.txt_TelfProov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelfProov.Location = new System.Drawing.Point(336, 56);
            this.txt_TelfProov.Name = "txt_TelfProov";
            this.txt_TelfProov.Size = new System.Drawing.Size(325, 26);
            this.txt_TelfProov.TabIndex = 23;
            // 
            // txt_NombreProov
            // 
            this.txt_NombreProov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreProov.Location = new System.Drawing.Point(24, 56);
            this.txt_NombreProov.Name = "txt_NombreProov";
            this.txt_NombreProov.Size = new System.Drawing.Size(289, 26);
            this.txt_NombreProov.TabIndex = 22;
            // 
            // lbl_DirecProov
            // 
            this.lbl_DirecProov.AutoSize = true;
            this.lbl_DirecProov.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DirecProov.Location = new System.Drawing.Point(331, 86);
            this.lbl_DirecProov.Name = "lbl_DirecProov";
            this.lbl_DirecProov.Size = new System.Drawing.Size(93, 26);
            this.lbl_DirecProov.TabIndex = 21;
            this.lbl_DirecProov.Text = "Dirección";
            // 
            // lbl_CuitProov
            // 
            this.lbl_CuitProov.AutoSize = true;
            this.lbl_CuitProov.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CuitProov.Location = new System.Drawing.Point(672, 27);
            this.lbl_CuitProov.Name = "lbl_CuitProov";
            this.lbl_CuitProov.Size = new System.Drawing.Size(53, 26);
            this.lbl_CuitProov.TabIndex = 20;
            this.lbl_CuitProov.Text = "CUIT";
            // 
            // lbl_EmailProov
            // 
            this.lbl_EmailProov.AutoSize = true;
            this.lbl_EmailProov.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailProov.Location = new System.Drawing.Point(19, 85);
            this.lbl_EmailProov.Name = "lbl_EmailProov";
            this.lbl_EmailProov.Size = new System.Drawing.Size(59, 26);
            this.lbl_EmailProov.TabIndex = 19;
            this.lbl_EmailProov.Text = "Email";
            // 
            // lbl_TelfProov
            // 
            this.lbl_TelfProov.AutoSize = true;
            this.lbl_TelfProov.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TelfProov.Location = new System.Drawing.Point(331, 30);
            this.lbl_TelfProov.Name = "lbl_TelfProov";
            this.lbl_TelfProov.Size = new System.Drawing.Size(87, 26);
            this.lbl_TelfProov.TabIndex = 18;
            this.lbl_TelfProov.Text = "Teléfono";
            // 
            // lbl_NombreProov
            // 
            this.lbl_NombreProov.AutoSize = true;
            this.lbl_NombreProov.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreProov.Location = new System.Drawing.Point(19, 30);
            this.lbl_NombreProov.Name = "lbl_NombreProov";
            this.lbl_NombreProov.Size = new System.Drawing.Size(83, 26);
            this.lbl_NombreProov.TabIndex = 17;
            this.lbl_NombreProov.Text = "Nombre";
            // 
            // lbl_TipoProov
            // 
            this.lbl_TipoProov.AutoSize = true;
            this.lbl_TipoProov.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoProov.ForeColor = System.Drawing.Color.White;
            this.lbl_TipoProov.Location = new System.Drawing.Point(41, 52);
            this.lbl_TipoProov.Name = "lbl_TipoProov";
            this.lbl_TipoProov.Size = new System.Drawing.Size(171, 26);
            this.lbl_TipoProov.TabIndex = 2;
            this.lbl_TipoProov.Text = "Tipo de Proovedor";
            // 
            // cmbx_TipoProov
            // 
            this.cmbx_TipoProov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_TipoProov.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_TipoProov.FormattingEnabled = true;
            this.cmbx_TipoProov.Items.AddRange(new object[] {
            "Proovedor Nuevo",
            "Proovedor Existente"});
            this.cmbx_TipoProov.Location = new System.Drawing.Point(46, 81);
            this.cmbx_TipoProov.Name = "cmbx_TipoProov";
            this.cmbx_TipoProov.Size = new System.Drawing.Size(234, 27);
            this.cmbx_TipoProov.TabIndex = 3;
            this.cmbx_TipoProov.SelectedIndexChanged += new System.EventHandler(this.cmbx_TipoProov_SelectedIndexChanged);
            // 
            // panelBtnBuscar
            // 
            this.panelBtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.panelBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.panelBtnBuscar.Location = new System.Drawing.Point(748, 77);
            this.panelBtnBuscar.Name = "panelBtnBuscar";
            this.panelBtnBuscar.Size = new System.Drawing.Size(5, 30);
            this.panelBtnBuscar.TabIndex = 30;
            this.panelBtnBuscar.Visible = false;
            // 
            // txt_CuitBuscar
            // 
            this.txt_CuitBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_CuitBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CuitBuscar.Location = new System.Drawing.Point(393, 79);
            this.txt_CuitBuscar.Name = "txt_CuitBuscar";
            this.txt_CuitBuscar.Size = new System.Drawing.Size(323, 26);
            this.txt_CuitBuscar.TabIndex = 29;
            this.txt_CuitBuscar.Visible = false;
            // 
            // lbl_CuitBuscar
            // 
            this.lbl_CuitBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CuitBuscar.AutoSize = true;
            this.lbl_CuitBuscar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CuitBuscar.ForeColor = System.Drawing.Color.White;
            this.lbl_CuitBuscar.Location = new System.Drawing.Point(334, 78);
            this.lbl_CuitBuscar.Name = "lbl_CuitBuscar";
            this.lbl_CuitBuscar.Size = new System.Drawing.Size(53, 26);
            this.lbl_CuitBuscar.TabIndex = 28;
            this.lbl_CuitBuscar.Text = "CUIT";
            this.lbl_CuitBuscar.Visible = false;
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
            this.btn_Buscar.Location = new System.Drawing.Point(751, 77);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(120, 30);
            this.btn_Buscar.TabIndex = 27;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Visible = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // gpbx_DatosCompra
            // 
            this.gpbx_DatosCompra.Controls.Add(this.dgv_Arts);
            this.gpbx_DatosCompra.Controls.Add(this.panel5);
            this.gpbx_DatosCompra.Controls.Add(this.btn_AgregarArt);
            this.gpbx_DatosCompra.Controls.Add(this.txt_Precio);
            this.gpbx_DatosCompra.Controls.Add(this.numUpDownCant);
            this.gpbx_DatosCompra.Controls.Add(this.lbl_Precio);
            this.gpbx_DatosCompra.Controls.Add(this.lbl_CantCompra);
            this.gpbx_DatosCompra.Controls.Add(this.txt_DescProd);
            this.gpbx_DatosCompra.Controls.Add(this.lbl_DescCompra);
            this.gpbx_DatosCompra.Controls.Add(this.txt_CodProd);
            this.gpbx_DatosCompra.Controls.Add(this.lbl_CodCompra);
            this.gpbx_DatosCompra.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbx_DatosCompra.ForeColor = System.Drawing.Color.White;
            this.gpbx_DatosCompra.Location = new System.Drawing.Point(12, 276);
            this.gpbx_DatosCompra.Name = "gpbx_DatosCompra";
            this.gpbx_DatosCompra.Size = new System.Drawing.Size(954, 199);
            this.gpbx_DatosCompra.TabIndex = 31;
            this.gpbx_DatosCompra.TabStop = false;
            this.gpbx_DatosCompra.Text = " ";
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
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Subtotal});
            this.dgv_Arts.Location = new System.Drawing.Point(15, 91);
            this.dgv_Arts.Name = "dgv_Arts";
            this.dgv_Arts.Size = new System.Drawing.Size(921, 103);
            this.dgv_Arts.TabIndex = 33;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(809, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 30);
            this.panel5.TabIndex = 32;
            // 
            // btn_AgregarArt
            // 
            this.btn_AgregarArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarArt.FlatAppearance.BorderSize = 0;
            this.btn_AgregarArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.btn_AgregarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarArt.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarArt.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarArt.Location = new System.Drawing.Point(812, 53);
            this.btn_AgregarArt.Name = "btn_AgregarArt";
            this.btn_AgregarArt.Size = new System.Drawing.Size(124, 30);
            this.btn_AgregarArt.TabIndex = 31;
            this.btn_AgregarArt.Text = "Agregar";
            this.btn_AgregarArt.UseVisualStyleBackColor = true;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio.Location = new System.Drawing.Point(599, 58);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(192, 26);
            this.txt_Precio.TabIndex = 30;
            // 
            // numUpDownCant
            // 
            this.numUpDownCant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownCant.Location = new System.Drawing.Point(461, 58);
            this.numUpDownCant.Name = "numUpDownCant";
            this.numUpDownCant.Size = new System.Drawing.Size(124, 27);
            this.numUpDownCant.TabIndex = 29;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(594, 29);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(141, 26);
            this.lbl_Precio.TabIndex = 28;
            this.lbl_Precio.Text = "Precio Unitario";
            // 
            // lbl_CantCompra
            // 
            this.lbl_CantCompra.AutoSize = true;
            this.lbl_CantCompra.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CantCompra.Location = new System.Drawing.Point(456, 28);
            this.lbl_CantCompra.Name = "lbl_CantCompra";
            this.lbl_CantCompra.Size = new System.Drawing.Size(88, 26);
            this.lbl_CantCompra.TabIndex = 27;
            this.lbl_CantCompra.Text = "Cantidad";
            // 
            // txt_DescProd
            // 
            this.txt_DescProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescProd.Location = new System.Drawing.Point(239, 58);
            this.txt_DescProd.Name = "txt_DescProd";
            this.txt_DescProd.Size = new System.Drawing.Size(204, 26);
            this.txt_DescProd.TabIndex = 26;
            // 
            // lbl_DescCompra
            // 
            this.lbl_DescCompra.AutoSize = true;
            this.lbl_DescCompra.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescCompra.Location = new System.Drawing.Point(234, 29);
            this.lbl_DescCompra.Name = "lbl_DescCompra";
            this.lbl_DescCompra.Size = new System.Drawing.Size(112, 26);
            this.lbl_DescCompra.TabIndex = 24;
            this.lbl_DescCompra.Text = "Descripción";
            // 
            // txt_CodProd
            // 
            this.txt_CodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodProd.Location = new System.Drawing.Point(18, 58);
            this.txt_CodProd.Name = "txt_CodProd";
            this.txt_CodProd.Size = new System.Drawing.Size(206, 26);
            this.txt_CodProd.TabIndex = 23;
            // 
            // lbl_CodCompra
            // 
            this.lbl_CodCompra.AutoSize = true;
            this.lbl_CodCompra.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodCompra.Location = new System.Drawing.Point(13, 28);
            this.lbl_CodCompra.Name = "lbl_CodCompra";
            this.lbl_CodCompra.Size = new System.Drawing.Size(71, 26);
            this.lbl_CodCompra.TabIndex = 20;
            this.lbl_CodCompra.Text = "Código";
            // 
            // lbl_FechaHora
            // 
            this.lbl_FechaHora.AutoSize = true;
            this.lbl_FechaHora.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaHora.ForeColor = System.Drawing.Color.White;
            this.lbl_FechaHora.Location = new System.Drawing.Point(795, 17);
            this.lbl_FechaHora.Name = "lbl_FechaHora";
            this.lbl_FechaHora.Size = new System.Drawing.Size(0, 26);
            this.lbl_FechaHora.TabIndex = 32;
            // 
            // tmrFechaHora
            // 
            this.tmrFechaHora.Tick += new System.EventHandler(this.tmrFechaHora_Tick);
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtotal.ForeColor = System.Drawing.Color.White;
            this.lbl_Subtotal.Location = new System.Drawing.Point(51, 490);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(84, 26);
            this.lbl_Subtotal.TabIndex = 29;
            this.lbl_Subtotal.Text = "Subtotal";
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descuento.ForeColor = System.Drawing.Color.White;
            this.lbl_Descuento.Location = new System.Drawing.Point(246, 490);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(104, 26);
            this.lbl_Descuento.TabIndex = 33;
            this.lbl_Descuento.Text = "Descuento";
            // 
            // lbl_Comprador
            // 
            this.lbl_Comprador.AutoSize = true;
            this.lbl_Comprador.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comprador.ForeColor = System.Drawing.Color.White;
            this.lbl_Comprador.Location = new System.Drawing.Point(460, 490);
            this.lbl_Comprador.Name = "lbl_Comprador";
            this.lbl_Comprador.Size = new System.Drawing.Size(108, 26);
            this.lbl_Comprador.TabIndex = 34;
            this.lbl_Comprador.Text = "Comprador";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subtotal.Location = new System.Drawing.Point(56, 519);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.Size = new System.Drawing.Size(168, 26);
            this.txt_Subtotal.TabIndex = 35;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(465, 519);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 27);
            this.comboBox3.TabIndex = 37;
            // 
            // lbl_TotalCompra
            // 
            this.lbl_TotalCompra.AutoSize = true;
            this.lbl_TotalCompra.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalCompra.ForeColor = System.Drawing.Color.White;
            this.lbl_TotalCompra.Location = new System.Drawing.Point(673, 505);
            this.lbl_TotalCompra.Name = "lbl_TotalCompra";
            this.lbl_TotalCompra.Size = new System.Drawing.Size(74, 29);
            this.lbl_TotalCompra.TabIndex = 38;
            this.lbl_TotalCompra.Text = "Total: ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(824, 562);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 30);
            this.panel7.TabIndex = 42;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(678, 562);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 30);
            this.panel6.TabIndex = 41;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(827, 562);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(124, 30);
            this.btn_Cancelar.TabIndex = 40;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
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
            this.btn_Guardar.Location = new System.Drawing.Point(681, 562);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(124, 30);
            this.btn_Guardar.TabIndex = 39;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(251, 520);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(183, 27);
            this.numericUpDown1.TabIndex = 43;
            // 
            // formCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(990, 615);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lbl_TotalCompra);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.lbl_Comprador);
            this.Controls.Add(this.lbl_Descuento);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.lbl_FechaHora);
            this.Controls.Add(this.gpbx_DatosCompra);
            this.Controls.Add(this.panelBtnBuscar);
            this.Controls.Add(this.txt_CuitBuscar);
            this.Controls.Add(this.lbl_CuitBuscar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.cmbx_TipoProov);
            this.Controls.Add(this.lbl_TipoProov);
            this.Controls.Add(this.gpbx_DatosProov);
            this.Controls.Add(this.lbl_Compras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCompras";
            this.Text = "formCompras";
            this.Load += new System.EventHandler(this.formCompras_Load);
            this.gpbx_DatosProov.ResumeLayout(false);
            this.gpbx_DatosProov.PerformLayout();
            this.gpbx_DatosCompra.ResumeLayout(false);
            this.gpbx_DatosCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Arts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Compras;
        private System.Windows.Forms.GroupBox gpbx_DatosProov;
        private System.Windows.Forms.Label lbl_TipoProov;
        private System.Windows.Forms.ComboBox cmbx_TipoProov;
        private System.Windows.Forms.Panel panelBtnBuscar;
        private System.Windows.Forms.TextBox txt_CuitBuscar;
        private System.Windows.Forms.Label lbl_CuitBuscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBtnGuardar;
        private System.Windows.Forms.Button btn_CancelarRemito;
        private System.Windows.Forms.Button btn_GuardarRemito;
        private System.Windows.Forms.TextBox txt_DirecProov;
        private System.Windows.Forms.TextBox txt_EmailProov;
        private System.Windows.Forms.TextBox txt_CuitProov;
        private System.Windows.Forms.TextBox txt_TelfProov;
        private System.Windows.Forms.TextBox txt_NombreProov;
        private System.Windows.Forms.Label lbl_DirecProov;
        private System.Windows.Forms.Label lbl_CuitProov;
        private System.Windows.Forms.Label lbl_EmailProov;
        private System.Windows.Forms.Label lbl_TelfProov;
        private System.Windows.Forms.Label lbl_NombreProov;
        private System.Windows.Forms.GroupBox gpbx_DatosCompra;
        private System.Windows.Forms.Label lbl_FechaHora;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.Label lbl_CodCompra;
        private System.Windows.Forms.TextBox txt_DescProd;
        private System.Windows.Forms.Label lbl_DescCompra;
        private System.Windows.Forms.TextBox txt_CodProd;
        private System.Windows.Forms.NumericUpDown numUpDownCant;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_CantCompra;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.Label lbl_Comprador;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lbl_TotalCompra;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_AgregarArt;
        private System.Windows.Forms.DataGridView dgv_Arts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}