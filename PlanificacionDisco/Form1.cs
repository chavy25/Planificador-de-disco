using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PlanificacionDisco
{
    public partial class Form1 : Form
    {
        //definicion de la clase disco
        Disco hdd;
        //variables de sumatoria de desplazamiento para cada algorritmo
        int desFifo, desSsf, desScan, descScan;
        public Form1()
        {
            InitializeComponent();

            //Se agregan las series del grafico
            this.chartPrincipal.Series.Clear();
            this.chartPrincipal.Series.Add("FIFO").ChartType = SeriesChartType.Line;
            this.chartPrincipal.Series.Add("SSF").ChartType = SeriesChartType.Line;
            this.chartPrincipal.Series.Add("SCAN").ChartType = SeriesChartType.Line;
            this.chartPrincipal.Series.Add("CSCAN").ChartType = SeriesChartType.Line;

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Evento click del boton graficar, valida los datos ingresados y llama a los metodos de cada algoritmo para graficar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSize.Text) || string.IsNullOrEmpty(txtQueue.Text) || string.IsNullOrEmpty(txtInicio.Text))//si no ingreso texto, despliega mensaje de error
                {

                    MessageBox.Show("Por favor ingrese los valores NECESARIOS", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (validarNumero(txtSize.Text) || validarNumero(txtQueue.Text) || validarNumero(txtInicio.Text))//si no ingreso valores numéricos, despliega mensaje de error
                {

                    MessageBox.Show("Por favor ingrese solo valores NUMERALES - NOVATO", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    hdd = new Disco();//secrea un nuevo disco
                    hdd.Tamaño = int.Parse(txtSize.Text);//se agrega el tamaño
                    hdd.Inicio = int.Parse(txtInicio.Text);//se agrega el tamaño
                    hdd.Peticiones = new int[txtQueue.Text.Split(' ').Length];//se agregan la cola de peticiones

                    for (int desp = 0; desp < txtQueue.Text.Split(' ').Length; desp++) //se agregan las peticiones de desplazamiento al disco
                    {
                        hdd.Peticiones[desp] = int.Parse(txtQueue.Text.Split(' ')[desp]);

                    }

                    if (hdd.Peticiones.Any(x => x > hdd.Tamaño))//si ingresa un desplazamiento mayor al tamaño total, despliega un mensaje de error
                    {
                        MessageBox.Show("Por favor ingrese un disco duro con el tamaño suficiente - NOVATO", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.chartPrincipal.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount; //crea el intervalo de valores de eje Y automatico
                        this.chartPrincipal.ChartAreas[0].AxisY.Maximum = hdd.Tamaño; //asigna el valor maximo de dependientes
                        planFifo();
                        planSSF();
                        planScan();
                        planCScan();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "OJO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Boolean validarNumero(string valores)
        {
            return valores.All(char.IsLetter);
        }

        /// <summary>
        /// Grafica el algoritmo de desplazamiento FIFO y almacena los desplazamientos
        /// </summary>
        public void planFifo()
        {
            this.chartPrincipal.Series["FIFO"].MarkerStyle = MarkerStyle.Triangle;//se le asigna a la grafica a marcar los puntos con un circulo

            desFifo = Math.Abs(hdd.Inicio - hdd.Peticiones[0]);//se suman los desplazamientos desde el punto de inicio
            this.chartPrincipal.Series["FIFO"].Points.Add(hdd.Inicio);//se agrega el punto de inicio a la grafica
            for (int i = 0; i < hdd.Peticiones.Length; i++)
            {
                if ((i + 1) != hdd.Peticiones.Length)
                {
                    desFifo += Math.Abs(hdd.Peticiones[i] - hdd.Peticiones[i + 1]);//suma la resta absoluta del primer y segundo desplazamiento
                    this.chartPrincipal.Series["FIFO"].Points.Add(hdd.Peticiones[i]);//grafica en el punto de inicio al siguiente desplazamiento mas cerca
                }
                else
                {
                    this.chartPrincipal.Series["FIFO"].Points.Add(hdd.Peticiones[i]);
                }

            }

            lblFifo.Text = desFifo.ToString();//carga el numero total de desplazamientos en el label
            Thread.Sleep(500);
        }


        /// <summary>
        /// Grafica los desplazamientos en los cilindros por el mas cerca y almacena los desplazamientos
        /// </summary>
        public void planSSF()
        {

            this.chartPrincipal.Series["SSF"].MarkerStyle = MarkerStyle.Triangle; //determina el tipo de marcador de la linea de la grafica
            var arregloSsf = hdd.Peticiones.OrderBy(x => Math.Abs(hdd.Inicio - x)).ToArray();//ordena la cola de peticiones de peticiones del más cercano al punto de partida

            desSsf = Math.Abs(hdd.Inicio - arregloSsf[0]);//si el punto de partida no esta en la cola de peticiones se añade al calculo
            if (!arregloSsf.Any(x => x == hdd.Inicio))
                this.chartPrincipal.Series["SSF"].Points.Add(hdd.Inicio).BorderWidth = 2;

            for (int i = 0; i < arregloSsf.Length; i++) //itera cada punto de la cola de peticiones
            {
                if ((i + 1) != arregloSsf.Length)
                {
                    desSsf += Math.Abs(arregloSsf[i] - arregloSsf[i + 1]);//suma el recorrido del punto uno al siguiente
                    this.chartPrincipal.Series["SSF"].Points.Add(arregloSsf[i]).BorderWidth = 2;//se añade el punto a la grafica de esta serie
                }
                else
                {
                    this.chartPrincipal.Series["SSF"].Points.Add(arregloSsf[i]).BorderWidth = 2;
                }

            }
            lblSsf.Text = desSsf.ToString();//carga el numero total de desplazamientos en el label

        }


        /// <summary>
        /// Metodo para graficar la planificacion SCAN y sumar los desplazamientos del diso
        /// </summary>
        public void planScan()
        {
            int aux = 1;
            int[] arregloScan = new int[hdd.Peticiones.Length + 2];

            this.chartPrincipal.Series["SCAN"].MarkerStyle = MarkerStyle.Triangle;
            var arregloScanAsc = hdd.Peticiones.OrderBy(x => Math.Min(x, x + 1)).ToArray();//ordena la cola de peticiones de menor a mayor
            var arregloScanDesc = hdd.Peticiones.OrderByDescending(x => x).ToArray();//ordena la cola de peticiones en otro arreglo de mayor a menor

            arregloScan[0] = hdd.Inicio;//asigna el primer valor de la cola de peticiones como el punto de inicio

            for (int z = 1; z <= arregloScanDesc.Length - 1; z++)//asigna a la cola de peticiones scan los valores a la izquierda del punto de inicio
            {
                if (arregloScanDesc[z] < hdd.Inicio)
                {
                    arregloScan[aux] = arregloScanDesc[z];
                    aux++;
                }
            }

            arregloScan[aux] = 0;
            aux++;

            for (int z = 1; z <= arregloScanAsc.Length - 1; z++)//asigna a la cola de peticiones scan los valores a la derecha restante despues de 0
            {
                if (arregloScanAsc[z] > hdd.Inicio)
                {
                    arregloScan[aux] = arregloScanAsc[z];
                    aux++;
                }
            }

            for (int i = 0; i < arregloScan.Length; i++)//indico la cola de peticiones a graficar para este algoritmo
            {
                if ((i + 1) != arregloScan.Length)
                {

                    if (arregloScan[i + 1] == 0)
                    {
                        if ((i + 2) != arregloScan.Length)//si se aproxima al ultimo punto de la cola de peticiones
                        {
                            this.chartPrincipal.Series["SCAN"].Points.Add(arregloScan[i]).BorderWidth = 3;//agrego el punto actual
                            this.chartPrincipal.Series["SCAN"].Points.Add(arregloScan[i + 1]).BorderDashStyle = ChartDashStyle.DashDotDot;//agrego el punto siguiente
                            desScan += Math.Abs(arregloScan[i] - arregloScan[i + 2]);//sumo la diferencia entre el valor actual y el proximo para no sumar el trayecto del y hacia el 0
                            i++;
                        }
                        
                    }
                    else
                    {
                        this.chartPrincipal.Series["SCAN"].Points.Add(arregloScan[i]).BorderWidth = 3;
                        desScan += Math.Abs(arregloScan[i] - arregloScan[i + 1]);
                    }

                }
                else//si ya termino de recorrer el arreglo y queda algún valor en la cola de peticiones, y el valor no es 0, imprime el ultimo valor. 
                {
                    if (arregloScan[i] != 0)
                        this.chartPrincipal.Series["SCAN"].Points.Add(arregloScan[i]).BorderWidth = 3;
                }
            }
            lblScan.Text = desScan.ToString();
        }



        /// <summary>
        /// Funcion para graficar la planificacion del algoritmo CSCAN y sumar los desplazamientos
        /// </summary>
        public void planCScan()
        {

            this.chartPrincipal.Series["CSCAN"].MarkerStyle = MarkerStyle.Triangle;

            var arregloCScan = hdd.Peticiones.OrderBy(x => Math.Min(x, x + 1)).ToArray();//Ordena la cola de peticiones de menor a mayor.
            int aux;


            for (int z = 0; z < arregloCScan.Length - 1; z++)
            {
                aux = arregloCScan[0];//guardo el menor valor, el primer valor de la cola de peticiones.
                if (aux < hdd.Inicio)
                    for (int q = 0; q < arregloCScan.Length - 1; q++)
                    {
                        arregloCScan[q] = arregloCScan[q + 1];//se mueven para el frente del arreglo aquellos valores mayores al punto de partida.
                        if (q + 1 == arregloCScan.Length - 1)
                            arregloCScan[arregloCScan.Length - 1] = aux;//se insertan los valores menores al punto de partida al final del arreglo de peticiones para graficar este algoritmo.
                    }

            }


            var puntoMasAlto = arregloCScan.OrderByDescending(x => x).FirstOrDefault();//se define el punto mas alto de la cola de peticiones

            if (!arregloCScan.Any(x => x == hdd.Inicio))
                this.chartPrincipal.Series["CSCAN"].Points.Add(hdd.Inicio).BorderWidth = 2;

            descScan = Math.Abs(hdd.Inicio - arregloCScan[0]);

            for (int i = 0; i < arregloCScan.Length; i++)
            {
                if ((i + 1) != arregloCScan.Length)
                {
                    if (arregloCScan[i] > hdd.Inicio && arregloCScan[i + 1] > hdd.Inicio)
                        descScan += Math.Abs(arregloCScan[i] - arregloCScan[i + 1]);

                    if (arregloCScan[i] < hdd.Inicio && arregloCScan[i + 1] < hdd.Inicio)
                        descScan += Math.Abs(arregloCScan[i] - arregloCScan[i + 1]);

                    if (arregloCScan[i] == puntoMasAlto)
                    {//si se llega al punto mas alto se agrega ademas el punto 0 como coordenada
                        this.chartPrincipal.Series["CSCAN"].Points.Add(arregloCScan[i]).BorderWidth = 3;
                        this.chartPrincipal.Series["CSCAN"].Points.Add(hdd.Tamaño).BorderDashStyle = ChartDashStyle.DashDotDot;
                        this.chartPrincipal.Series["CSCAN"].Points.Add(0).BorderDashStyle = ChartDashStyle.DashDotDot;
                    }
                    else
                    {
                        if (arregloCScan[i] == hdd.Inicio)
                            descScan += Math.Abs(arregloCScan[i] - arregloCScan[i + 1]);

                        this.chartPrincipal.Series["CSCAN"].Points.Add(arregloCScan[i]).BorderWidth = 3;
                    }
                }
                else
                {
                    this.chartPrincipal.Series["CSCAN"].Points.Add(arregloCScan[i]).BorderWidth = 3;
                }
            }
            lblCscan.Text = descScan.ToString();

        }


        /// <summary>
        ///Funcion que despliega un mensaje de alerta cada vez que el usuario recorre el cursor por el textbox de la cola de peticiones 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQueue_MouseHover(object sender, EventArgs e)
        {
            if (MessageBox.Show("Por favor ingrese los valores separandolos por espacios", "OJO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                this.txtQueue.MouseHover -= new System.EventHandler(txtQueue_MouseHover);
        }

    }
}





