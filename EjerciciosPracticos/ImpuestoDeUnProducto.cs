﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosPracticos
{
    public partial class ImpuestoDeUnProducto : Form
    {
        public ImpuestoDeUnProducto()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(PreciotextBox.Text);
            double resultado;


            if (TipotextBox.Text == "Medicina" || TipotextBox.Text == "medicina")
            {
                ITBIStextBox.Text = "0";
                PrecioNetotextBox.Text = Convert.ToString(precio);
            }
            else
            {

                ITBIStextBox.Text = "18%";
                resultado = precio + (precio * 0.18);
                PrecioNetotextBox.Text = Convert.ToString(resultado);

            }

        }
    }
}
