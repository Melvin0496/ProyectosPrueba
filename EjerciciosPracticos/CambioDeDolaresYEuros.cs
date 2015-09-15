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
    public partial class CambioDeDolaresYEuros : Form
    {
        public CambioDeDolaresYEuros()
        {
            InitializeComponent();
        }

        private void Convertirbutton_Click(object sender, EventArgs e)
        {
            if (DolaresradioButton.Checked)
            {
                double dolares = Convert.ToDouble(DolarestextBox.Text);
                double resultado = dolares * 0.89;

                EurostextBox.Text = Convert.ToString(resultado);
         
            }else if(EurosradioButton.Checked)
            {
                double euros = Convert.ToDouble(EurostextBox.Text);
                double resultado = euros * 1.12;

                DolarestextBox.Text = Convert.ToString(resultado);
            }
               
        }
    }
}
