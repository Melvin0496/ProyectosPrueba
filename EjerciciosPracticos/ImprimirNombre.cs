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
    public partial class ImprimirNombre : Form
    {
        public ImprimirNombre()
        {
            InitializeComponent();
        }

        private void Presionarbutton_Click(object sender, EventArgs e)
        {
            Nombrelabel.Text = "Melvin Gabriel";
        }
    }
}
