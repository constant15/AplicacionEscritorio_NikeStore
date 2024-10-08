using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Sol_NikeStore.Entidad;
using Sol_NikeStore.Negocio;
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
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txtBusqueda.Text);

            if(oCompra.IdCompra != 0)
            {
                txtnumerodocumento.Text = oCompra.NumeroDocumento;

                txtFecha.Text = oCompra.FechaRegistro;

                txtTipoDocumento.Text = oCompra.TipoDocumento;
                txtUsuario.Text = oCompra.objUsuario.Apellido;
                txtDocProveedor.Text = oCompra.objProveedor.Documento;
                txtNombreProveedor.Text = oCompra.objProveedor.RazonSocial;


                dgvData.Rows.Clear();

                foreach(Detalle_Compra dc in oCompra.oDetalleCompra)
                {
                    dgvData.Rows.Add(new object[] {dc.objProducto.Nombre,dc.PrecioCompra,dc.Cantidad,dc.MontoTotal});
                }

                txtTotalPagar.Text = oCompra.MontoTotal.ToString("0.00");

            }


        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtFecha.Text = "";
            txtTipoDocumento.Text = "";
            txtUsuario.Text = "";
            txtDocProveedor.Text = "";
            txtNombreProveedor.Text = "";

            dgvData.Rows.Clear();
            txtTotalPagar.Text = "0:00";


        }

        private void btnDescargarPdf_Click(object sender, EventArgs e)
        {
            if(txtTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string texto_html = Properties.Resources.PlantillaCompra.ToString();
            NegocioBis odatos = new CN_Negocio().ObtenerDatos();

            //Introduce en la factura, que se creo usando html, los datos del negocio almacenados en el menu mantenedor->Negocio
            texto_html = texto_html.Replace("@nombrenegocio", odatos.NombreNegocio.ToUpper());
            texto_html = texto_html.Replace("@docnegocio", odatos.Rut);
            texto_html = texto_html.Replace("@direcnegocio", odatos.Direccion);

            //Introduce en la factura los datos almacenados en "Informacion de compra" en el menu Detalle compra 
            texto_html = texto_html.Replace("@tipodocumento", txtTipoDocumento.Text.ToUpper());
            texto_html = texto_html.Replace("@numerodocumento", txtnumerodocumento.Text);

            texto_html = texto_html.Replace("@docproveedor", txtDocProveedor.Text);
            texto_html = texto_html.Replace("@nombreproveedor", txtNombreProveedor.Text);
            texto_html = texto_html.Replace("@fecharegistro", txtFecha.Text);
            texto_html = texto_html.Replace("@usuarioregistro", txtUsuario.Text);

            //Guarda en la factura los datos de la compra realizada que se encuentra en el datagrid de DetalleCompra
            string filas = string.Empty;
            foreach(DataGridViewRow row in dgvData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            texto_html = texto_html.Replace("@filas", filas);
            texto_html = texto_html.Replace("@montototal", txtTotalPagar.Text);


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txtnumerodocumento.Text);
            savefile.Filter = "Pdf Files | *.pdf";


            if(savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);

                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));

                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(texto_html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();

                    MessageBox.Show("Documento Generado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }
    }
}
