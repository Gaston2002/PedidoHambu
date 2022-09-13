using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fronem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            ListaPedidos Pedidos = new ListaPedidos();
            Pedidos.Nombre = lblTOTAL.Text;
           


            Hamburguesa pepe = new Hamburguesa();
            //int total = 0;
            //int cantidad;

            if (radioButton1.Checked == true)
            {

                pepe.Nombre = "Hamburguesa simple $400"; //simple

                pepe.Precio = 400;

                pepe.Cantidad = System.Convert.ToInt32(CantidadCont.Value);

                lblTOTAL.Text = pepe.CalNom();
                


            }

            if (radioButton2.Checked == true)
            {
                pepe.Nombre = "Hamburguesa doble $560"; ;

                pepe.Precio = 560;

                pepe.Cantidad = System.Convert.ToInt32(CantidadCont.Value);

                lblTOTAL.Text = pepe.CalNom();
            }

            if (radioButton3.Checked == true)
            {
                pepe.Nombre = "Hamburguesa triple $700"; ;

                pepe.Precio = 700;

                pepe.Cantidad = System.Convert.ToInt32(CantidadCont.Value);

                lblTOTAL.Text = pepe.CalNom();
            }

            if (radioButton4.Checked == true)
            {
                pepe.Nombre = "Hamburguesa de la casa $890"; //simple

                pepe.Precio = 890;

                pepe.Cantidad = System.Convert.ToInt32(CantidadCont.Value);

                lblTOTAL.Text = pepe.CalNom();
            }
        }
    }
}
