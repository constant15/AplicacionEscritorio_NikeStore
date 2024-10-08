using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sol_NikeStore.Negocio;
using Sol_NikeStore.Entidad;
using Sol_NikeStore.Presentacion.Utilidades;

namespace Sol_NikeStore.Presentacion
{
    public partial class Login : Form
    {
        private object cboEstado;

        public Login()
        {
            InitializeComponent();
            txtNroDoc.KeyPress += new KeyPressEventHandler(txtNroDoc_KeyPress);
        }

        //Cierra el formulario de login
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ingresa al sistema al presionar en el boton "Ingresar"
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();
            //Se agrego en lambda u.Estado == Convert.ToBoolean(cboEstado = 1)
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtNroDoc.Text && u.Clave == txtClave.Text && u.Estado == Convert.ToBoolean(cboEstado = 1)).FirstOrDefault();

            if (ousuario != null)
            {
                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();    //Oculta el formulario "form"

                form.FormClosing += Fmr_closing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Este metodo vuelve a mostrar el formulario "Login" oculto en caso de cerrar el formulario "Menu" 
        private void Fmr_closing(object sender, FormClosingEventArgs e)
        {
            txtNroDoc.Text = "";
            txtClave.Text = "";

            this.Show();
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica si la tecla presionada es un numero o una tecla relacionada con numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;//No permitir la entrada de caracteres no numericos
            }
        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            // Verifica si la longitud del texto en el TextBox es mayor que 10.
            if (txtNroDoc.Text.Length >= 8)
            {
                // Si es mayor que 10, ajusta el texto para que solo tenga 10 caracteres.
                txtNroDoc.Text = txtNroDoc.Text.Substring(0, 8);
                txtNroDoc.SelectionStart = txtNroDoc.Text.Length; // Coloca el cursor al final del texto.
            }
        }

        
    }
}
