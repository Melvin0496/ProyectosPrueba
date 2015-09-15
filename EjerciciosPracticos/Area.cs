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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            double numeroLados = Convert.ToDouble(NumeroLadostextBox.Text);
            double longitudLados = Convert.ToDouble(LongitudLadotextBox.Text);
            double apotema = Convert.ToDouble(ApotematextBox.Text);

            double area = (numeroLados * longitudLados) * apotema / 2;

            AreatextBox.Text = Convert.ToString(area);
        }
    }
}
