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
using static AngouriMath.Entity;

namespace Analisis_Numerico_Sistema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string funcionGrafica = "";
        

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_solucion.AllowUserToAddRows = false;
            dgv_solucion.Rows.Add("0","0");
            dgv_solucion.Rows.Add("0", "0");
            dgv_solucion.Rows.Add("0", "0");
            dgv_solucion.Rows.Add("0", "0");
        }

        private void pbx_mas_Click(object sender, EventArgs e)
        {
            dgv_solucion.Rows.Add("0", "0");
        }

        private void pbx_menos_Click(object sender, EventArgs e)
        {
            if (dgv_solucion.Rows.Count > 3)
                dgv_solucion.Rows.RemoveAt(dgv_solucion.Rows.Count - 1);
            else
                MessageBox.Show("El mínimo de valores para x es 3","No es posible completar la acción",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (verificarValoresDiferentesx())
            {
                try
                {
                    //limpiar();
                    rtb_proceso.Clear();
                    //rtb_adicional.Clear();

                    //OBTENER MATRIZ PARA RESOLVER EL SISTEMA DE ECUACIONES
                    int n = dgv_solucion.Rows.Count;
                    double[,] matriz = new double[n, n + 1];
                    foreach (DataGridViewRow row in dgv_solucion.Rows)
                    {
                        matriz[row.Index, 0] = 1;
                        matriz[row.Index, 1] = Convert.ToDouble(dgv_solucion.Rows[row.Index].Cells[0].Value.ToString().Trim());
                        matriz[row.Index, n] = Convert.ToDouble(dgv_solucion.Rows[row.Index].Cells[1].Value.ToString().Trim());
                        for (int i = 1; i < n; i++)
                        {
                            matriz[row.Index, i] = Math.Pow(matriz[row.Index, 1], i);
                        }
                    }

                    rtb_proceso.AppendText("EN BASE A LA INFORMACION INGRESADA SE TIENE LA SIGUIENTE MATRIZ\n");
                    imprimirMatriz(matriz, n);

                    rtb_proceso.AppendText("SE RESOLVERÁ POR EL METODO DE GAUSS-JORDAN\n");

                    //GAUSS-JORDAN
                    double pivote = 0;
                    //x es una variable que dice por cuanto hay que multiplicar para hacer 0 los numeros de la columna del pivote
                    double x = 0;

                    for (int i = 0; i < n; i++)
                    {

                        //se obtiene el pivote en la posicion i,i para ir por la diagonal
                        pivote = matriz[i, i];

                        for (int j = i; j <= n; j++)
                        {
                            //Se divide a la fila completa entre el pivote, esto lo hace aunque el pivote sea 1, no afecta:)
                            matriz[i, j] = matriz[i, j] / pivote;

                        }

                        for (int k = 0; k < n; k++)
                        {
                            if (k != i)//Mientras no estemos en el pivote
                            {
                                x = matriz[k, i];//Se obtiene el valor de la posicion actual para multiplicar y hacer 0 los valores de la columna del pivote
                                for (int l = i; l <= n; l++)
                                {
                                    //Se actualizan todos los valores haciendo la resta de 1 fila menos la otra
                                    matriz[k, l] = matriz[k, l] - x * matriz[i, l];
                                }
                            }
                            imprimirMatriz(matriz, n);
                        }
                    }
                    string funcion = "";

                     
                    //CONVERTIR LOS RESULTADOS DE GAUSS-JORDAN PARA ESCRIBIR LA FUNCION
                    int elementosFuncion = 0;
                    for (int i = n - 1; i >= 0; i--)
                    {

                        if (matriz[i, n] != 0)
                        {
                            if (elementosFuncion != 0)
                            {
                                funcion = funcion + "+";
                            }
                            if (i == 0)
                            {
                                //rtb_resultado.AppendText(Convert.ToString(matriz[i, n]) + "x");
                                funcion = funcion + Convert.ToString(matriz[i, n]);
                            }
                            else if (i == 1)
                            {
                                //rtb_resultado.AppendText(Convert.ToString(matriz[i, n]) + "x");
                                funcion = funcion + Convert.ToString(matriz[i, n]) + "x";
                            }
                            else
                            {
                                //rtb_resultado.AppendText(Convert.ToString(matriz[i, n]) + "x^" + i);
                                funcion = funcion + Convert.ToString(matriz[i, n]) + "x^" + i;
                            }
                            elementosFuncion++;

                        }
                    }

                    //EVALUACION DE LA FUNCION
                    Entity expresion = funcion;

                    //MOSTRAR RESULTADOS
                    rtb_proceso.AppendText("PROCESO FINALIZADO, LA FUNCIÓN OBTENIDA ES:\n f(x)=" + funcion);
                    pbx_Ecuacion.Image = new Bitmap(EcuacionPNG.CrearEcuacion("f(x)= " + expresion.Latexise()));
                    pbx_Evaluacion.Image = new Bitmap(EcuacionPNG.CrearEcuacion("f(" + num_x.Value + ")=" + EvaluarExpresion((double)num_x.Value, funcion)));
                    CargarGrafica(funcion);
                    //rtb_adicional.AppendText("\nRAICES DE LA FUNCIÓN:\n");
                    //rtb_adicional.AppendText(Convert.ToString(expresion.SolveEquation("x")));

                    //btn_grafica.Enabled = true;
                    btn_zoom.Enabled = true;
                    //GUARDAR LA FUNCION POR SI SE DESEA GRAFICAR
                    funcionGrafica = funcion;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hubo un error al realizar los calculos \n\n MENSAJE DE EXCEPCION"+ex , "Verificar Datos o introducir nuevos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Los valores de x deben ser diferentes","Verificar Datos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private double EvaluarExpresion(double x,string expresion)
        {
            //ESTA FUNCION NOS REGRESA EL VALOR DE LA FUNCION EVALUADA EN UN VALOR
            try
            {
                string expresionSustituidaConX = expresion.Replace("x", "("+x.ToString()+")");
                Entity expresion1 = expresionSustituidaConX;
                double expresionEvaluada = ((double)expresion1.EvalNumerical());
                return expresionEvaluada;
            }
            catch (Exception e)
            {
                //MessageBox.Show("Verificar la correcta escritura de los datos, no fue posible evaluar la funcion \n MENSAJE DE EXCEPCION"+e, "ERROR AL EVALUAR LA FUNCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        void imprimirMatriz(double[,] m, int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    rtb_proceso.AppendText(m[i, j] + "\t");
                }
                rtb_proceso.AppendText("\n");
            }
            rtb_proceso.AppendText("\n\n");
        }

        
        private void limpiar()
        {
            funcionGrafica = "";
            chart1.Series["Funcion"].Points.Clear();
            //btn_grafica.Enabled = false;
            btn_zoom.Enabled = false;
            dgv_solucion.Rows.Clear();
            rtb_proceso.Clear();
            //rtb_adicional.Clear();
            //rtb_resultado.Clear();
            pbx_Evaluacion.Image = null;
            pbx_Ecuacion.Image = null;
            num_x.Value = 0;
            //rtb_adicional.Clear();
            dgv_solucion.Rows.Add("0", "0");
            dgv_solucion.Rows.Add("0", "0");
            dgv_solucion.Rows.Add("0", "0");
            dgv_solucion.Rows.Add("0", "0");

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        private void CargarGrafica(string funcion)
        {
            chart1.Series["Funcion"].Points.Clear();

            for (int i = 0; i <= 15; i++)
            {
                //SUSUTUTUIR POR EVALUACION DE LA FUNCION
                this.chart1.Series["Funcion"].Points.AddXY(i, EvaluarExpresion(i, funcion));
            }
        }
        private void btn_zoom_Click(object sender, EventArgs e)
        {
            Grafica grafica = new Grafica();
            grafica.funcion = funcionGrafica;
            grafica.ShowDialog();
        }

        private void dgv_solucion_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 0) // 1 should be your column index
            {
                double i;

                if (!double.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("El contenido debe ser un numero","Error al ingresar datos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                } 
            }
        }

        private bool verificarValoresDiferentesx()
        {
            bool valoresDiferentes = true;
            for (int i= 0; i< dgv_solucion.Rows.Count;i++)
            {
                for(int j = 0; j < dgv_solucion.Rows.Count; j++)
                {
                    if ((Convert.ToDouble(dgv_solucion.Rows[i].Cells["x"].Value)== Convert.ToDouble(dgv_solucion.Rows[j].Cells["x"].Value)) && i!=j)
                    {
                        valoresDiferentes = false;
                        break;
                    }
                }
                if (!valoresDiferentes)
                    break;
            }
            return valoresDiferentes;
        }

        private void px_info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }
    }
}
