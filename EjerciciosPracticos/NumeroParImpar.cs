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
    public partial class NumeroParImpar : Form
    {
        public NumeroParImpar()
        {
            InitializeComponent();
        }

        private void Presionabutton_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(NumerotextBox.Text);
            if (num % 2 == 0)
            {
                Resultadolabel.Text = "El numero es par";
            }
            else
                Resultadolabel.Text = "El numero es impar";
        }
    }
}
