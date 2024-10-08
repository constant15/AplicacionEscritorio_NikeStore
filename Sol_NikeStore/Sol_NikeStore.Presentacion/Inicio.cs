using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;
//using Sol_NikeStore.Datos;//Permiso dado a la capa de datos para el backup
using Sol_NikeStore.Entidad;
using Sol_NikeStore.Negocio;

namespace Sol_NikeStore.Presentacion
{
    public partial class Inicio : Form
    {
        private static Usuario UsuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objusuario)
        {
            
            UsuarioActual = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(UsuarioActual.IdUsuario);
            
            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if(encontrado == false)
                {
                    iconmenu.Visible = false;
                }

            }


            lblusuario.Text = UsuarioActual.Nombre +" "+UsuarioActual.Apellido;
            lblRol.Text = UsuarioActual.ObjRol.Descripcion;
        }

        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if(MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
               
            }
                FormularioActivo = formulario;
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.BackColor = Color.BlueViolet;
                contenedor.Controls.Add(formulario);
                formulario.Show();
            }
        private void menuUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMantenedor, new frmCategorias());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMantenedor, new frmProductos());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmVentas(UsuarioActual));
        }

        private void subMenuverDetallesVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmDetalleVenta());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmCompras(UsuarioActual));
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmDetalleCompra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        

        private void subMenuNegocio_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMantenedor, new frmNegocio());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir del sistema?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void subMenuReportesCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuReportes, new frmReportesCompras());
        }

        private void subMenuReportesVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuReportes, new frmReporteVentas());
        }

        private void menuBackup_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmBackup());
        }
    }
}
