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
    public partial class modalProveedor : Form
    {
        public Proveedor _Proveedor { get; set; }
        public modalProveedor()
        {
            InitializeComponent();
        }

        private void modalProveedor_Load(object sender, EventArgs e)
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


            //Muestra en el grid de usuarios los datos almacenados en la base de datos 
            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();

            foreach (Proveedor item in listaProveedor)
            {
                dgvData.Rows.Add(new object[] {item.IdProveedor, item.Documento, item.RazonSocial});
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {

                _Proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgvData.Rows[iRow].Cells["Id"].Value.ToString()),
                    Documento = dgvData.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvData.Rows[iRow].Cells["RazonSocial"].Value.ToString()

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
