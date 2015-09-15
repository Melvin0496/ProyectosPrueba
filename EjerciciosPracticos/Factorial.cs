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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        public int Factor(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return numero;
            }
            else
                return numero * Factor(numero - 1);
           
        }
        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(NumerotextBox.Text);
            FactorialtextBox.Text = Convert.ToString(Factor(num));
        }
    }
}
