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
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            txtBusqueda.Select();  
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtBusqueda.Text);

            if(oVenta.IdVenta != 0)
            {
                txtNroDocumento.Text = oVenta.NumeroDocumento;

                txtFecha.Text = oVenta.FechaRegistro;

                txtTipoDocumento.Text = oVenta.TipoDocumento;

                txtUsuario.Text = oVenta.objUsuario.Apellido;

                txtDocCliente.Text = oVenta.DocumentoCliente;
                txtNombreCliente.Text = oVenta.NombreCliente;
                txtApeliidoCliente.Text = oVenta.ApellidoCliente;

                dgvData.Rows.Clear();  

                foreach(Detalle_Venta dv in oVenta.objListaDetalleVenta)
                {
                    dgvData.Rows.Add(new object[] { dv.objProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }

                txtTotalPagar.Text = oVenta.MontoTotal.ToString("0.00");
                txtMontoPago.Text = oVenta.MontoPago.ToString("0.00");
                txtMontoCambio.Text = oVenta.MontoCambio.ToString("0.00");

            }



        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtFecha.Text = "";
            txtTipoDocumento.Text = "";
            txtUsuario.Text = "";
            txtDocCliente.Text = "";
            txtNombreCliente.Text = "";
            txtApeliidoCliente.Text = "";

            dgvData.Rows.Clear();
            txtTotalPagar.Text = "0.00";
            txtMontoPago.Text = "0.00";
            txtMontoCambio.Text = "0.00";


        }

        private void btnDescargarPdf_Click(object sender, EventArgs e)
        {
            if (txtTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string texto_html = Properties.Resources.PlantillaVenta.ToString();
            NegocioBis odatos = new CN_Negocio().ObtenerDatos();

            //Introduce en la factura, que se creo usando html, los datos del negocio almacenados en el menu mantenedor->Negocio
            texto_html = texto_html.Replace("@nombrenegocio", odatos.NombreNegocio.ToUpper());
            texto_html = texto_html.Replace("@docnegocio", odatos.Rut);
            texto_html = texto_html.Replace("@direcnegocio", odatos.Direccion);

            //Introduce en la factura los datos almacenados en "Informacion de compra" en el menu Detalle compra 
            texto_html = texto_html.Replace("@tipodocumento", txtTipoDocumento.Text.ToUpper());
            texto_html = texto_html.Replace("@numerodocumento", txtNroDocumento.Text);

            texto_html = texto_html.Replace("@doccliente", txtDocCliente.Text);
            texto_html = texto_html.Replace("@nombrecliente", txtNombreCliente.Text);
            texto_html = texto_html.Replace("@apellidocliente", txtApeliidoCliente.Text);
            texto_html = texto_html.Replace("@fecharegistro", txtFecha.Text);
            texto_html = texto_html.Replace("@usuarioregistro", txtUsuario.Text);

            //Guarda en la factura los datos de la compra realizada que se encuentra en el datagrid de DetalleCompra
            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            texto_html = texto_html.Replace("@filas", filas);
            texto_html = texto_html.Replace("@montototal", txtTotalPagar.Text);
            texto_html = texto_html.Replace("@pagocon", txtMontoPago.Text);
            texto_html = texto_html.Replace("@cambio", txtMontoCambio.Text);


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txtNroDocumento.Text);
            savefile.Filter = "Pdf Files | *.pdf";


            if (savefile.ShowDialog() == DialogResult.OK)
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
