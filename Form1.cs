using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria para el chart
using System.Windows.Forms.DataVisualization.Charting;

namespace Calculo_de_PI
{
    public partial class Form1 : Form
    {
        #region Atributos
        int terminos;
        #endregion

        #region Métodos
        public Form1()
        {
            InitializeComponent();
        }

        #region Calculos
        //Método que muestra el valor de pi y el de la precision
        //También grafica los resultados
        private void Calculo(double suma,double sumaAnterior, int tiempo)
        {
            double pi = Math.Sqrt( 6 * suma);
            double piAnterior = Math.Sqrt(6 * sumaAnterior);
            txtBoxResultado.Text = Convert.ToString(pi);
            txtBoxError.Text = String.Format("{0:P20}", (Math.Abs(Math.PI - pi) / Math.PI));
            txtBoxPi.Text = Convert.ToString(Math.PI);
            chartPi.Series["Cálculo de Pi"].Points.AddXY(tiempo, pi);
            chartPendiente.Series["Cálculo de la pendiente"].Points.AddXY(tiempo, pi - piAnterior);
            txtBoxPendiente.Text = Convert.ToString(pi - piAnterior);
        }

        #endregion

        #region Gráficas
        private void GraficaPi()
        {
            //Construcción de la gráfica
            //El área de los rectángulos es cero
            var chart = chartPi.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            //Se pone nulo para que el numeros aparézcan en los ejes
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";

            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            //Medidas del gráfico
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = terminos;
            chart.AxisX.Interval = terminos / 10;

            chart.AxisY.Minimum = 2.4;
            chart.AxisY.Maximum = 3.2;
            chart.AxisY.Interval = 0.1;

            //Diseño de la gráfica
            chartPi.Series.Add("Cálculo de Pi");
            chartPi.Series["Cálculo de Pi"].ChartType = SeriesChartType.Line;
            chartPi.Series["Cálculo de Pi"].Color = Color.Purple;
            chartPi.Series["Cálculo de Pi"].IsVisibleInLegend = false;
        }
        private void GraficaPendiente()
        {
            //Construcción de la gráfica
            //El área de los rectángulos es cero
            var chart = chartPendiente.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            //Se pone nulo para que el numeros aparézcan en los ejes
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";

            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            //Medidas del gráfico
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = terminos;
            chart.AxisX.Interval = terminos / 10;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 2.5;
            chart.AxisY.Interval = 0.3;

            //Diseño de la gráfica
            chartPendiente.Series.Add("Cálculo de la pendiente");
            chartPendiente.Series["Cálculo de la pendiente"].ChartType = SeriesChartType.Line;
            chartPendiente.Series["Cálculo de la pendiente"].Color = Color.DarkGreen;
            chartPendiente.Series["Cálculo de la pendiente"].IsVisibleInLegend = false;
        }
        #endregion

        #region Botón
        //Método para el botón
        private void BttnResolver_Click(object sender, EventArgs e)
        {
            terminos = int.Parse(txtBoxTerminos.Text);

            //Gráficas
            GraficaPi();
            GraficaPendiente();

            //Inicio del Timer
            if (Timer.Enabled)
            {
                Timer.Stop();
            }
            else
            {
                Timer.Start();
            }
        }
        #endregion

        #region Timer
        //Timer
        double sumaAnterior;
        double suma = 0;
        int tiempo = 1;
        private void Timer_Tick(object sender, EventArgs e)
        {
            sumaAnterior = suma;
            suma +=  (double)(1.0 / Math.Pow(tiempo,2) );
            Calculo(suma, sumaAnterior, tiempo);
            tiempo += 1;
            if(tiempo > terminos)
            {
                Timer.Stop();
            }
        }
        #endregion

        //Cuando la pantalla se carga
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Tick += Timer_Tick;
        }

        //Botón para limpiar el formulario
        private void BttnLimpiar_Click(object sender, EventArgs e)
        {
            chartPi.Series.Clear();
            chartPendiente.Series.Clear();
            Timer.Stop();
            txtBoxResultado.Clear();
            txtBoxTerminos.Clear();
            txtBoxError.Clear();
            txtBoxPendiente.Clear();
            suma = 0;
            tiempo = 1;
        }
    }
    #endregion
}
