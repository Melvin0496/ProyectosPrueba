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
    public partial class TablaDeMultiplicar : Form
    {
        public TablaDeMultiplicar()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(NumerotextBox.Text);
            int resultado;

            for (int x = 1;x <= 10;x++)
            {
                resultado = x * numero;
                TablarichTextBox.Text += Convert.ToString(numero+ " * " +x+" = "+resultado+"\n");
                
            } 
        }
    }
}
