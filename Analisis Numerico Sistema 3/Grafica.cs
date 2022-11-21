using AngouriMath;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_Numerico_Sistema_3
{
    public partial class Grafica : Form
    {
        public  string funcion { get; set; }
        public Grafica()
        {
            InitializeComponent();
        }

        int puntos = 10;

        private void Grafica_Load(object sender, EventArgs e)
        {
            CargarGrafica();
        }

        private void CargarGrafica()
        {
            chart1.Series["Funcion"].Points.Clear();
            if (cbx_Negativos.Checked==true)
            {
                for ( int i = -1*puntos; i <= puntos; i++)
                {
                    //SUSUTUTUIR POR EVALUACION DE LA FUNCION
                    this.chart1.Series["Funcion"].Points.AddXY(i, EvaluarExpresion(i,funcion)) ;
                }
            }
            else
            {
                for (int i = 0 ; i <= puntos; i++)
                {
                    //SUSUTUTUIR POR EVALUACION DE LA FUNCION
                    this.chart1.Series["Funcion"].Points.AddXY(i, EvaluarExpresion(i, funcion));
                }
            } 
        }

        private double EvaluarExpresion(double x, string expresion)
        {
            //ESTA FUNCION NOS REGRESA EL VALOR DE LA FUNCION EVALUADA EN UN VALOR
            try
            {
                string expresionSustituidaConX = expresion.Replace("x", "(" + x.ToString() + ")");
                Entity expresion1 = expresionSustituidaConX;
                double expresionEvaluada = ((double)expresion1.EvalNumerical());
                return expresionEvaluada;
            }
            catch (Exception e)
            {
                MessageBox.Show("Verificar la correcta escritura de la funcion, o seleccionar otros intervalos \n MENSAJE DE EXCEPCION" + e, "ERROR AL EVALUAR LA FUNCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        private void cbx_Negativos_CheckedChanged(object sender, EventArgs e)
        {
            CargarGrafica();
        }

        private void pbx_menos_Click(object sender, EventArgs e)
        {
            if(puntos>5)
            puntos = puntos - 5;

            CargarGrafica();
        }

        private void pbx_mas_Click(object sender, EventArgs e)
        {
            puntos = puntos + 5;
            CargarGrafica();
        }
    }
}
