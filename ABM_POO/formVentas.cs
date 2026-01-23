using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VentaNegocio;
using ConexionSQL;

namespace ABM_POO
{
    public partial class formVentas : Form
    {
        public formVentas()
        {
            InitializeComponent();
        }
        string codigoArt = "";
        decimal subtotal = 0;
        decimal total = 0;
        decimal descuento = 0;
        decimal precioDescuenta = 0;
        int cantidad = 0;
        int stockActual;
        int stockAntiguo;
        bool confirmaStock;

        private void cmbx_TipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_TipoCliente.SelectedItem.ToString() == "Cliente Existente")
            { 
                lbl_CuitBuscar.Visible = true; 
                txt_CuitBuscar.Visible = true;
                btn_Buscar.Visible = true;
                panelBtnBuscar.Visible = true;
                gpbx_DatosCliente.Enabled = false;
            }
            else
            {
                lbl_CuitBuscar.Visible = false;
                txt_CuitBuscar.Visible = false;
                btn_Buscar.Visible = false;
                panelBtnBuscar.Visible = false;
                gpbx_DatosCliente.Enabled = true;
                LimpiaTextboxClientes();
            }
        }

        private void formVentas_Load(object sender, EventArgs e)
        {
            panelBtnBuscar.Visible = false;
            lbl_CuitBuscar.Visible = false;
            txt_CuitBuscar.Visible = false;
            btn_Buscar.Visible = false;
            gpbx_DatosCliente.Enabled = false;
            ConexionBD.ConectarBD();
            cmbx_codProductos.DataSource = Gestion_H_Venta.Codigo_Productos();
            cmbx_codProductos.DisplayMember = "Cod_Articulo";
            cmbx_codProductos.ValueMember = "ID_Articulo";
            cmbx_codDescrip.Enabled = false;
            cmbx_Vendedores.DataSource = Gestion_H_Venta.Traer_Vendedores();
            cmbx_Vendedores.DisplayMember = "Nombre_Usuario";
            cmbx_Vendedores.ValueMember = "ID_Usuario";
            ConexionBD.CierraBD();
            propiedadesDGV();
            gpbx_DatosArticulo.Enabled = false;

        }

        private void propiedadesDGV()
        {
            dgv_Arts.DefaultCellStyle.Font = new Font("Arial", 12);
            dgv_Arts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv_Arts.ColumnHeadersHeight = 15;
            dgv_Arts.RowTemplate.Height = 15;
            dgv_Arts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Arts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Arts.DefaultCellStyle.ForeColor = Color.Black;
            dgv_Arts.DefaultCellStyle.BackColor = Color.White;

        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("¿Está seguro de cancelar esta venta?", "Cancelar Venta", MessageBoxButtons.OKCancel);
            if (confirma == DialogResult.OK)
            {
                ConexionBD.ConectarBD();
                H_Venta cancelaVenta = new H_Venta(Convert.ToInt32(lbl_ID_Remito.Text));
                try
                {
                    Gestion_H_Venta.Genera_Delete_HVentas(cancelaVenta);
                    MessageBox.Show("Venta cancelada con éxito!");
                    LimpiaTextboxClientes();
                    LimpiaTextboxVenta();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al querer cancelar la venta: " + ex.Message);
                }
            }
            ConexionBD.CierraBD();
        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lbl_FechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            string dni = txt_CuitBuscar.Text;
            string query = "Select [ID_Cliente], [CUIT_Cliente], [Nombre_Cliente], [Telf_Cliente], [Mail_Cliente], [Direc_Cliente] from [dbo].[Clientes] where [CUIT_Cliente] = " + Convert.ToInt32(txt_CuitBuscar.Text);
            SqlDataReader Lector = ConexionBD.LecturaBD(query);

            if (Lector.Read())
            {
                lbl_IDCliente.Text = Lector["ID_Cliente"].ToString();
                txt_CuitRemito.Text = Lector["CUIT_Cliente"].ToString();
                txt_NombreRemito.Text = Lector["Nombre_Cliente"].ToString();
                txt_TelfRemito.Text = Lector["Telf_Cliente"].ToString();
                txt_EmailRemito.Text = Lector["Mail_Cliente"].ToString();
                txt_DirecRemito.Text = Lector["Direc_Cliente"].ToString();
                
                Lector.Close();
                H_Venta remitoVenta = new H_Venta(Convert.ToInt32(lbl_IDCliente.Text), Convert.ToDateTime(lbl_FechaHora.Text));
                ConexionBD.EjecutaQuery(Gestion_H_Venta.Genera_Medio_Insert_HVentas_Ex(remitoVenta));
                string query2 = "Select [ID_Remito] from [dbo].[Hist_Ventas] inner join [dbo].[Clientes] on [dbo].[Hist_Ventas].[ID_Cliente] = [dbo].[Clientes].[ID_Cliente] where [dbo].[Clientes].[ID_Cliente] = " + Convert.ToInt32(lbl_IDCliente.Text);
                SqlDataReader Lector2 = ConexionBD.LecturaBD(query2);
                if (Lector2.Read())
                {
                    lbl_ID_Remito.Text = Lector2["ID_Remito"].ToString();
                }
                gpbx_DatosArticulo.Enabled = true;
            }
            else
            {

                MessageBox.Show("Cliente no encontrado. Se procederá con la venta");
                Lector.Close();
                H_Venta remitoVenta = new H_Venta(Convert.ToInt32(txt_CuitBuscar.Text), Convert.ToDateTime(lbl_FechaHora.Text));
                try
                {
                    ConexionBD.EjecutaQuery(Gestion_H_Venta.Genera_Medio_Insert_HVentas_Inex(remitoVenta));
                    InhabilitaTextbox();
                    string query2 = "Select [dbo].[Hist_Ventas].[ID_Remito] from [dbo].[Hist_Ventas] where [dbo].[Hist_Ventas].[Cuit_Cliente_Inex] = " + Convert.ToInt32(txt_CuitBuscar.Text);
                    SqlDataReader Lector2 = ConexionBD.LecturaBD(query2);
                    if (Lector2.Read())
                    {
                        lbl_ID_Remito.Text = Lector2["ID_Remito"].ToString();
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar el cliente: " + ex.Message);
                    
                }
                gpbx_DatosArticulo.Enabled = true;
            }
            
            ConexionBD.CierraBD();
        }

        private void btn_GuardarRemito_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            Cliente clienteNuevo = new Cliente(Convert.ToInt32(txt_CuitRemito.Text), txt_NombreRemito.Text, txt_EmailRemito.Text, Convert.ToInt32(txt_TelfRemito.Text), txt_DirecRemito.Text);
            Cliente traerID = new Cliente(Convert.ToInt32(txt_CuitRemito.Text));
            try
            {
                ConexionBD.EjecutaQuery(Gestion_H_Venta.Carga_Cliente_Nuevo(clienteNuevo));
                //MessageBox.Show("Cliente cargado con éxito");
                
                string query = "Select [ID_Cliente] from [dbo].[Clientes] where [CUIT_Cliente] = " + Convert.ToInt32(txt_CuitRemito.Text);
                SqlDataReader Lector = ConexionBD.LecturaBD(query);
                if (Lector.Read())
                {
                    lbl_IDCliente.Text = Lector["ID_Cliente"].ToString();
                    Lector.Close();
                }
                H_Venta remitoVenta = new H_Venta(Convert.ToInt32(lbl_IDCliente.Text), Convert.ToDateTime(lbl_FechaHora.Text));
                ConexionBD.EjecutaQuery(Gestion_H_Venta.Genera_Medio_Insert_HVentas_Ex(remitoVenta));
                InhabilitaTextbox();
                string query2 = "Select [ID_Remito] from [dbo].[Hist_Ventas] inner join [dbo].[Clientes] on [dbo].[Hist_Ventas].[ID_Cliente] = [dbo].[Clientes].[ID_Cliente] where [dbo].[Clientes].[ID_Cliente] = " + Convert.ToInt32(lbl_IDCliente.Text);
                SqlDataReader Lector2 = ConexionBD.LecturaBD(query2);
                if(Lector2.Read())
                {
                    lbl_ID_Remito.Text = Lector2["ID_Remito"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el cliente:" + ex.Message);
            }
            gpbx_DatosArticulo.Enabled = true;
            ConexionBD.CierraBD();
        }
        private void InhabilitaTextbox()
        {
            gpbx_DatosCliente.Enabled = false;
            txt_CuitBuscar.Enabled = false;
        }

        private void LimpiaTextboxClientes()
        {
            txt_CuitBuscar.Text = "";
            txt_CuitRemito.Text = "";
            txt_NombreRemito.Text = "";
            txt_DirecRemito.Text = "";
            txt_EmailRemito.Text = "";
            txt_TelfRemito.Text = "";
        }

        private void btn_CancelarRemito_Click(object sender, EventArgs e)
        {
            LimpiaTextboxClientes();
        }




        private void cmbx_codProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int idProducto = Convert.ToInt32(cmbx_codProductos.SelectedValue.ToString());
                cmbx_codDescrip.Enabled = true;
                ConexionBD.ConectarBD();
                Articulo descArt = new Articulo(idProducto);
                cmbx_codDescrip.DataSource = Gestion_H_Venta.Descrip_ProductoXCodigo(descArt);
                cmbx_codDescrip.DisplayMember = "Art_Descrip";
                cmbx_codDescrip.ValueMember = "PrecioVenta";
                

                ConexionBD.CierraBD();
                lbl_PrecioUnidad.Text = cmbx_codDescrip.SelectedValue.ToString();
                txt_Precio.Text = cmbx_codDescrip.SelectedValue.ToString();
                numUpDown_Cant.Value = 1;

            }
        }

        private void numUpDown_Cant_ValueChanged(object sender, EventArgs e)
        {
            txt_Precio.Text = Convert.ToString(numUpDown_Cant.Value * Convert.ToInt32(lbl_PrecioUnidad.Text));
        }

        private void btn_AgregarArt_Click(object sender, EventArgs e)
        {
            int idProd = Convert.ToInt32(cmbx_codProductos.SelectedValue.ToString());
            string codProd = cmbx_codProductos.Text;
            string descProd = cmbx_codDescrip.Text;

            ProductoenGrilla(idProd, codProd, descProd, Convert.ToInt32(lbl_PrecioUnidad.Text), numUpDown_Cant.Value, Convert.ToInt32(txt_Precio.Text));

            subtotal += Convert.ToInt32(txt_Precio.Text);
            txt_Subtotal.Text = subtotal.ToString();
            lbl_Total.Text = "Total: " + subtotal.ToString();
            //    ConexionBD.ConectarBD();
            //    H_Venta_D ventaNueva = new H_Venta_D(Convert.ToInt32(lbl_ID_Remito.Text), codProd, descProd, Convert.ToInt32(numUpDown_Cant.Value), lbl_PrecioUnit.Text, txt_Precio.Text);

            //    try
            //    {
            //        ConexionBD.EjecutaQuery(Gestion_H_Venta.Genera_Insert_Productos(ventaNueva));



            //    }

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al cargar el producto: " + ex.Message);
            //    }
            //ConexionBD.CierraBD();
        }

        private void AgregaProducto()
        {
            string codProd = "";
            string descProd = "";
            int cantProd = 0;
            string precioUnitario = "";
            string subtotal = "";
            int idRemito = Convert.ToInt32(lbl_ID_Remito.Text);

           
           

            foreach (DataGridViewRow fila in dgv_Arts.Rows)
            {
                codProd = fila.Cells["CodProd"].Value.ToString();
                descProd = fila.Cells["Descripcion"].Value.ToString();
                cantProd = Convert.ToInt32(fila.Cells["CantidadProd"].Value.ToString());
                precioUnitario = fila.Cells["PrecioXUnidad"].Value.ToString();
                subtotal = fila.Cells["SubtotalProd"].Value.ToString();
            }

            H_Venta_D ventaNueva = new H_Venta_D(idRemito, codProd, descProd, cantProd, precioUnitario, subtotal);
            try
            {
                ConexionBD.EjecutaQuery(Gestion_H_Venta.Genera_Insert_Productos(ventaNueva));

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el producto: " + ex.Message);
            }
            

        }
        private void ProductoenGrilla(int ID, string codigo, string desc, int precioUnit, decimal cantidad, int subtotal)
        {
            bool existe = false;

            // Recorrer las filas del DataGridView
            foreach (DataGridViewRow fila in dgv_Arts.Rows)
            {
                decimal stock = Convert.ToDecimal(fila.Cells["CantidadProd"].Value);
                int subTotal = Convert.ToInt32(fila.Cells["SubtotalProd"].Value);

                if (fila.Cells["CodProd"].Value != null && fila.Cells["CodProd"].Value.ToString() == cmbx_codProductos.Text)
                {
                    // Si el código ya existe, actualizo los demás valores
                    stock = stock + cantidad;
                    fila.Cells["CantidadProd"].Value = stock;
                    subTotal = subTotal + subtotal;
                    fila.Cells["SubtotalProd"].Value = subTotal;
                    existe = true;
                    break;
                }
            }

            // Si no existe, agrego una nueva fila
            if (!existe)
            {
                dgv_Arts.Rows.Add(ID, codigo, desc, precioUnit, cantidad, subtotal);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            descuento = numUpDownDesc.Value / 100;
            precioDescuenta = Convert.ToInt32(txt_Subtotal.Text) * descuento;
            total = Convert.ToDecimal(txt_Subtotal.Text) - precioDescuenta;
            lbl_Total.Text = "Total: " + total.ToString();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("¿Está seguro de guardar esta venta?", "Guardar Venta", MessageBoxButtons.OKCancel);

            if(confirma == DialogResult.OK)
            {
                ConexionBD.ConectarBD();
                RestaStock();
                if (confirmaStock)
                {
                    
                    //H_Venta actualizaVenta = new H_Venta(Convert.ToInt32(lbl_ID_Remito.Text), txt_Subtotal.Text, Convert.ToString(numUpDownDesc.Value), Convert.ToInt32(cmbx_Vendedores.SelectedValue.ToString()), total.ToString());
                    try
                    {
                        AgregaProducto();
                        ActualizaStock();
                        //ConexionBD.EjecutaQuery(Gestion_H_Venta.Genera_Update_HVentas(actualizaVenta));
                        MessageBox.Show("Venta registrada con éxito!");
                        //LimpiaTextboxClientes();
                        //gpbx_DatosCliente.Enabled = false;
                        //txt_CuitBuscar.Visible = false;
                        //Articulo stockActualizado = new Articulo(stockActual);
                        //ConexionBD.EjecutaQuery(Gestion_H_Venta.Actualiza_Stock(stockActualizado));

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la venta: " + ex.Message);
                    }
                }
                
            }
            ConexionBD.CierraBD();
        }

        private void RestaStock()
        {
            confirmaStock = true; 
            
            foreach (DataGridViewRow fila in dgv_Arts.Rows)
            {   
                
                cantidad = Convert.ToInt32(fila.Cells["CantidadProd"].Value);
                codigoArt = fila.Cells["IDProd"].Value.ToString();
                string descripcion = fila.Cells["Descripcion"].Value.ToString();
                string query = "Select [Stock_Articulo] from [dbo].[Articulos] where [ID_Articulo] = '" + codigoArt + "'";
                SqlDataReader Lector = ConexionBD.LecturaBD(query);
                if (Lector.Read())
                {
                    stockAntiguo = Convert.ToInt32(Lector["Stock_Articulo"].ToString());
                }

                if (stockAntiguo < cantidad)
                {
                    MessageBox.Show("Error:  No hay suficiente stock del producto " + descripcion, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    confirmaStock = false;
                    
                    break;
                }
                else
                {
                    stockActual = stockAntiguo - cantidad;

                }

                Lector.Close();
            }
            
        }

        private void ActualizaStock ()
        {
            
            foreach (DataGridViewRow fila in dgv_Arts.Rows)
            {
                string codArt = fila.Cells["IDProd"].Value.ToString();
                Articulo stockActualizado = new Articulo(stockActual, codigoArt);
                ConexionBD.EjecutaQuery(Gestion_H_Venta.Actualiza_Stock(stockActualizado));
            }

        }

        private void LimpiaTextboxVenta()
        {
            txt_Precio.Text = "";
            txt_Subtotal.Text = "";
            numUpDown_Cant.Value = 0;
            numUpDownDesc.Value = 0;
            dgv_Arts.Rows.Clear();
            gpbx_DatosArticulo.Enabled = false;
            lbl_Total.Text = "Total:";
        }

    }
}
