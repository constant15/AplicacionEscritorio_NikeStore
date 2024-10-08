using Sol_NikeStore.Datos;
using Sol_NikeStore.Entidad;
using Sol_NikeStore.Negocio;
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

namespace Sol_NikeStore.Presentacion.Modales
{
    public partial class modalProducto : Form
    {

        public Producto _Producto { get; set; }
        public modalProducto()
        {
            InitializeComponent();
        }

        private void modalProducto_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true)
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;


            //Muestra en el grid de productos los datos almacenados en la base de datos 
            List<Producto> listaProducto = new CN_Producto().Listar();

            foreach (Producto item in listaProducto)
            {
                dgvData.Rows.Add(new object[] {
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.objCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta

                });
            }

        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                _Producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(dgvData.Rows[iRow].Cells["Id"].Value.ToString()),
                    Codigo= dgvData.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Nombre = dgvData.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(dgvData.Rows[iRow].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(dgvData.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dgvData.Rows[iRow].Cells["PrecioVenta"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
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
    }
}
