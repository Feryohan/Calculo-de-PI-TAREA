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
        private void Calculo(double suma, int tiempo)
        {
            double pi = 4 * suma;
            txtBoxResultado.Text = Convert.ToString(pi);
            txtBoxError.Text = String.Format("{0:P20}", (Math.Abs(Math.PI - pi) / Math.PI));
            txtBoxPi.Text = Convert.ToString(Math.PI);
            chartPi.Series["Cálculo de Pi"].Points.AddXY(tiempo, pi);
        }
        #endregion

        //Método para el botón
        private void BttnResolver_Click(object sender, EventArgs e)
        {
            terminos = int.Parse(txtBoxTerminos.Text);

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
            chart.AxisX.Interval = terminos/10;

            chart.AxisY.Minimum = 3.1;
            chart.AxisY.Maximum = 3.2;
            chart.AxisY.Interval = 0.01;

                //Diseño de la gráfica
            chartPi.Series.Add("Cálculo de Pi");
            chartPi.Series["Cálculo de Pi"].ChartType = SeriesChartType.Line;
            chartPi.Series["Cálculo de Pi"].Color = Color.Red;
            chartPi.Series["Cálculo de Pi"].IsVisibleInLegend = false;

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


        //Timer
        int signo = 1;
        double suma = 0;
        int tiempo = 1;
        private void Timer_Tick(object sender, EventArgs e)
        {
            suma +=  (double)(1.0 / (tiempo * 2.0 - 1.0) * signo);
            signo *= -1;
            Calculo(suma, tiempo);
            tiempo += 1;
            if(tiempo > terminos)
            {
                Timer.Stop();
            }
        }

        //Cuando la pantalla se carga
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Tick += Timer_Tick;
        }

        //Botón para limpiar el formulario
        private void BttnLimpiar_Click(object sender, EventArgs e)
        {
            chartPi.Series.Clear();
            Timer.Stop();
            txtBoxResultado.Clear();
            txtBoxTerminos.Clear();
            txtBoxError.Clear();
            suma = 0;
            signo = 1;
            tiempo = 1;
        }
    }
    #endregion
}
