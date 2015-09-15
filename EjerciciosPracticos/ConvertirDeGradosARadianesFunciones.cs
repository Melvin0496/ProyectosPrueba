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
    public partial class ConvertirDeGradosARadianesFunciones : Form
    {
        public ConvertirDeGradosARadianesFunciones()
        {
            InitializeComponent();
        }

        public double Conversion()
        {
            double grados = Convert.ToDouble(GradostextBox.Text);
            

            return (grados * 3.1415) / 180;
        }
        private void Convertirbutton_Click(object sender, EventArgs e)
        {
            RadianestextBox.Text = Convert.ToString(Conversion());
        }
    }
}
