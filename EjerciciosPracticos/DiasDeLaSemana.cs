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
    public partial class DiasDeLaSemana : Form
    {
        public DiasDeLaSemana()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            int numeros = Convert.ToInt32(NumerotextBox.Text);
            
            switch(numeros)
            {
                case 1:
                    Numerolabel.Text = "Domingo";
                    break;
                case 2:
                    Numerolabel.Text = "Lunes";
                    break;
                case 3:
                    Numerolabel.Text = "Martes";
                    break;
                case 4:
                    Numerolabel.Text = "Miercoles";
                    break;
                case 5:
                    Numerolabel.Text = "Jueves";
                    break;
                case 6:
                    Numerolabel.Text = "Viernes";
                    break;
                case 7:
                    Numerolabel.Text = "Sabado";
                    break;

            }



        }
    }
}
