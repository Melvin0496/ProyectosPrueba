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
    public partial class ConvertirDeGradosAradianesYViceversa : Form
    {
        public ConvertirDeGradosAradianesYViceversa()
        {
            InitializeComponent();
        }

        private void Empezarbutton_Click(object sender, EventArgs e)
        {
            if(GradosARadianesradioButton.Checked)
            {
                ConvertirDeGradosARadianesFunciones gf = new ConvertirDeGradosARadianesFunciones();
                gf.Show();
            }else if(RadianesAGradosradioButton.Checked)
            {
                ConvertirDeRadianesAGrados crg = new ConvertirDeRadianesAGrados();
                crg.Show();
            }
        }
    }
}
