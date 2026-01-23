namespace ABM_POO
{
    partial class formCategoria
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
            this.lbl_Categorias = new System.Windows.Forms.Label();
            this.lbl_DescCat = new System.Windows.Forms.Label();
            this.txt_DescCat = new System.Windows.Forms.TextBox();
            this.lbl_ListaCat = new System.Windows.Forms.Label();
            this.cmbx_Categorias = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_EliminarCat = new System.Windows.Forms.Button();
            this.btn_ModificarCat = new System.Windows.Forms.Button();
            this.panelBtnGuardar = new System.Windows.Forms.Panel();
            this.btn_AgregarCat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CancelarCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Categorias
            // 
            this.lbl_Categorias.AutoSize = true;
            this.lbl_Categorias.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categorias.ForeColor = System.Drawing.Color.White;
            this.lbl_Categorias.Location = new System.Drawing.Point(193, 22);
            this.lbl_Categorias.Name = "lbl_Categorias";
            this.lbl_Categorias.Size = new System.Drawing.Size(154, 36);
            this.lbl_Categorias.TabIndex = 0;
            this.lbl_Categorias.Text = "CATEGORÍA";
            // 
            // lbl_DescCat
            // 
            this.lbl_DescCat.AutoSize = true;
            this.lbl_DescCat.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescCat.ForeColor = System.Drawing.Color.White;
            this.lbl_DescCat.Location = new System.Drawing.Point(29, 100);
            this.lbl_DescCat.Name = "lbl_DescCat";
            this.lbl_DescCat.Size = new System.Drawing.Size(281, 29);
            this.lbl_DescCat.TabIndex = 1;
            this.lbl_DescCat.Text = "Descripción de la categoría";
            // 
            // txt_DescCat
            // 
            this.txt_DescCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescCat.Location = new System.Drawing.Point(34, 132);
            this.txt_DescCat.Name = "txt_DescCat";
            this.txt_DescCat.Size = new System.Drawing.Size(469, 26);
            this.txt_DescCat.TabIndex = 2;
            this.txt_DescCat.TextChanged += new System.EventHandler(this.txt_DescCat_TextChanged);
            // 
            // lbl_ListaCat
            // 
            this.lbl_ListaCat.AutoSize = true;
            this.lbl_ListaCat.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaCat.ForeColor = System.Drawing.Color.White;
            this.lbl_ListaCat.Location = new System.Drawing.Point(29, 162);
            this.lbl_ListaCat.Name = "lbl_ListaCat";
            this.lbl_ListaCat.Size = new System.Drawing.Size(215, 29);
            this.lbl_ListaCat.TabIndex = 20;
            this.lbl_ListaCat.Text = "Categorías añadidas";
            // 
            // cmbx_Categorias
            // 
            this.cmbx_Categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Categorias.FormattingEnabled = true;
            this.cmbx_Categorias.Location = new System.Drawing.Point(34, 195);
            this.cmbx_Categorias.Name = "cmbx_Categorias";
            this.cmbx_Categorias.Size = new System.Drawing.Size(341, 28);
            this.cmbx_Categorias.TabIndex = 21;
            this.cmbx_Categorias.SelectedIndexChanged += new System.EventHandler(this.cmbx_Categorias_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(67)))), ((int)(((byte)(235)))));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(196, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 41);
            this.panel3.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(370, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 41);
            this.panel1.TabIndex = 68;
            // 
            // btn_EliminarCat
            // 
            this.btn_EliminarCat.FlatAppearance.BorderSize = 0;
            this.btn_EliminarCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(24)))), ((int)(((byte)(13)))));
            this.btn_EliminarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_EliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarCat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarCat.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarCat.Location = new System.Drawing.Point(373, 252);
            this.btn_EliminarCat.Name = "btn_EliminarCat";
            this.btn_EliminarCat.Size = new System.Drawing.Size(140, 41);
            this.btn_EliminarCat.TabIndex = 67;
            this.btn_EliminarCat.Text = "Eliminar ";
            this.btn_EliminarCat.UseVisualStyleBackColor = true;
            this.btn_EliminarCat.Click += new System.EventHandler(this.btn_EliminarCat_Click);
            // 
            // btn_ModificarCat
            // 
            this.btn_ModificarCat.FlatAppearance.BorderSize = 0;
            this.btn_ModificarCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(147)))));
            this.btn_ModificarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(67)))), ((int)(((byte)(235)))));
            this.btn_ModificarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarCat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarCat.ForeColor = System.Drawing.Color.White;
            this.btn_ModificarCat.Location = new System.Drawing.Point(199, 251);
            this.btn_ModificarCat.Name = "btn_ModificarCat";
            this.btn_ModificarCat.Size = new System.Drawing.Size(140, 41);
            this.btn_ModificarCat.TabIndex = 66;
            this.btn_ModificarCat.Text = "Modificar";
            this.btn_ModificarCat.UseVisualStyleBackColor = true;
            this.btn_ModificarCat.Click += new System.EventHandler(this.btn_ModificarCat_Click);
            // 
            // panelBtnGuardar
            // 
            this.panelBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.panelBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.panelBtnGuardar.Location = new System.Drawing.Point(31, 252);
            this.panelBtnGuardar.Name = "panelBtnGuardar";
            this.panelBtnGuardar.Size = new System.Drawing.Size(5, 41);
            this.panelBtnGuardar.TabIndex = 65;
            // 
            // btn_AgregarCat
            // 
            this.btn_AgregarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarCat.FlatAppearance.BorderSize = 0;
            this.btn_AgregarCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_AgregarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.btn_AgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarCat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarCat.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarCat.Location = new System.Drawing.Point(34, 252);
            this.btn_AgregarCat.Name = "btn_AgregarCat";
            this.btn_AgregarCat.Size = new System.Drawing.Size(140, 41);
            this.btn_AgregarCat.TabIndex = 64;
            this.btn_AgregarCat.Text = "Agregar";
            this.btn_AgregarCat.UseVisualStyleBackColor = true;
            this.btn_AgregarCat.Click += new System.EventHandler(this.btn_AgregarCat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(370, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 43);
            this.panel2.TabIndex = 71;
            // 
            // btn_CancelarCat
            // 
            this.btn_CancelarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarCat.FlatAppearance.BorderSize = 0;
            this.btn_CancelarCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_CancelarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_CancelarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarCat.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarCat.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarCat.Location = new System.Drawing.Point(373, 356);
            this.btn_CancelarCat.Name = "btn_CancelarCat";
            this.btn_CancelarCat.Size = new System.Drawing.Size(140, 43);
            this.btn_CancelarCat.TabIndex = 70;
            this.btn_CancelarCat.Text = "Salir";
            this.btn_CancelarCat.UseVisualStyleBackColor = true;
            this.btn_CancelarCat.Click += new System.EventHandler(this.btn_CancelarCat_Click_1);
            // 
            // formCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(555, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_CancelarCat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_EliminarCat);
            this.Controls.Add(this.btn_ModificarCat);
            this.Controls.Add(this.panelBtnGuardar);
            this.Controls.Add(this.btn_AgregarCat);
            this.Controls.Add(this.cmbx_Categorias);
            this.Controls.Add(this.lbl_ListaCat);
            this.Controls.Add(this.txt_DescCat);
            this.Controls.Add(this.lbl_DescCat);
            this.Controls.Add(this.lbl_Categorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCategoria";
            this.Load += new System.EventHandler(this.formCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Categorias;
        private System.Windows.Forms.Label lbl_DescCat;
        private System.Windows.Forms.TextBox txt_DescCat;
        private System.Windows.Forms.Label lbl_ListaCat;
        private System.Windows.Forms.ComboBox cmbx_Categorias;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_EliminarCat;
        private System.Windows.Forms.Button btn_ModificarCat;
        private System.Windows.Forms.Panel panelBtnGuardar;
        private System.Windows.Forms.Button btn_AgregarCat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_CancelarCat;
    }
}