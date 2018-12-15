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

namespace AppBiomasa
{
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();

            string strConn = "Data Source=(local);Initial Catalog=BDEnergias;Integrated Security=True";

            using (SqlConnection c = new SqlConnection(strConn))
            {
                c.Open();
                // Create new DataAdapter
                using (SqlDataAdapter a = new SqlDataAdapter(
                    "SELECT * FROM Datos_Biomasa", c))
                {
                    // 3
                    // Use DataAdapter to fill DataTable
                    DataTable t = new DataTable();
                    a.Fill(t);
                    dataGridBio.DataSource = t;
                }


            }
            


        }

        private void btnCierraDatos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
