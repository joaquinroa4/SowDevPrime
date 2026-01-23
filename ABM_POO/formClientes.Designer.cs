namespace ABM_POO
{
    partial class formClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formClientes));
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.lbl_ListaClientes = new System.Windows.Forms.Label();
            this.lbl_NombreCliente = new System.Windows.Forms.Label();
            this.lbl_EntidadCliente = new System.Windows.Forms.Label();
            this.lbl_CuitCliente = new System.Windows.Forms.Label();
            this.lbl_EmailCliente = new System.Windows.Forms.Label();
            this.lbl_telfCliente = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.txt_EntidadCliente = new System.Windows.Forms.TextBox();
            this.txt_CuitCliente = new System.Windows.Forms.TextBox();
            this.txt_MailCliente = new System.Windows.Forms.TextBox();
            this.txt_TelfCliente = new System.Windows.Forms.TextBox();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.btn_ModificarCliente = new System.Windows.Forms.Button();
            this.btn_EliminarCliente = new System.Windows.Forms.Button();
            this.lbl_DirecCliente = new System.Windows.Forms.Label();
            this.txt_DirecCliente = new System.Windows.Forms.TextBox();
            this.gpbx_DatosCliente = new System.Windows.Forms.GroupBox();
            this.lbl_IDCliente = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_BorrarCampos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbtn_No = new System.Windows.Forms.RadioButton();
            this.rdbtn_Si = new System.Windows.Forms.RadioButton();
            this.lbl_ActivoCliente = new System.Windows.Forms.Label();
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.gpbx_DatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AllowUserToDeleteRows = false;
            this.dgv_Clientes.AllowUserToResizeColumns = false;
            this.dgv_Clientes.AllowUserToResizeRows = false;
            this.dgv_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clientes.Location = new System.Drawing.Point(23, 396);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.Size = new System.Drawing.Size(942, 207);
            this.dgv_Clientes.TabIndex = 0;
            this.dgv_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clientes_CellClick);
            // 
            // lbl_ListaClientes
            // 
            this.lbl_ListaClientes.AutoSize = true;
            this.lbl_ListaClientes.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaClientes.ForeColor = System.Drawing.Color.White;
            this.lbl_ListaClientes.Location = new System.Drawing.Point(384, 347);
            this.lbl_ListaClientes.Name = "lbl_ListaClientes";
            this.lbl_ListaClientes.Size = new System.Drawing.Size(196, 33);
            this.lbl_ListaClientes.TabIndex = 1;
            this.lbl_ListaClientes.Text = "Lista de Clientes";
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreCliente.Location = new System.Drawing.Point(545, 45);
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(83, 26);
            this.lbl_NombreCliente.TabIndex = 2;
            this.lbl_NombreCliente.Text = "Nombre";
            // 
            // lbl_EntidadCliente
            // 
            this.lbl_EntidadCliente.AutoSize = true;
            this.lbl_EntidadCliente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EntidadCliente.Location = new System.Drawing.Point(309, 45);
            this.lbl_EntidadCliente.Name = "lbl_EntidadCliente";
            this.lbl_EntidadCliente.Size = new System.Drawing.Size(77, 26);
            this.lbl_EntidadCliente.TabIndex = 3;
            this.lbl_EntidadCliente.Text = "Entidad";
            // 
            // lbl_CuitCliente
            // 
            this.lbl_CuitCliente.AutoSize = true;
            this.lbl_CuitCliente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CuitCliente.Location = new System.Drawing.Point(22, 45);
            this.lbl_CuitCliente.Name = "lbl_CuitCliente";
            this.lbl_CuitCliente.Size = new System.Drawing.Size(101, 26);
            this.lbl_CuitCliente.TabIndex = 4;
            this.lbl_CuitCliente.Text = "CUIT/CUIL";
            // 
            // lbl_EmailCliente
            // 
            this.lbl_EmailCliente.AutoSize = true;
            this.lbl_EmailCliente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailCliente.Location = new System.Drawing.Point(23, 106);
            this.lbl_EmailCliente.Name = "lbl_EmailCliente";
            this.lbl_EmailCliente.Size = new System.Drawing.Size(59, 26);
            this.lbl_EmailCliente.TabIndex = 5;
            this.lbl_EmailCliente.Text = "Email";
            // 
            // lbl_telfCliente
            // 
            this.lbl_telfCliente.AutoSize = true;
            this.lbl_telfCliente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telfCliente.Location = new System.Drawing.Point(309, 106);
            this.lbl_telfCliente.Name = "lbl_telfCliente";
            this.lbl_telfCliente.Size = new System.Drawing.Size(87, 26);
            this.lbl_telfCliente.TabIndex = 6;
            this.lbl_telfCliente.Text = "Teléfono";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreCliente.Location = new System.Drawing.Point(550, 72);
            this.txt_NombreCliente.MaxLength = 20;
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(198, 26);
            this.txt_NombreCliente.TabIndex = 3;
            this.txt_NombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreCliente_KeyPress);
            // 
            // txt_EntidadCliente
            // 
            this.txt_EntidadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EntidadCliente.Location = new System.Drawing.Point(314, 72);
            this.txt_EntidadCliente.MaxLength = 50;
            this.txt_EntidadCliente.Name = "txt_EntidadCliente";
            this.txt_EntidadCliente.Size = new System.Drawing.Size(198, 26);
            this.txt_EntidadCliente.TabIndex = 2;
            // 
            // txt_CuitCliente
            // 
            this.txt_CuitCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CuitCliente.Location = new System.Drawing.Point(26, 72);
            this.txt_CuitCliente.MaxLength = 11;
            this.txt_CuitCliente.Name = "txt_CuitCliente";
            this.txt_CuitCliente.Size = new System.Drawing.Size(235, 26);
            this.txt_CuitCliente.TabIndex = 1;
            this.txt_CuitCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CuitCliente_KeyPress);
            // 
            // txt_MailCliente
            // 
            this.txt_MailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MailCliente.Location = new System.Drawing.Point(28, 135);
            this.txt_MailCliente.MaxLength = 30;
            this.txt_MailCliente.Name = "txt_MailCliente";
            this.txt_MailCliente.Size = new System.Drawing.Size(233, 26);
            this.txt_MailCliente.TabIndex = 4;
            this.txt_MailCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MailCliente_Validating);
            // 
            // txt_TelfCliente
            // 
            this.txt_TelfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TelfCliente.Location = new System.Drawing.Point(314, 135);
            this.txt_TelfCliente.MaxLength = 15;
            this.txt_TelfCliente.Name = "txt_TelfCliente";
            this.txt_TelfCliente.Size = new System.Drawing.Size(198, 26);
            this.txt_TelfCliente.TabIndex = 5;
            this.txt_TelfCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TelfCliente_KeyPress);
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.FlatAppearance.BorderSize = 0;
            this.btn_AgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_AgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.btn_AgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarCliente.Location = new System.Drawing.Point(27, 192);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(201, 47);
            this.btn_AgregarCliente.TabIndex = 8;
            this.btn_AgregarCliente.Text = "Agregar Cliente";
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_ModificarCliente
            // 
            this.btn_ModificarCliente.FlatAppearance.BorderSize = 0;
            this.btn_ModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(147)))));
            this.btn_ModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(67)))), ((int)(((byte)(235)))));
            this.btn_ModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarCliente.Location = new System.Drawing.Point(251, 192);
            this.btn_ModificarCliente.Name = "btn_ModificarCliente";
            this.btn_ModificarCliente.Size = new System.Drawing.Size(207, 47);
            this.btn_ModificarCliente.TabIndex = 9;
            this.btn_ModificarCliente.Text = "Modificar Cliente";
            this.btn_ModificarCliente.UseVisualStyleBackColor = true;
            this.btn_ModificarCliente.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btn_EliminarCliente
            // 
            this.btn_EliminarCliente.FlatAppearance.BorderSize = 0;
            this.btn_EliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(24)))), ((int)(((byte)(13)))));
            this.btn_EliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_EliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarCliente.Location = new System.Drawing.Point(476, 192);
            this.btn_EliminarCliente.Name = "btn_EliminarCliente";
            this.btn_EliminarCliente.Size = new System.Drawing.Size(204, 47);
            this.btn_EliminarCliente.TabIndex = 10;
            this.btn_EliminarCliente.Text = "Eliminar Cliente";
            this.btn_EliminarCliente.UseVisualStyleBackColor = true;
            this.btn_EliminarCliente.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbl_DirecCliente
            // 
            this.lbl_DirecCliente.AutoSize = true;
            this.lbl_DirecCliente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DirecCliente.Location = new System.Drawing.Point(545, 106);
            this.lbl_DirecCliente.Name = "lbl_DirecCliente";
            this.lbl_DirecCliente.Size = new System.Drawing.Size(93, 26);
            this.lbl_DirecCliente.TabIndex = 12;
            this.lbl_DirecCliente.Text = "Dirección";
            // 
            // txt_DirecCliente
            // 
            this.txt_DirecCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DirecCliente.Location = new System.Drawing.Point(550, 135);
            this.txt_DirecCliente.MaxLength = 30;
            this.txt_DirecCliente.Name = "txt_DirecCliente";
            this.txt_DirecCliente.Size = new System.Drawing.Size(198, 26);
            this.txt_DirecCliente.TabIndex = 13;
            // 
            // gpbx_DatosCliente
            // 
            this.gpbx_DatosCliente.Controls.Add(this.lbl_IDCliente);
            this.gpbx_DatosCliente.Controls.Add(this.panel4);
            this.gpbx_DatosCliente.Controls.Add(this.btn_BorrarCampos);
            this.gpbx_DatosCliente.Controls.Add(this.panel3);
            this.gpbx_DatosCliente.Controls.Add(this.panel2);
            this.gpbx_DatosCliente.Controls.Add(this.panel1);
            this.gpbx_DatosCliente.Controls.Add(this.rdbtn_No);
            this.gpbx_DatosCliente.Controls.Add(this.rdbtn_Si);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_ActivoCliente);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_EntidadCliente);
            this.gpbx_DatosCliente.Controls.Add(this.txt_DirecCliente);
            this.gpbx_DatosCliente.Controls.Add(this.btn_EliminarCliente);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_DirecCliente);
            this.gpbx_DatosCliente.Controls.Add(this.btn_ModificarCliente);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_NombreCliente);
            this.gpbx_DatosCliente.Controls.Add(this.btn_AgregarCliente);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_CuitCliente);
            this.gpbx_DatosCliente.Controls.Add(this.txt_NombreCliente);
            this.gpbx_DatosCliente.Controls.Add(this.txt_EntidadCliente);
            this.gpbx_DatosCliente.Controls.Add(this.txt_CuitCliente);
            this.gpbx_DatosCliente.Controls.Add(this.txt_TelfCliente);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_EmailCliente);
            this.gpbx_DatosCliente.Controls.Add(this.txt_MailCliente);
            this.gpbx_DatosCliente.Controls.Add(this.lbl_telfCliente);
            this.gpbx_DatosCliente.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbx_DatosCliente.ForeColor = System.Drawing.Color.White;
            this.gpbx_DatosCliente.Location = new System.Drawing.Point(27, 64);
            this.gpbx_DatosCliente.Name = "gpbx_DatosCliente";
            this.gpbx_DatosCliente.Size = new System.Drawing.Size(938, 265);
            this.gpbx_DatosCliente.TabIndex = 14;
            this.gpbx_DatosCliente.TabStop = false;
            this.gpbx_DatosCliente.Text = "Datos del Cliente";
            // 
            // lbl_IDCliente
            // 
            this.lbl_IDCliente.AutoSize = true;
            this.lbl_IDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDCliente.Location = new System.Drawing.Point(174, 45);
            this.lbl_IDCliente.Name = "lbl_IDCliente";
            this.lbl_IDCliente.Size = new System.Drawing.Size(0, 20);
            this.lbl_IDCliente.TabIndex = 16;
            this.lbl_IDCliente.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(707, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 47);
            this.panel4.TabIndex = 54;
            // 
            // btn_BorrarCampos
            // 
            this.btn_BorrarCampos.FlatAppearance.BorderSize = 0;
            this.btn_BorrarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_BorrarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_BorrarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrarCampos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BorrarCampos.Location = new System.Drawing.Point(710, 192);
            this.btn_BorrarCampos.Name = "btn_BorrarCampos";
            this.btn_BorrarCampos.Size = new System.Drawing.Size(204, 47);
            this.btn_BorrarCampos.TabIndex = 53;
            this.btn_BorrarCampos.Text = "Borrar Campos";
            this.btn_BorrarCampos.UseVisualStyleBackColor = true;
            this.btn_BorrarCampos.Click += new System.EventHandler(this.btn_BorrarCampos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(67)))), ((int)(((byte)(235)))));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(248, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 47);
            this.panel3.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(473, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 47);
            this.panel2.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 47);
            this.panel1.TabIndex = 50;
            // 
            // rdbtn_No
            // 
            this.rdbtn_No.AutoSize = true;
            this.rdbtn_No.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_No.Location = new System.Drawing.Point(859, 105);
            this.rdbtn_No.Name = "rdbtn_No";
            this.rdbtn_No.Size = new System.Drawing.Size(55, 30);
            this.rdbtn_No.TabIndex = 16;
            this.rdbtn_No.TabStop = true;
            this.rdbtn_No.Text = "No";
            this.rdbtn_No.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Si
            // 
            this.rdbtn_Si.AutoSize = true;
            this.rdbtn_Si.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Si.Location = new System.Drawing.Point(783, 105);
            this.rdbtn_Si.Name = "rdbtn_Si";
            this.rdbtn_Si.Size = new System.Drawing.Size(45, 30);
            this.rdbtn_Si.TabIndex = 15;
            this.rdbtn_Si.TabStop = true;
            this.rdbtn_Si.Text = "Sí";
            this.rdbtn_Si.UseVisualStyleBackColor = true;
            // 
            // lbl_ActivoCliente
            // 
            this.lbl_ActivoCliente.AutoSize = true;
            this.lbl_ActivoCliente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ActivoCliente.Location = new System.Drawing.Point(806, 45);
            this.lbl_ActivoCliente.Name = "lbl_ActivoCliente";
            this.lbl_ActivoCliente.Size = new System.Drawing.Size(67, 26);
            this.lbl_ActivoCliente.TabIndex = 14;
            this.lbl_ActivoCliente.Text = "Activo";
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clientes.ForeColor = System.Drawing.Color.White;
            this.lbl_Clientes.Location = new System.Drawing.Point(420, 9);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(125, 36);
            this.lbl_Clientes.TabIndex = 15;
            this.lbl_Clientes.Text = "CLIENTES";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(966, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 16;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(990, 615);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lbl_Clientes);
            this.Controls.Add(this.gpbx_DatosCliente);
            this.Controls.Add(this.lbl_ListaClientes);
            this.Controls.Add(this.dgv_Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.formClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.gpbx_DatosCliente.ResumeLayout(false);
            this.gpbx_DatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Clientes;
        private System.Windows.Forms.Label lbl_ListaClientes;
        private System.Windows.Forms.Label lbl_NombreCliente;
        private System.Windows.Forms.Label lbl_EntidadCliente;
        private System.Windows.Forms.Label lbl_CuitCliente;
        private System.Windows.Forms.Label lbl_EmailCliente;
        private System.Windows.Forms.Label lbl_telfCliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.TextBox txt_EntidadCliente;
        private System.Windows.Forms.TextBox txt_CuitCliente;
        private System.Windows.Forms.TextBox txt_MailCliente;
        private System.Windows.Forms.TextBox txt_TelfCliente;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Button btn_ModificarCliente;
        private System.Windows.Forms.Button btn_EliminarCliente;
        private System.Windows.Forms.Label lbl_DirecCliente;
        private System.Windows.Forms.TextBox txt_DirecCliente;
        private System.Windows.Forms.GroupBox gpbx_DatosCliente;
        private System.Windows.Forms.RadioButton rdbtn_No;
        private System.Windows.Forms.RadioButton rdbtn_Si;
        private System.Windows.Forms.Label lbl_ActivoCliente;
        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_BorrarCampos;
        private System.Windows.Forms.Label lbl_IDCliente;
        private System.Windows.Forms.PictureBox btn_Cerrar;
    }
}