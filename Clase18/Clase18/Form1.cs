using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase18
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Camisa_CheckedChanged(object sender, EventArgs e)
        {
            checkBermuda.Enabled = false;
            checkBermuda.Checked = false;
            checkMangaCorta.Enabled = true;
        }

        private void Pantalon_CheckedChanged(object sender, EventArgs e)
        {
            checkMangaCorta.Enabled = false;
            checkMangaCorta.Checked = false;
            checkBermuda.Enabled = true;
        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textPrecio.Text, out int precio))
            {
                textPrecio.ForeColor = Color.Black;
            }
            else
            {
                textPrecio.ForeColor = Color.Red;
            }
        }

        private void textCantidad_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textCantidad.Text, out int cantidad))
            {
                textCantidad.ForeColor = Color.Black;
            }
            else
            {
                textCantidad.ForeColor = Color.Red;
            }
        }

        private bool calidadRopa()
        {
            if(!radioStandard.Checked && !radioPremium.Checked)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool comprobarPrecio()
        {
            if(int.TryParse(textPrecio.Text, out int precio) && int.TryParse(textCantidad.Text, out int cantidad))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonCalcularPrecio_Click(object sender, EventArgs e)
        {
            if(!comprobarPrecio() || !calidadRopa())
            {
                Console.WriteLine("Valor incorrecto. Intentelo nuevamente.");
            }
            else
            {
                int precio = int.Parse(textPrecio.Text);
                int cantidad = int.Parse(textCantidad.Text);
                bool calidadPremium = radioPremium.Checked;

                if (Camisa.Checked)
                {
                    Camisa myCamisa = new Camisa(precio,calidadPremium);
                    bool mangas = checkMangaCorta.Checked;
                    double precioPorCamisa = myCamisa.precio();

                    int total = (int) (precioPorCamisa * cantidad);

                    mostrarPrecio.Text = "El precio final es de: " + total;

                }

                if (Pantalon.Checked)
                {
                    bool bermuda = checkBermuda.Checked;

                    Pantalon myPantalon = new Pantalon(precio,calidadPremium);
                    double precioPantalon = myPantalon.precio();
                    double total = (int)(precioPantalon * cantidad);
                    mostrarPrecio.Text = "Precio final:" + total;
                }
            }


        }
    }
}
