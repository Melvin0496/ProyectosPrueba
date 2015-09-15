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
    public partial class PerimetroYArea : Form
    {
        public PerimetroYArea()
        {
            InitializeComponent();
        }

        private void Presionarbutton_Click(object sender, EventArgs e)
        {
            if (PerimetroradioButton.Checked)
            {
                Perimetro p = new Perimetro();
                p.Show();
            }
            else if (ArearadioButton.Checked)
            {
                Area a = new Area();
                a.Show();
            }
        }
    }
}
