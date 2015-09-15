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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void capitulo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirNombre n = new ImprimirNombre();
            n.Show();
        }

        private void perimetroPoligonoRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoligonoRegular pr = new PoligonoRegular();
            pr.Show();
        }

        private void convertirDeGradosARadianesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradosARadianes ga = new GradosARadianes();
            ga.Show();
        }

        private void convertirDeDolaresAEurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambioDeDolaresYEuros cd = new CambioDeDolaresYEuros();
            cd.Show();
        }

        private void convertirDeCentigradosAFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertirCentigradosFahrenheit cf = new ConvertirCentigradosFahrenheit();
            cf.Show();
        }

        private void numeroParOImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumeroParImpar np = new NumeroParImpar();
            np.Show();
        }

        private void calculoDeITBISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImpuestoDeUnProducto ip = new ImpuestoDeUnProducto();
            ip.Show();
        }

        private void diasDeLaSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiasDeLaSemana ds = new DiasDeLaSemana();
            ds.Show();
        }

        private void périmetroYAreaDeUnPoligonoRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerimetroYArea pa = new PerimetroYArea();
            pa.Show();
        }

        private void potenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Potencia p = new Potencia();
            p.Show();
        }

        private void tablaDeMultiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaDeMultiplicar tm = new TablaDeMultiplicar();
            tm.Show();
        }

        private void capitulo4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void capitulo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio51ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertirDeGradosARadianesFunciones c = new ConvertirDeGradosARadianesFunciones();
            c.Show();

        }

        private void ejercicio52ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertirDeCentigradosAFahrenheitFunciones cg = new ConvertirDeCentigradosAFahrenheitFunciones();
            cg.Show();
        }

        private void ejercicio54ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factorial f = new Factorial();
            f.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe ad = new AcercaDe();
            ad.Show();
        }

        private void ejercicio45ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromedioDeEdad pe = new PromedioDeEdad();
            pe.Show();
        }

        private void ejercicio32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConvertirDeGradosAradianesYViceversa cog = new ConvertirDeGradosAradianesYViceversa();
            cog.Show();
        }

        private void ejercicio43ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio44ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumeroPrimos np = new NumeroPrimos();
            np.Show();
        }

        private void ejercicio53ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoligonoRegularFunciones pr = new PoligonoRegularFunciones();
            pr.Show();
        }
    }
}
