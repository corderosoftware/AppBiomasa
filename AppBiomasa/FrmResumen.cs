using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBiomasa
{
    public partial class FrmResumen : Form
    {
        public FrmResumen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmJuego siguiente = new FrmJuego();
            siguiente.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnUrl_Click(object sender, EventArgs e)
        {
            String address="";
            if (String.IsNullOrEmpty(txtUrl.Text)) return;
            if (txtUrl.Text.Equals("about:blank")) return;
            if (!txtUrl.Text.StartsWith("http://") &&
                !txtUrl.Text.StartsWith("https://"))
            {
                address = "http://" + txtUrl.Text;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
