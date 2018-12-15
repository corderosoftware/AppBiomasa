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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmJuego suguiente = new FrmJuego();
            suguiente.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
                pictureImagen.Visible = true;
                axWindowsMediaPlayer1.Visible = false;
                axWindowsMediaPlayer1.Ctlcontrols.stop();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
                axWindowsMediaPlayer1.Visible = true;
                pictureImagen.Visible = false;
            
        }
    }
}
