using System;
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
    public partial class Potencia : Form
    {
        public Potencia()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(NumerotextBox.Text);
            int exponente = Convert.ToInt32(ExponentetextBox.Text);
            int potencia = numero;
            for (int x = 1; x < exponente; x++)
            {
                potencia *= numero;
            }
            PotenciatextBox.Text = Convert.ToString(potencia);
        }
    }
}
