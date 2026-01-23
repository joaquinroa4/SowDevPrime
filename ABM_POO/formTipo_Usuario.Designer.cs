namespace ABM_POO
{
    partial class formTipo_Usuario
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
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.txt_AgregaEditaRol = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_EliminarRol = new System.Windows.Forms.Button();
            this.btn_ModificarRol = new System.Windows.Forms.Button();
            this.panelBtnGuardar = new System.Windows.Forms.Panel();
            this.btn_AgregarRol = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SalirRol = new System.Windows.Forms.Button();
            this.lbl_RolDisponible = new System.Windows.Forms.Label();
            this.cmbx_Roles = new System.Windows.Forms.ComboBox();
            this.lbl_AgregarEditarRol = new System.Windows.Forms.Label();
            this.lbl_ID_UsuarioTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rol.ForeColor = System.Drawing.Color.White;
            this.lbl_Rol.Location = new System.Drawing.Point(216, 28);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(91, 36);
            this.lbl_Rol.TabIndex = 0;
            this.lbl_Rol.Text = "ROLES";
            // 
            // txt_AgregaEditaRol
            // 
            this.txt_AgregaEditaRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AgregaEditaRol.Location = new System.Drawing.Point(33, 136);
            this.txt_AgregaEditaRol.MaxLength = 30;
            this.txt_AgregaEditaRol.Name = "txt_AgregaEditaRol";
            this.txt_AgregaEditaRol.Size = new System.Drawing.Size(443, 26);
            this.txt_AgregaEditaRol.TabIndex = 4;
            this.txt_AgregaEditaRol.TextChanged += new System.EventHandler(this.txt_AgregaEditaRol_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(67)))), ((int)(((byte)(235)))));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(195, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 41);
            this.panel3.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(369, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 41);
            this.panel1.TabIndex = 68;
            // 
            // btn_EliminarRol
            // 
            this.btn_EliminarRol.FlatAppearance.BorderSize = 0;
            this.btn_EliminarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(24)))), ((int)(((byte)(13)))));
            this.btn_EliminarRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_EliminarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarRol.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarRol.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarRol.Location = new System.Drawing.Point(372, 263);
            this.btn_EliminarRol.Name = "btn_EliminarRol";
            this.btn_EliminarRol.Size = new System.Drawing.Size(140, 41);
            this.btn_EliminarRol.TabIndex = 67;
            this.btn_EliminarRol.Text = "Eliminar ";
            this.btn_EliminarRol.UseVisualStyleBackColor = true;
            this.btn_EliminarRol.Click += new System.EventHandler(this.btn_EliminarRol_Click);
            // 
            // btn_ModificarRol
            // 
            this.btn_ModificarRol.FlatAppearance.BorderSize = 0;
            this.btn_ModificarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(147)))));
            this.btn_ModificarRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(67)))), ((int)(((byte)(235)))));
            this.btn_ModificarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarRol.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarRol.ForeColor = System.Drawing.Color.White;
            this.btn_ModificarRol.Location = new System.Drawing.Point(198, 262);
            this.btn_ModificarRol.Name = "btn_ModificarRol";
            this.btn_ModificarRol.Size = new System.Drawing.Size(140, 41);
            this.btn_ModificarRol.TabIndex = 66;
            this.btn_ModificarRol.Text = "Modificar";
            this.btn_ModificarRol.UseVisualStyleBackColor = true;
            this.btn_ModificarRol.Click += new System.EventHandler(this.btn_ModificarRol_Click);
            // 
            // panelBtnGuardar
            // 
            this.panelBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.panelBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.panelBtnGuardar.Location = new System.Drawing.Point(30, 263);
            this.panelBtnGuardar.Name = "panelBtnGuardar";
            this.panelBtnGuardar.Size = new System.Drawing.Size(5, 41);
            this.panelBtnGuardar.TabIndex = 65;
            // 
            // btn_AgregarRol
            // 
            this.btn_AgregarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarRol.FlatAppearance.BorderSize = 0;
            this.btn_AgregarRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_AgregarRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.btn_AgregarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarRol.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarRol.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarRol.Location = new System.Drawing.Point(33, 263);
            this.btn_AgregarRol.Name = "btn_AgregarRol";
            this.btn_AgregarRol.Size = new System.Drawing.Size(140, 41);
            this.btn_AgregarRol.TabIndex = 64;
            this.btn_AgregarRol.Text = "Agregar";
            this.btn_AgregarRol.UseVisualStyleBackColor = true;
            this.btn_AgregarRol.Click += new System.EventHandler(this.btn_AgregarRol_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(366, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 43);
            this.panel2.TabIndex = 71;
            // 
            // btn_SalirRol
            // 
            this.btn_SalirRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SalirRol.FlatAppearance.BorderSize = 0;
            this.btn_SalirRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_SalirRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_SalirRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirRol.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirRol.ForeColor = System.Drawing.Color.White;
            this.btn_SalirRol.Location = new System.Drawing.Point(369, 341);
            this.btn_SalirRol.Name = "btn_SalirRol";
            this.btn_SalirRol.Size = new System.Drawing.Size(140, 43);
            this.btn_SalirRol.TabIndex = 70;
            this.btn_SalirRol.Text = "Salir";
            this.btn_SalirRol.UseVisualStyleBackColor = true;
            this.btn_SalirRol.Click += new System.EventHandler(this.btn_SalirRol_Click);
            // 
            // lbl_RolDisponible
            // 
            this.lbl_RolDisponible.AutoSize = true;
            this.lbl_RolDisponible.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RolDisponible.ForeColor = System.Drawing.Color.White;
            this.lbl_RolDisponible.Location = new System.Drawing.Point(28, 170);
            this.lbl_RolDisponible.Name = "lbl_RolDisponible";
            this.lbl_RolDisponible.Size = new System.Drawing.Size(190, 29);
            this.lbl_RolDisponible.TabIndex = 1;
            this.lbl_RolDisponible.Text = "Roles Disponibles";
            // 
            // cmbx_Roles
            // 
            this.cmbx_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Roles.FormattingEnabled = true;
            this.cmbx_Roles.Location = new System.Drawing.Point(33, 202);
            this.cmbx_Roles.Name = "cmbx_Roles";
            this.cmbx_Roles.Size = new System.Drawing.Size(330, 28);
            this.cmbx_Roles.TabIndex = 2;
            this.cmbx_Roles.SelectedIndexChanged += new System.EventHandler(this.cmbx_Roles_SelectedIndexChanged);
            // 
            // lbl_AgregarEditarRol
            // 
            this.lbl_AgregarEditarRol.AutoSize = true;
            this.lbl_AgregarEditarRol.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AgregarEditarRol.ForeColor = System.Drawing.Color.White;
            this.lbl_AgregarEditarRol.Location = new System.Drawing.Point(28, 104);
            this.lbl_AgregarEditarRol.Name = "lbl_AgregarEditarRol";
            this.lbl_AgregarEditarRol.Size = new System.Drawing.Size(200, 29);
            this.lbl_AgregarEditarRol.TabIndex = 3;
            this.lbl_AgregarEditarRol.Text = "Agregar/Editar Rol";
            // 
            // lbl_ID_UsuarioTipo
            // 
            this.lbl_ID_UsuarioTipo.AutoSize = true;
            this.lbl_ID_UsuarioTipo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_UsuarioTipo.ForeColor = System.Drawing.Color.White;
            this.lbl_ID_UsuarioTipo.Location = new System.Drawing.Point(476, 28);
            this.lbl_ID_UsuarioTipo.Name = "lbl_ID_UsuarioTipo";
            this.lbl_ID_UsuarioTipo.Size = new System.Drawing.Size(0, 29);
            this.lbl_ID_UsuarioTipo.TabIndex = 72;
            this.lbl_ID_UsuarioTipo.Visible = false;
            // 
            // formTipo_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(555, 408);
            this.Controls.Add(this.lbl_ID_UsuarioTipo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_SalirRol);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_EliminarRol);
            this.Controls.Add(this.btn_ModificarRol);
            this.Controls.Add(this.panelBtnGuardar);
            this.Controls.Add(this.btn_AgregarRol);
            this.Controls.Add(this.txt_AgregaEditaRol);
            this.Controls.Add(this.lbl_AgregarEditarRol);
            this.Controls.Add(this.cmbx_Roles);
            this.Controls.Add(this.lbl_RolDisponible);
            this.Controls.Add(this.lbl_Rol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTipo_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTipo_Usuario";
            this.Load += new System.EventHandler(this.formTipo_Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.TextBox txt_AgregaEditaRol;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_EliminarRol;
        private System.Windows.Forms.Button btn_ModificarRol;
        private System.Windows.Forms.Panel panelBtnGuardar;
        private System.Windows.Forms.Button btn_AgregarRol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SalirRol;
        private System.Windows.Forms.Label lbl_RolDisponible;
        private System.Windows.Forms.ComboBox cmbx_Roles;
        private System.Windows.Forms.Label lbl_AgregarEditarRol;
        private System.Windows.Forms.Label lbl_ID_UsuarioTipo;
    }
}