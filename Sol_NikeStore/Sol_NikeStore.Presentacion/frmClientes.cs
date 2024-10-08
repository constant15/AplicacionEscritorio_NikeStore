using ClosedXML.Excel;
using Sol_NikeStore.Entidad;
using Sol_NikeStore.Negocio;
using Sol_NikeStore.Presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_NikeStore.Presentacion
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;


            //Muestra en el grid de usuarios los datos almacenados en la base de datos 
            List<Cliente> listaCliente = new CN_Cliente().Listar();

            foreach (Cliente item in listaCliente)
            {
                dgvData.Rows.Add(new object[] { "", item.IdCliente, item.Documento, item.Nombre, item.Apellido, item.Correo, item.Telefono,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"

                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            

            Cliente objCliente = new Cliente()
            {
                IdCliente = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Correo = txtCorreo.Text,
                Telefono = txtCelular.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false,
            };


           
            
                if (objCliente.IdCliente == 0)
                {

                    int idClienteGenerado = new CN_Cliente().Registrar(objCliente, out mensaje);

                    if (idClienteGenerado != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", idClienteGenerado, txtDocumento.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtCelular.Text,
                        ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString()
                     });
                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }




                }
                else
                {
                    bool resultado = new CN_Cliente().Editar(objCliente, out mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                        row.Cells["Id"].Value = txtId.Text;
                        row.Cells["Documento"].Value = txtDocumento.Text;
                        row.Cells["Nombre"].Value = txtNombre.Text;
                        row.Cells["Apellido"].Value = txtApellido.Text;
                        row.Cells["Correo"].Value = txtCorreo.Text;
                        row.Cells["Celular"].Value = txtCelular.Text;
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString();

                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            
            
        }


        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtCelular.Text = "";
            cboEstado.SelectedIndex = 0;

            txtDocumento.Select();
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20R.Width;
                var h = Properties.Resources.check20R.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20R, new Rectangle(x, y, w, h));
                e.Handled = true;


            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtDocumento.Text = dgvData.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombre.Text = dgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvData.Rows[indice].Cells["Apellido"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    txtCelular.Text = dgvData.Rows[indice].Cells["Celular"].Value.ToString();
                    
                    foreach (OpcionCombo oc in cboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;

                    }
                    else
                    {
                        row.Visible = false;
                    }
                }

            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar si la tecla presionada es un numero o una tecla relacionada con numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;//No permitir la entrada de caracteres no numericos
            }
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (txtDocumento.Text.Length >= 8)
            {
                // Si es mayor que 10, ajusta el texto para que solo tenga 10 caracteres.
                txtDocumento.Text = txtDocumento.Text.Substring(0, 8);
                txtDocumento.SelectionStart = txtDocumento.Text.Length; // Coloca el cursor al final del texto.
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string[] palabras = textBox.Text.Split(' ');

                for (int i = 0; i < palabras.Length; i++)
                {
                    if (!string.IsNullOrEmpty(palabras[i]))
                    {
                        palabras[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(palabras[i].ToLower());
                    }
                }

                textBox.Text = string.Join(" ", palabras);

                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string[] palabras = textBox.Text.Split(' ');

                for (int i = 0; i < palabras.Length; i++)
                {
                    if (!string.IsNullOrEmpty(palabras[i]))
                    {
                        palabras[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(palabras[i].ToLower());
                    }
                }

                textBox.Text = string.Join(" ", palabras);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;//No permitir la entrada de caracteres no numericos
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvData.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Visible)

                        dt.Rows.Add(new object[]
                        {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[8].Value.ToString()
                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteClientes-{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte de clientes generado con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
