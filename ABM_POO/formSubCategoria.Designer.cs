namespace ABM_POO
{
    partial class formSubCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSubCategoria));
            this.lbl_Subcategoria = new System.Windows.Forms.Label();
            this.lbl_Cat = new System.Windows.Forms.Label();
            this.cmbx_Cat = new System.Windows.Forms.ComboBox();
            this.lbl_SubCatDesc = new System.Windows.Forms.Label();
            this.txt_SubcatDesc = new System.Windows.Forms.TextBox();
            this.lbl_SubCat = new System.Windows.Forms.Label();
            this.cmbx_SubCat = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CancelarCat = new System.Windows.Forms.Button();
            this.panelBtnGuardar = new System.Windows.Forms.Panel();
            this.btn_AgregarSubcat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_EliminarSubcat = new System.Windows.Forms.Button();
            this.btn_ModificarSubcat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_CatDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Subcategoria
            // 
            this.lbl_Subcategoria.AutoSize = true;
            this.lbl_Subcategoria.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Subcategoria.Location = new System.Drawing.Point(170, 20);
            this.lbl_Subcategoria.Name = "lbl_Subcategoria";
            this.lbl_Subcategoria.Size = new System.Drawing.Size(203, 36);
            this.lbl_Subcategoria.TabIndex = 1;
            this.lbl_Subcategoria.Text = "SUBCATEGORÍA";
            // 
            // lbl_Cat
            // 
            this.lbl_Cat.AutoSize = true;
            this.lbl_Cat.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cat.ForeColor = System.Drawing.Color.White;
            this.lbl_Cat.Location = new System.Drawing.Point(22, 89);
            this.lbl_Cat.Name = "lbl_Cat";
            this.lbl_Cat.Size = new System.Drawing.Size(298, 29);
            this.lbl_Cat.TabIndex = 2;
            this.lbl_Cat.Text = "Categoría a la que pertenece";
            // 
            // cmbx_Cat
            // 
            this.cmbx_Cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Cat.FormattingEnabled = true;
            this.cmbx_Cat.Location = new System.Drawing.Point(27, 121);
            this.cmbx_Cat.Name = "cmbx_Cat";
            this.cmbx_Cat.Size = new System.Drawing.Size(293, 28);
            this.cmbx_Cat.TabIndex = 3;
            this.cmbx_Cat.SelectedIndexChanged += new System.EventHandler(this.cmbx_Cat_SelectedIndexChanged);
            // 
            // lbl_SubCatDesc
            // 
            this.lbl_SubCatDesc.AutoSize = true;
            this.lbl_SubCatDesc.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubCatDesc.ForeColor = System.Drawing.Color.White;
            this.lbl_SubCatDesc.Location = new System.Drawing.Point(22, 164);
            this.lbl_SubCatDesc.Name = "lbl_SubCatDesc";
            this.lbl_SubCatDesc.Size = new System.Drawing.Size(268, 29);
            this.lbl_SubCatDesc.TabIndex = 4;
            this.lbl_SubCatDesc.Text = "Descripción SubCategoría";
            // 
            // txt_SubcatDesc
            // 
            this.txt_SubcatDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubcatDesc.Location = new System.Drawing.Point(27, 196);
            this.txt_SubcatDesc.Name = "txt_SubcatDesc";
            this.txt_SubcatDesc.Size = new System.Drawing.Size(469, 26);
            this.txt_SubcatDesc.TabIndex = 5;
            this.txt_SubcatDesc.TextChanged += new System.EventHandler(this.txt_SubcatDesc_TextChanged);
            // 
            // lbl_SubCat
            // 
            this.lbl_SubCat.AutoSize = true;
            this.lbl_SubCat.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubCat.ForeColor = System.Drawing.Color.White;
            this.lbl_SubCat.Location = new System.Drawing.Point(22, 236);
            this.lbl_SubCat.Name = "lbl_SubCat";
            this.lbl_SubCat.Size = new System.Drawing.Size(252, 29);
            this.lbl_SubCat.TabIndex = 6;
            this.lbl_SubCat.Text = "SubCategorías añadidas";
            // 
            // cmbx_SubCat
            // 
            this.cmbx_SubCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_SubCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_SubCat.FormattingEnabled = true;
            this.cmbx_SubCat.Location = new System.Drawing.Point(27, 268);
            this.cmbx_SubCat.Name = "cmbx_SubCat";
            this.cmbx_SubCat.Size = new System.Drawing.Size(469, 28);
            this.cmbx_SubCat.TabIndex = 7;
            this.cmbx_SubCat.SelectedIndexChanged += new System.EventHandler(this.cmbx_SubCat_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(383, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 43);
            this.panel2.TabIndex = 23;
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
            this.btn_CancelarCat.Location = new System.Drawing.Point(386, 410);
            this.btn_CancelarCat.Name = "btn_CancelarCat";
            this.btn_CancelarCat.Size = new System.Drawing.Size(140, 43);
            this.btn_CancelarCat.TabIndex = 22;
            this.btn_CancelarCat.Text = "Salir";
            this.btn_CancelarCat.UseVisualStyleBackColor = true;
            this.btn_CancelarCat.Click += new System.EventHandler(this.btn_CancelarCat_Click);
            // 
            // panelBtnGuardar
            // 
            this.panelBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.panelBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.panelBtnGuardar.Location = new System.Drawing.Point(28, 331);
            this.panelBtnGuardar.Name = "panelBtnGuardar";
            this.panelBtnGuardar.Size = new System.Drawing.Size(5, 41);
            this.panelBtnGuardar.TabIndex = 21;
            // 
            // btn_AgregarSubcat
            // 
            this.btn_AgregarSubcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarSubcat.FlatAppearance.BorderSize = 0;
            this.btn_AgregarSubcat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_AgregarSubcat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(211)))), ((int)(((byte)(54)))));
            this.btn_AgregarSubcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarSubcat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarSubcat.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarSubcat.Location = new System.Drawing.Point(31, 331);
            this.btn_AgregarSubcat.Name = "btn_AgregarSubcat";
            this.btn_AgregarSubcat.Size = new System.Drawing.Size(140, 41);
            this.btn_AgregarSubcat.TabIndex = 20;
            this.btn_AgregarSubcat.Text = "Agregar";
            this.btn_AgregarSubcat.UseVisualStyleBackColor = true;
            this.btn_AgregarSubcat.Click += new System.EventHandler(this.btn_AgregarSubcat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(367, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 41);
            this.panel1.TabIndex = 62;
            // 
            // btn_EliminarSubcat
            // 
            this.btn_EliminarSubcat.FlatAppearance.BorderSize = 0;
            this.btn_EliminarSubcat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(24)))), ((int)(((byte)(13)))));
            this.btn_EliminarSubcat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(13)))), ((int)(((byte)(0)))));
            this.btn_EliminarSubcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarSubcat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarSubcat.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarSubcat.Location = new System.Drawing.Point(370, 331);
            this.btn_EliminarSubcat.Name = "btn_EliminarSubcat";
            this.btn_EliminarSubcat.Size = new System.Drawing.Size(140, 41);
            this.btn_EliminarSubcat.TabIndex = 61;
            this.btn_EliminarSubcat.Text = "Eliminar ";
            this.btn_EliminarSubcat.UseVisualStyleBackColor = true;
            this.btn_EliminarSubcat.Click += new System.EventHandler(this.btn_EliminarSubcat_Click);
            // 
            // btn_ModificarSubcat
            // 
            this.btn_ModificarSubcat.FlatAppearance.BorderSize = 0;
            this.btn_ModificarSubcat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(42)))), ((int)(((byte)(147)))));
            this.btn_ModificarSubcat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(67)))), ((int)(((byte)(235)))));
            this.btn_ModificarSubcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarSubcat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarSubcat.ForeColor = System.Drawing.Color.White;
            this.btn_ModificarSubcat.Location = new System.Drawing.Point(196, 330);
            this.btn_ModificarSubcat.Name = "btn_ModificarSubcat";
            this.btn_ModificarSubcat.Size = new System.Drawing.Size(140, 41);
            this.btn_ModificarSubcat.TabIndex = 60;
            this.btn_ModificarSubcat.Text = "Modificar";
            this.btn_ModificarSubcat.UseVisualStyleBackColor = true;
            this.btn_ModificarSubcat.Click += new System.EventHandler(this.btn_ModificarSubcat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(67)))), ((int)(((byte)(235)))));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(193, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 41);
            this.panel3.TabIndex = 63;
            // 
            // lbl_CatDesc
            // 
            this.lbl_CatDesc.AutoSize = true;
            this.lbl_CatDesc.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CatDesc.ForeColor = System.Drawing.Color.White;
            this.lbl_CatDesc.Location = new System.Drawing.Point(347, 89);
            this.lbl_CatDesc.Name = "lbl_CatDesc";
            this.lbl_CatDesc.Size = new System.Drawing.Size(0, 29);
            this.lbl_CatDesc.TabIndex = 64;
            this.lbl_CatDesc.Visible = false;
            // 
            // formSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(555, 479);
            this.Controls.Add(this.lbl_CatDesc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_EliminarSubcat);
            this.Controls.Add(this.btn_ModificarSubcat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_CancelarCat);
            this.Controls.Add(this.panelBtnGuardar);
            this.Controls.Add(this.btn_AgregarSubcat);
            this.Controls.Add(this.cmbx_SubCat);
            this.Controls.Add(this.lbl_SubCat);
            this.Controls.Add(this.txt_SubcatDesc);
            this.Controls.Add(this.lbl_SubCatDesc);
            this.Controls.Add(this.cmbx_Cat);
            this.Controls.Add(this.lbl_Cat);
            this.Controls.Add(this.lbl_Subcategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formSubCategoria";
            this.Load += new System.EventHandler(this.formSubCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Subcategoria;
        private System.Windows.Forms.Label lbl_Cat;
        private System.Windows.Forms.ComboBox cmbx_Cat;
        private System.Windows.Forms.Label lbl_SubCatDesc;
        private System.Windows.Forms.TextBox txt_SubcatDesc;
        private System.Windows.Forms.Label lbl_SubCat;
        private System.Windows.Forms.ComboBox cmbx_SubCat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_CancelarCat;
        private System.Windows.Forms.Panel panelBtnGuardar;
        private System.Windows.Forms.Button btn_AgregarSubcat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_EliminarSubcat;
        private System.Windows.Forms.Button btn_ModificarSubcat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_CatDesc;
    }
}