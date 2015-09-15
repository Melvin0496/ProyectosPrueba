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
    public partial class PoligonoRegular : Form
    {
        public PoligonoRegular()
        {
            InitializeComponent();
        }

        public void Perimero()
        {
            double numeroDeLados = Convert.ToDouble(NumerosDeLadostextBox.Text);
            double longitudDelLado = Convert.ToDouble(LongitudDelLadotextBox.Text);
            double resultado = numeroDeLados * longitudDelLado;

            PerimetrotextBox.Text = Convert.ToString(resultado);
        }
        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            Perimero();
        }
    }
}
