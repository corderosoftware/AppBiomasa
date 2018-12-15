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
    public partial class FrmJuego : Form
    {
        
        string pathImg = @"C:\Users\Victor Cordero\Source\Repos\AppBiomasa\AppBiomasa\Imagenes\";
        int valorAgua = 100;
        int valorVegetal = 100;
        int NroImg;
        int Insumo;
        int ImgInsumo;
        int CasoToxico;
        int ValorInsumo;
        int muestraToxico;
        string Negativo = "";
        Random rnd = new Random();
        public FrmJuego()
        {
            InitializeComponent();
            CambiarImagenValor();
            MuestraInsumos();
        }
        private void Reiniciar()
        {
            valorAgua = 100;
            valorVegetal = 100;
            CambiarImagenValor();
            MuestraInsumos();
            timer1.Enabled = true;
            timer1.Start();
            pictureLlama.Visible = true;
            progressBar1.Value = 100;
        }

        private void MuestraInsumos()
        {
            lblAgua.Text = valorAgua.ToString() + " %";
            lblVegetal.Text = valorVegetal.ToString() + " %";
        }

        private void CambiarImagenValor()
        {
                CasoToxico = rnd.Next(1, 100); 
                Insumo = rnd.Next(1, 4); //Aleatorio Insumo
                ImgInsumo = rnd.Next(1, 5); //Aleatorio Imagen Insumo
                ValorInsumo = 10; //Valor Insumo

                Negativo = CasoToxico > 20 ? "Negativo" : "toxico";

            switch (Insumo)
            {
                case 1: //Combustible Vegetal
                    Img1.Image = Image.FromFile(pathImg + "Combustible" + ImgInsumo + ".png");
                    Img1.Tag = ValorInsumo;
                    Img2.Image = Image.FromFile(pathImg + "Neutro" + ImgInsumo + ".png");
                    Img2.Tag = ValorInsumo;
                    Img3.Image = Image.FromFile(pathImg + Negativo + ImgInsumo + ".png");
                        Img3.Tag = 0;
                    valorVegetal += ValorInsumo;
                        break;
                    case 2: //Liquido
                        Img1.Image = Image.FromFile(pathImg + "Neutro" + ImgInsumo + ".png");
                        Img1.Tag = ValorInsumo;
                        Img2.Image = Image.FromFile(pathImg + Negativo + ImgInsumo + ".png");
                        Img2.Tag = 0;
                        Img3.Image = Image.FromFile(pathImg + "Combustible" + ImgInsumo + ".png");
                        Img3.Tag = ValorInsumo;
                    break;
                    case 3: //Negativo
                        Img1.Image = Image.FromFile(pathImg + Negativo + ImgInsumo + ".png");
                        Img1.Tag = 0;
                        Img2.Image = Image.FromFile(pathImg + "Neutro" + ImgInsumo + ".png");
                        Img2.Tag = ValorInsumo;
                        Img3.Image = Image.FromFile(pathImg + "Combustible" + ImgInsumo + ".png");
                        Img3.Tag = ValorInsumo;
                    break;
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            valorAgua++;
            lblAgua.Text = valorAgua.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reiniciar();    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value -= 5;
                valorAgua -= 5;
                valorVegetal -= 5;
                MuestraInsumos();
            }
            else
            {
                pictureLlama.Visible = false;
                timer1.Enabled = false;
                timer1.Dispose();
            }
            
        }

        private void ImgCombustible_Click(object sender, EventArgs e)
        {
            if (Negativo != "toxico")
            {
                //Random rnd = new Random();
                //valorVegetal += rnd.Next();
                //lblVegetal.Text = valorVegetal.ToString() + "lt";
                CambiarImagenValor();
                MuestraInsumos();
                progressBar1.Value += int.Parse(Img1.Tag.ToString());
            }
            else
            {
                JurgoPerdido();
            }
         
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblVegetal_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Img2_Click(object sender, EventArgs e)
        {
            if (Negativo != "toxico")
            {
                CambiarImagenValor();
                MuestraInsumos();
                progressBar1.Value += int.Parse(Img2.Tag.ToString());
            }
            else
            {
                JurgoPerdido();
            }
        }

        private void Img3_Click(object sender, EventArgs e)
        {
            if (Negativo != "toxico")
            {
                CambiarImagenValor();
                MuestraInsumos();
                progressBar1.Value += int.Parse(Img3.Tag.ToString());
            }
            else
            {
                JurgoPerdido();
            }
        }

        public void JurgoPerdido()
        {
            timer1.Enabled = false;
            timer1.Dispose();
            progressBar1.Value = 0;
            //progressBar1.ForeColor = Color.Red;
            pictureLlama.Visible = false;
            MessageBox.Show("Se pudre todo");
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            FrmResumen resumen = new FrmResumen();
            resumen.Show();
            this.Close();
        }
    }
}
