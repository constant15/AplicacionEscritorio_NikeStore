using Sol_NikeStore.Negocio;
using Sol_NikeStore.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_NikeStore.Presentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;

        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
            {
                picLogo.Image = ByteToImage(byteimage);
            }

            NegocioBis datos = new CN_Negocio().ObtenerDatos();

            txtNombreNegocio.Text = datos.NombreNegocio;
            txtRut.Text = datos.Rut;
            txtDireccion.Text = datos.Direccion;
        }

        private void iconButtonSubir_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "Files|*.jpg;*.jpeg;*.png";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(ofd.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
                {
                    picLogo.Image = ByteToImage(byteimage);

                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void iconButtonGuardarCambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            NegocioBis obj = new NegocioBis()
            {
                NombreNegocio = txtNombreNegocio.Text,
                Rut = txtRut.Text,
                Direccion = txtDireccion.Text,
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Los cambios fueron guardados con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los cambios no pudieron ser guardados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
