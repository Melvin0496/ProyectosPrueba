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
    public partial class Perimetro : Form
    {
        public Perimetro()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            double numeroLados = Convert.ToDouble(NumeroLadostextBox.Text);
            double longitudLados = Convert.ToDouble(LongitudLadotextBox.Text);

            double perimetro = numeroLados * longitudLados;

            PerimetrotextBox.Text = Convert.ToString(perimetro);
        }
    }
}
