using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>()
            {
                "favoritos", "carrito"
            };
            comboBox1.DataSource = lista;
           
           
           
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
          

            if (comboBox1.Text == "favoritos")
            {

                listBox1.Items.Add(("Producto :"+ textNombre.Text + "," +"Precio :"+ int.Parse(textPrecio.Text)));
                

            }
            else
            {
                int suma = int.Parse(texCantidad.Text) * int.Parse(textPrecio.Text);
                listBox2.Items.Add("Producto :" + textNombre.Text + "," + "Cantidad :" + int.Parse(texCantidad.Text) + "," + "Precio :" + int.Parse(textPrecio.Text) + "," +"Total :" + suma);

                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    suma = suma + Convert.ToInt32(textBox1.Text.Substring(i));
                }
                textBox1.Text =Convert.ToString(suma);
               
                  







            }
        }
    }
}
