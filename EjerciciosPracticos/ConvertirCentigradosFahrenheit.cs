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
    public partial class ConvertirCentigradosFahrenheit : Form
    {
        public ConvertirCentigradosFahrenheit()
        {
            InitializeComponent();
        }

        private void Convertirbutton_Click(object sender, EventArgs e)
        {
            double centigrados = Convert.ToDouble(CentigradostextBox.Text);
            double resultado = (centigrados * 9 / 5) + 32;

            FahrenheittextBox.Text = Convert.ToString(resultado);
        }
    }
}
