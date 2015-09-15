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
    public partial class PoligonoRegularFunciones : Form
    {
        public PoligonoRegularFunciones()
        {
            InitializeComponent();
        }

        public double PoligonRegular()
        {
            double numLados = Convert.ToDouble(NumerosLadostextBox.Text);
            double lonLados = Convert.ToDouble(LongitudLadostextBox.Text);

            return numLados * lonLados;
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            

            ResultadotextBox.Text = Convert.ToString(PoligonRegular());
        }
    }
}
