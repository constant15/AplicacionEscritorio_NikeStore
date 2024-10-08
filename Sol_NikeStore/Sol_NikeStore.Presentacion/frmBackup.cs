using Sol_NikeStore.Datos;
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

namespace Sol_NikeStore.Presentacion
{

    
    public partial class frmBackup : Form
    {

        SqlConnection conexion = new SqlConnection("server = DESKTOP-BVGL3G7\\SQLEXPRESS; database = BDD_NikeStore; integrated security = true");
        public frmBackup()
        {
            InitializeComponent();
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {

        }

        private void buttonRuta_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = dlg.SelectedPath;
                buttonBackup.Enabled = true;
            }
        }

        private void buttonBackup_Click_1(object sender, EventArgs e)
        {
            string db = conexion.Database.ToString();
            string cmd = "BACKUP DATABASE [" + db + "] TO DISK ='" + txtBackup.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
            conexion.Open();
            SqlCommand command = new SqlCommand(cmd, conexion);
            command.ExecuteNonQuery();
            MessageBox.Show("El backup de la base de datos se ha realizado con exito");
            conexion.Close();
            buttonBackup.Enabled = false;
        }
    }
}

