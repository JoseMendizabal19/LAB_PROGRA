using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L9___JFMR_1227921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

           string Marca;
           int Precio;
           int Modelo;
           string Disponible;
           int DescuentoAplicado;
           int TipoCambioDolar;

            
        if (!int.TryParse(txt_Precio.Text, out int num))
            {
                MessageBox.Show("Debe ingresar un número");
            }
        else
            {
                if (!int.TryParse(txt_Modelo.Text, out int num2))
                {
                    MessageBox.Show("Debe ingresar números no letras");
                }

        else
                {
                    if(!int.TryParse(txt_DescuentoAplicado.Text, out int num3))
                    {
                        MessageBox.Show("Debe de ingresar números");
                    }

                }
            
            }

        }

        private void lbl_marca_Click(object sender, EventArgs e)
        {

        }
    }

}
