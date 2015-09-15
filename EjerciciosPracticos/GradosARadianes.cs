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
    public partial class GradosARadianes : Form
    {
        public GradosARadianes()
        {
            InitializeComponent();
        }

        public void Conversion()
        {
            double grados = Convert.ToDouble(GradostextBox.Text);
            double Resultado = (grados * 3.1416) / 180;

            ResultadotextBox.Text = Convert.ToString(Resultado);
        }
        private void Convertirbutton_Click(object sender, EventArgs e)
        {
            Conversion();
        }
    }
}
