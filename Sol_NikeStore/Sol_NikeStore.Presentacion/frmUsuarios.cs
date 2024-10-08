using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_NikeStore.Presentacion.Utilidades;
using Sol_NikeStore.Entidad;
using Sol_NikeStore.Negocio;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sol_NikeStore.Presentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            txtDocumento.KeyPress += new KeyPressEventHandler(txtDocumento_KeyPress);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo"});
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach(Rol item in listaRol)
            {
                cboRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }

            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;

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
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvData.Rows.Add(new object[] { "", item.IdUsuario, item.Documento, item.Nombre, item.Apellido, item.Correo, item.Clave, item.ObjRol.IdRol,
                    item.ObjRol.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                
                });
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;
            string clavePrin = txtClave.Text;
            string claveConf = txtConfClave.Text;

           




            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Correo = txtCorreo.Text,
                Clave = txtClave.Text,
                ObjRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false,
            };

            
            if (clavePrin == claveConf)
            {
                if (objusuario.IdUsuario == 0)
                {

                    int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                    if (idusuariogenerado != 0)
                    {
                        dgvData.Rows.Add(new object[] { "", idusuariogenerado, txtDocumento.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtClave.Text,
                ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
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
                    bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                        row.Cells["Id"].Value = txtId.Text;
                        row.Cells["Documento"].Value = txtDocumento.Text;
                        row.Cells["Nombre"].Value = txtNombre.Text;
                        row.Cells["Apellido"].Value = txtApellido.Text;
                        row.Cells["Correo"].Value = txtCorreo.Text;
                        row.Cells["Clave"].Value = txtClave.Text;
                        row.Cells["IdRol"].Value = ((OpcionCombo)cboRol.SelectedItem).Valor.ToString();
                        row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();
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
            else
            {
                MessageBox.Show("La confirmación de la contraseña no es la misma que la contraseña ingresada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txtClave.Text = "";
            txtConfClave.Text = "";
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            
            txtDocumento.Select();
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if(e.ColumnIndex == 0) 
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
                    txtClave.Text = dgvData.Rows[indice].Cells["Clave"].Value.ToString();
                    txtClave.Text = dgvData.Rows[indice].Cells["Clave"].Value.ToString();
                    txtConfClave.Text = dgvData.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo oc in cboRol.Items)
                    {
                        if(Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar si la tecla presionada es un numero o una tecla relacionada con numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;//No permitir la entrada de caracteres no numericos
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

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            // Verifica si la longitud del texto en el TextBox es mayor que 10.
            if (txtDocumento.Text.Length >= 8)
            {
                // Si es mayor que 10, ajusta el texto para que solo tenga 10 caracteres.
                txtDocumento.Text = txtDocumento.Text.Substring(0, 8);
                txtDocumento.SelectionStart = txtDocumento.Text.Length; // Coloca el cursor al final del texto.
            }
        }

        private void EliminarFilaSeleccionada()
        {
            // Verifica si hay al menos una fila seleccionada
            if (dgvData.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvData.SelectedRows[0];

                // Elimina la fila seleccionada del DataGridView
                dgvData.Rows.Remove(filaSeleccionada);
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de eliminar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarFilaSeleccionada();
        }

       
    }
}
