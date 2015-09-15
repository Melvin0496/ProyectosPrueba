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
    public partial class NumeroPrimos : Form
    {
        public NumeroPrimos()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int cont = 0;
            for (int x = 2; x <= 1000; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                    {
                        cont++;
                    }
                }
                if (cont < 3)
                {
                    PrimorichTextBox.Text += Convert.ToString(x+"\n");
                }
                cont = 0;
            }
        }
    }
}
