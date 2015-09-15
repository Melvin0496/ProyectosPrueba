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
    public partial class PromedioDeEdad : Form
    {
        public PromedioDeEdad()
        {
            InitializeComponent();
        }
        float promedio = 0,suma = 0,menor = 200,mayor = 0,cont = 0,edad = 0;
        private void Presionarbutton_Click(object sender, EventArgs e)
        {
             promedio += Convert.ToInt32(EdadtextBox.Text);
             cont++;
            float.TryParse(EdadtextBox.Text, out edad);

            if(edad > mayor)
            {
                mayor = edad;
            }
            if(edad < menor)
            {
                menor = edad;
            }
            PromediotextBox.Text = (promedio / cont).ToString();
            MayortextBox.Text = Convert.ToString(mayor);
            MenortextBox.Text = Convert.ToString(menor);
            EdadtextBox.Text = " ";
            

         
        }
    }
}
