using Sol_NikeStore.Entidad;
using Sol_NikeStore.Negocio;
using Sol_NikeStore.Presentacion.Modales;
using Sol_NikeStore.Presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_NikeStore.Presentacion
{
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;
        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cboTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cboTipoDocumento.DisplayMember = "Texto";
            cboTipoDocumento.ValueMember = "Valor";
            cboTipoDocumento.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdProducto.Text = "";

            txtPagaCon.Text = "";
            txtCambio.Text = "";
            txtTotalPagar.Text = "0";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new modalCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtDocCliente.Text = modal._Cliente.Documento;
                    txtNombreCliente.Text = modal._Cliente.Nombre;
                    txtApellidoCliente.Text = modal._Cliente.Apellido;
                    txtCodProducto.Select();
                }
                else
                {
                    txtDocCliente.Select();
                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new modalProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._Producto.IdProducto.ToString();
                    txtCodProducto.Text = modal._Producto.Codigo;
                    txtProducto.Text = modal._Producto.Nombre;
                    txtPrecioVenta.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtStock.Text = modal._Producto.Stock.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtCodProducto.Select();
                }
            }
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtCodProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodProducto.BackColor = System.Drawing.Color.Honeydew;
                    txtIdProducto.Text = oProducto.IdProducto.ToString();
                    txtProducto.Text = oProducto.Nombre;
                    txtPrecioVenta.Text = oProducto.PrecioVenta.ToString("0.00");
                    txtStock.Text = oProducto.Stock.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtCodProducto.BackColor = System.Drawing.Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProducto.Text = "";
                    txtPrecioVenta.Text = "";
                    txtStock.Text = "";
                    txtCantidad.Value = 1;

                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text, out precioventa))
            {
                MessageBox.Show("Precio Compra - Formato de moneda incorrecto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVenta.Select();
                return;
            }

            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(txtCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad ingresada para la venta no puede ser mayor al stock.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgvData.Rows)
            {
                if (fila.Cells["IdProductodgv"].Value.ToString() == txtIdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtIdProducto.Text),
                    Convert.ToInt32(txtCantidad.Value.ToString())
                    );
                if (respuesta)
                {
                    dgvData.Rows.Add(new object[]
                {
                    txtIdProducto.Text,
                    txtProducto.Text,
                    precioventa.ToString("0.00"),
                    txtCantidad.Value.ToString(),
                    (txtCantidad.Value * precioventa).ToString("0.00")
                });
                    calcularTotal();
                    limpiarProducto();

                    txtCodProducto.Select();
                }
  
            }
        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value.ToString());
            }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void limpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodProducto.Text = "";
            txtCodProducto.BackColor = System.Drawing.Color.White;
            txtProducto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtCantidad.Value = 1;
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.deleteicon.Width;
                var h = Properties.Resources.deleteicon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.deleteicon, new Rectangle(x, y, w, h));
                e.Handled = true;


            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvData.Rows[indice].Cells["IdProductodgv"].Value.ToString()),
                        Convert.ToInt32(dgvData.Rows[indice].Cells["Cantidad"].Value.ToString())
                        );
                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(indice);
                        calcularTotal();
                    }


                    
                }
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }


        private void calcularCambio()
        {
            if(txtTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotalPagar.Text);

            if(txtPagaCon.Text.Trim() == "")
            {
                txtPagaCon.Text = "0";
            }

            if(decimal.TryParse(txtPagaCon.Text.Trim(), out pagacon))
            {
                if(pagacon < total)
                {
                    txtCambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularCambio();
            }
        
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if(txtDocCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI del cliente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if(txtNombreCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if(txtApellidoCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar el apellido del cliente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if(dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos para registrar la venta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof (int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

            foreach(DataGridViewRow row in dgvData.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                row.Cells["IdProductodgv"].Value.ToString(),
                row.Cells["PrecioVenta"].Value.ToString(),
                row.Cells["Cantidad"].Value.ToString(),
                row.Cells["Subtotal"].Value.ToString()
                });
            }


            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);
            calcularCambio();

            Venta oVenta = new Venta()
            {

                objUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cboTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = txtDocCliente.Text,
                NombreCliente = txtNombreCliente.Text,
                ApellidoCliente = txtApellidoCliente.Text,
                MontoPago = Convert.ToDecimal(txtPagaCon.Text),
                MontoCambio = Convert.ToDecimal(txtCambio.Text),
                MontoTotal = Convert.ToDecimal(txtTotalPagar.Text)

            };

            string mensaje = string.Empty;

            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generado: \n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroDocumento);

                    txtDocCliente.Text = "";
                    txtNombreCliente.Text = "";
                    txtApellidoCliente.Text = "";
                    dgvData.Rows.Clear();
                    calcularTotal();
                    txtPagaCon.Text = "";
                    txtCambio.Text = "";
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        

    }
}
