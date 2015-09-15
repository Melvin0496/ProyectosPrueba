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
    public partial class ConvertirDeCentigradosAFahrenheitFunciones : Form
    {
        public ConvertirDeCentigradosAFahrenheitFunciones()
        {
            InitializeComponent();
        }

        public double Conversion()
        {
            double centigrados = Convert.ToDouble(CentigradostextBox.Text);
            return (centigrados * 9 / 5) + 32;

            
        }
        private void Convertirbutton_Click(object sender, EventArgs e)
        {
            FahrenheittextBox.Text = Convert.ToString(Conversion());
        }
    }
}
