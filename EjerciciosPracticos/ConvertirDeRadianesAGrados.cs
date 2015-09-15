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
    public partial class ConvertirDeRadianesAGrados : Form
    {
        public ConvertirDeRadianesAGrados()
        {
            InitializeComponent();
        }

        private void ConvertirDeRadianesAGrados_Load(object sender, EventArgs e)
        {

        }

        private void Convertirbutton_Click(object sender, EventArgs e)
        {
            double radianes = Convert.ToDouble(RadianestextBox.Text);
            double resultado = radianes * 180 / 3.1416;

            GradostextBox.Text = Convert.ToString(resultado);

            
        }
    }
}
