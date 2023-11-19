using System;
using System.Collections.Generic;
using NinjaTrader.Client;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Python.Runtime;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.IO;
using System.Drawing.Drawing2D;
using Keras.Models;
using Keras;
using Keras.Applications.VGG;
using Keras.Layers;


namespace DolarLSTM_1_
{
    public partial class Form1 : Form
    {

        string atualDOL;





        //NDde.Client.DdeClient DdeDOL = null;
        //void adviseDOL(object sender, NDde.Client.DdeAdviseEventArgs e) { try { DOL.LastPrice = Convert.ToDouble(e.Text.Substring(0, 4) + "." + e.Text.Substring(4, 1)); } catch { } }

        int axeXsize = 300;
        int Nca = 0;
        public Form1()
        {
            InitializeComponent();
            labelCotacoes.Parent = chart1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("buton2");

            string pathToParentDLL = @"C:\Users\world\AppData\Local\Programs\Python\Python38";

            string pathToVirtualEnv = @"C:\Py3.8VirtEnvKeras";


            Environment.SetEnvironmentVariable("PATH", pathToParentDLL, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("PYTHONHOME", pathToParentDLL, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("PYTHONPATH", $"{pathToParentDLL}\\Lib\\site-packages;{pathToParentDLL}\\Lib;{pathToParentDLL}\\DLLs", EnvironmentVariableTarget.Process);

            PythonEngine.PythonHome = Environment.GetEnvironmentVariable("PYTHONHOME", EnvironmentVariableTarget.Process);
            PythonEngine.PythonPath = Environment.GetEnvironmentVariable("PYTHONPATH", EnvironmentVariableTarget.Process);

            using (Py.GIL())
            {
                dynamic os = Py.Import("os");
                Console.WriteLine("AAA");
                dynamic oPath = os.path;
                Console.WriteLine(oPath);

                Console.WriteLine("BBB");

                dynamic sys = Py.Import("sys");
                string s = sys.executable;
                Console.WriteLine(s);
                Console.WriteLine("CCC");

                //PythonEngine.Exec("from tensorflow.keras import backend as K");
            }




            using (Py.GIL())
            {
                dynamic np = Py.Import("numpy");
                Console.WriteLine(np.cos(np.pi * 2));
                Console.WriteLine("AAA");

                dynamic sin = np.sin;
                Console.WriteLine(sin(5));

                double c = np.cos(5) + sin(5);
                Console.WriteLine(c);

                dynamic a = np.array(new List<float> { 1, 2, 3 });
                Console.WriteLine(a.dtype);

                dynamic kerasImport = Py.Import("tensorflow.keras");



                Dictionary<string, PyObject> objetosCustomizados = new Dictionary<string, PyObject>();
                objetosCustomizados.Add("AssertvidadeDirecional", kerasImport.losses.Hinge);

                var model = Keras.Models.Model.LoadModel("h5ParaImportarEmC.h5", custom_objects: objetosCustomizados);

                var modelWheights = model.GetWeights();
                foreach (var peso in modelWheights)
                {

                    Console.WriteLine(peso);

                }


                Console.WriteLine("stop");

            }


        }


        List<double> listDOL = new List<double>();
        List<double> listMIX = new List<double>();

        string mesQueVem;

        string contratoAtual;

        List<Operacional> operacionaisSelecionadosCompra = new List<Operacional>();
        List<Operacional> operacionaisSelecionadosVenda = new List<Operacional>();

        List<Operacional> sinalInvertidoEntrarCompra = new List<Operacional>();
        List<Operacional> sinalInvertidoEntrarVenda = new List<Operacional>();

        double[,] matrixOperacionaisSelecionados = new double[40, 40];


        private void Form1_Load(object sender, EventArgs e)
        {
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -14, y = -20 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -14, y = -19 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -14, y = -18 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -14, y = -17 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -14, y = -16 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -14, y = -15 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -14, y = -14 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -14, y = -13 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -14, y = -12 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -14, y = -11 });

            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -20 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -19 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -18 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -17 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -16 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -15 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -14 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -13 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -12 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -11 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -10 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -9 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -13, y = -8 });

            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -20 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -19 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -18 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -17 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -16 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -15 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -14 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -13 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -12 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -11 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -10 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -9 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -12, y = -8 });

            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -20 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -19 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -18 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -17 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -16 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -15 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -14 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -13 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -12 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -11 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -10 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -9 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -8 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -7 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -6 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -5 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -4 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -3 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -2 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -11, y = -1 });

            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -20 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -19 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -18 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -17 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -16 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -15 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -14 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -13 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -12 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -11 });
            operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -10 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -9 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -8 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -7 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -6 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -5 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -4 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -3 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -2 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -10, y = -1 });

            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -9, y = -10 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -9, y = -9 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -9, y = -8 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -9, y = -7 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -9, y = -6 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -9, y = -5 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -9, y = -4 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -9, y = -3 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -9, y = -2 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -9, y = -1 });

            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -8, y = -4 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -8, y = -3 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -8, y = -2 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -8, y = -1 });

            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -7, y = -4 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -7, y = -3 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -7, y = -2 });
            //operacionaisSelecionadosCompra.Add(new Operacional { x = -7, y = -1 });

            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -6, y = -2 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -6, y = -1 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -6, y = 0 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -6, y = 1 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -6, y = 2 });
            ////operacionaisSelecionadosCompra.Add(new Operacional { x = -6, y = 3 });




            ////operacionaisSelecionadosVenda.Add(new Operacional { x = 15, y = 17 });
            ////operacionaisSelecionadosVenda.Add(new Operacional { x = 16, y = 17 });
            ////operacionaisSelecionadosVenda.Add(new Operacional { x = 17, y = 17 });
            ////operacionaisSelecionadosVenda.Add(new Operacional { x = 17, y = 18 });
            ////operacionaisSelecionadosVenda.Add(new Operacional { x = 18, y = 17 });
            ////operacionaisSelecionadosVenda.Add(new Operacional { x = 18, y = 18 });
            ////operacionaisSelecionadosVenda.Add(new Operacional { x = 19, y = 17 });
            ////operacionaisSelecionadosVenda.Add(new Operacional { x = 19, y = 18 });




            ////operacionaisSelecionadosVenda.Add(new Operacional { x= -5, y= 8});
            ////operacionaisSelecionadosVenda.Add(new Operacional { x= -4, y= 8 });



            ////Excluir
            //BackgroundBeep.Beep();
            //operacionaisSelecionadosCompra.Add(new Operacional { x = 0, y = 0 });


            foreach (Operacional operSelecionado in operacionaisSelecionadosCompra)
            {
                matrixOperacionaisSelecionados[  Convert.ToInt32( operSelecionado.y ) - inferiorMatrix, Convert.ToInt32( operSelecionado.x) - inferiorMatrix ] = 1;
            }
            foreach (Operacional operSelecionado in operacionaisSelecionadosVenda)
            {
                matrixOperacionaisSelecionados[ Convert.ToInt32(operSelecionado.y) - inferiorMatrix, Convert.ToInt32(operSelecionado.x) - inferiorMatrix] = -1;
            }


            //MatrixToPictureBox(matrixOperacionaisSelecionados,pictureBox1,1);




            //using (var reader = new StreamReader(@"ReplayDOL+MIX.csv"))
            //{

            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var values = line.Split(',');

            //        listDOL.Add(Convert.ToDouble(values[0]));
            //        listMIX.Add(Convert.ToDouble(values[1]));
            //    }

            //    //DOL.ListPrecosReplay = listDOL;
            //    //MIX.ListPrecosReplay = listMIX;
            //}



            Nca = chart1.ChartAreas.Count - 1;
            chart1.ChartAreas[0].AxisX.ScaleView.Size = axeXsize + 10;
            //DOL.Name = "DOL";


            for (int i = 0; i <= Nca; ++i)
            {
                chart1.ChartAreas[i].Position = new ElementPosition(0, Convert.ToSingle((100.0 / (Convert.ToSingle(Nca) + 1.0)) * i), 100f, Convert.ToSingle(100.0 / (Convert.ToSingle(Nca) + 1.0)));
                //chart1.ChartAreas[i].Position = new ElementPosition(0, Convert.ToSingle((8.3333) * i), 100f, Convert.ToSingle(8.3333));

            }

            string[] mes = "F G H J K M N Q U V X Z F".Split(' ');

            contratoAtual = "DOL" + mes[DateTime.Now.Month] + Convert.ToString(DateTime.Now.Year).Substring(2);
            atualDOL = contratoAtual;



            Console.WriteLine(contratoAtual);

            //atualDOL = contratoAtual;

            for (int im = 0; im <= 12; ++im)
            {
                //mesQueVem = atualDOL.Substring(atualDOL.Length - 3, 1) == mes[im] ? mes[im + 1];
                if (atualDOL.Substring(atualDOL.Length - 3, 1) == mes[im])
                {
                    mesQueVem = mes[im + 1];
                    Console.WriteLine("mesQueVem= " + mesQueVem);
                    if (DateTime.Now.Day == DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
                    {
                        contratoAtual = mesQueVem;
                        Console.WriteLine("Dia de ROLAGEM");
                    }
                }


            }


        }

        double bookComStop = 0;


        private void button0_Click(object sender, EventArgs e)
        {

            DOL.CodAtivo = "DOLK21";
            WIN.CodAtivo = "WINFUT";
            ES.CodAtivo = "ES 06-21";
            AUDUSD.CodAtivo = "AUDUSD";
            E6.CodAtivo = "6E 06-21";
            CL.CodAtivo = "CL 05-21";
            USDMXN.CodAtivo = "USDMXN";
            //WINagr.CodAtivo = "WINFUT";

            DOL.ConnectDdeTryd();
            WIN.ConnectDdeTryd();

            ES.ConnectNinja();
            AUDUSD.ConnectNinja();
            E6.ConnectNinja();
            CL.ConnectNinja();
            USDMXN.ConnectNinja();
            DOLagr.ConnectDdeTryd();

            if (DOL.GetType().Name != "Ativo" && simulador == false)
            {
                MessageBox.Show("Voce esta na classe de simulador.");
                button3.BackColor = Color.Red;
                simulador = true;
            }

            if (simulador==false)
            {
                timer1.Interval = Convert.ToInt32(GetInitialInterval());

            }

            stopLoss = Convert.ToDouble(textBoxStopLoss.Text);

            timer1.Start();

        }


        private const int intervaloTimerSync = 3;
        private const long MILLISECOND_IN_MINUTE = intervaloTimerSync * 1000;
        private const long TICKS_IN_MILLISECOND = 10000;
        private const long TICKS_IN_MINUTE = MILLISECOND_IN_MINUTE * TICKS_IN_MILLISECOND;
        private long nextIntervalTick;

        double posicaoAnteriorAntedAdd = 0;

        private double GetInitialInterval()
        {
            DateTime now = DateTime.Now;
            double timeToNextMin = ((intervaloTimerSync - now.Second % 3) * 1000 - now.Millisecond) + 15;
            nextIntervalTick = now.Ticks + ((long)timeToNextMin * TICKS_IN_MILLISECOND);

            timeToNextMin = timeToNextMin > 100 ? timeToNextMin : 1000;
            return timeToNextMin;
        }
        private double GetInterval()
        {
            nextIntervalTick += TICKS_IN_MINUTE;
            return TicksToMs(nextIntervalTick - DateTime.Now.Ticks) / 2;
        }

        private double TicksToMs(long ticks)
        {
            return (double)(ticks / TICKS_IN_MILLISECOND);
        }




        //Ativo DOL = new Ativo();
        //Ativo WIN = new Ativo();

        //Ativo ES = new Ativo();
        //Ativo E6 = new Ativo();
        //Ativo USDMXN = new Ativo();
        //Ativo AUDUSD = new Ativo();
        //Ativo CL = new Ativo();
        //Ativo MIX = new Ativo();
        //Ativo difDolMixAtivo = new Ativo();
        //AtivoAgr DOLagr = new AtivoAgr();


        double chartPtsTradeFInal = 0;

        int iTick = 1;


        SimulaAtivo DOL = new SimulaAtivo(5789.5);
        SimulaAtivo MIX = new SimulaAtivo(5789.5);
        SimulaAtivo WIN = new SimulaAtivo(0);
        SimulaAtivo ES = new SimulaAtivo(0);
        SimulaAtivo E6 = new SimulaAtivo(0);
        SimulaAtivo USDMXN = new SimulaAtivo(0);
        SimulaAtivo AUDUSD = new SimulaAtivo(0);
        SimulaAtivo CL = new SimulaAtivo(0);
        SimulaAtivo difDolMixAtivo = new SimulaAtivo(0);
        SimulaAtivo DOLagr = new SimulaAtivo(0);

        double difDolMix;

        //Ativo EURUSD = new Ativo();

        //double[,] inputsLSTM = new double[45, 8];
        double[,] inputsFinalLSTM = new double[16, 8];
        double[,] inputsFinaRetornoslLSTM = new double[15, 8];
        double[,] inputsAcumulados = new double[15, 8];
        int iInputsAcumulados = 0;
        List<string> linesAcumuladas = new List<string>();

        double[] posicaoArray = new double[10];
        double[] passadoDOL = new double[50];
        double[] passadoMIX = new double[50];

        double bookAberto = 0;
        double ptsGanhos = 0;

        string toTextFile = "";

        List<Trades> tradesBook1 = new List<Trades>();

        Dictionary<int,int> dictOperacionaisAtuais = new Dictionary<int, int>();

        double qtdOrdensRealtime1 = 0;
        int periodosPraTraz = 50;

        double posicaoAtualComStops = 0;

        int inferiorMatrix = -20;
        int superiorMatrix = 20;

        int matrixCount = 40;

        double stopLoss = 0;

        double pontosTotalComStop = 0;
        double qtdTradesTotalComStop = 0;
        int posicaoAtualAnterior = 0;

        List<string> tradesSalvos = new List<string>();
        List<string> pontosRealizados = new List<string>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            iTick++;
            if (simulador == false)
            {
                timer1.Interval = Convert.ToInt32(GetInitialInterval());
                timer1.Start();
            }









            for (int ix = 1; ix < 16; ix++)
            {
                //Console.WriteLine("");
                for (int iy = 0; iy < 8; iy++)
                {
                    //Console.Write(ix.ToString() + " x " + iy.ToString() + "= " + inputsLSTM[ix, iy]);

                    //Console.Write( inputsLSTM[ix, iy] + " ");

                    inputsFinalLSTM[ix - 1, iy] = inputsFinalLSTM[ix, iy];
                }

            }

            inputsFinalLSTM[15, 5] = DOL.LastPrice;//DOL
            inputsFinalLSTM[15, 6] = -WIN.LastPrice * 100.0 / 70.0;//WIN
            inputsFinalLSTM[15, 3] = -ES.UpdateLastPrice * 0.5;//ES
            inputsFinalLSTM[15, 4] = USDMXN.UpdateLastPrice * 500;//MXN
            inputsFinalLSTM[15, 0] = -E6.UpdateLastPrice * 5000;//6E
            inputsFinalLSTM[15, 2] = -CL.UpdateLastPrice * 5;//CL
            inputsFinalLSTM[15, 1] = -AUDUSD.UpdateLastPrice * 10000;//AUDUSD

            //Console.WriteLine("dol: " + DOL.LastPrice);
            //Console.WriteLine("win: " + -WIN.LastPrice);
            //Console.WriteLine("es: " + -ES.LastPrice);
            //Console.WriteLine("mxn: " + USDMXN.LastPrice);
            //Console.WriteLine("6e: " + -E6.LastPrice);
            //Console.WriteLine("cl: " + -CL.LastPrice);
            //Console.WriteLine("audusd: " + -AUDUSD.LastPrice);

            //    dictPesos = {'MXN': 500, '6E' : -5000, 'WIN': -1/70, 'ES': -0.5, 'AUDUSD': -10000, 'CL ': -5 }

            MIX.LastPrice =
                -WIN.LastPrice / 70.0
                + -ES.LastPrice * 0.5
                + USDMXN.LastPrice * 500
                + -E6.LastPrice * 5000
                + -CL.LastPrice * 5
                + -AUDUSD.LastPrice * 10000;


            inputsFinalLSTM[15, 7] = MIX.LastPrice;

            if (DOL.GetType().Name == "SimulaAtivo")
            {
                //inputsFinalLSTM[15, 5] = DOL.addVar(listDOL[iTick]);//DOL
                //inputsFinalLSTM[15, 7] = MIX.addVar(listMIX[iTick]);
                DOL.LastPrice = listDOL[iTick];
                MIX.LastPrice = listMIX[iTick];
                inputsFinalLSTM[15, 5] = listDOL[iTick];//DOL
                inputsFinalLSTM[15, 7] = listMIX[iTick];
            }


            if (periodosDecorridos > 120)
            {
                difDolMix = DOL.LastPrice - DOL.historico3s[periodosDecorridos-periodosPraTraz] - (MIX.LastPrice - MIX.historico3s[periodosDecorridos - periodosPraTraz]);
                label2.Text = "difDol= " + (DOL.LastPrice - DOL.historico3s[periodosDecorridos - periodosPraTraz]).ToString("N2") + " - DifMix=" + (MIX.LastPrice - MIX.historico3s[periodosDecorridos - periodosPraTraz]).ToString("N2") + "= " + difDolMix.ToString("N2");

            }
            else
            {
                difDolMix = DOL.LastPrice - inputsFinalLSTM[15, 7];

            }


            //Console.WriteLine("simaulaDOL: " + inputsFinalLSTM[15, 7]);
            //Console.WriteLine("simaulaMIX: " + inputsFinalLSTM[15, 5]);
            //Console.WriteLine("simaulaDifDolMix: " + difDolMix);
            Console.WriteLine(periodosDecorridos);
            periodosDecorridos++;

            //StreamWriter file = new StreamWriter(@"C:\Users\world\Documents\AmostragemDolar\RealTimeInputs\inputsFinalLSTM" + Convert.ToString(DateTime.Now.ToString("ss")) + ".csv");
            //+ DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")
            toTextFile = "";

            for (int ix = 0; ix < 15; ix++)
            {
                //Console.WriteLine("");
                //toTextFile = toTextFile + "\n";
                for (int iy = 0; iy < 8; iy++)
                {
                    //passadoDOL = passadoDOL[]

                    //Console.Write(ix.ToString() + " x " + iy.ToString() + "= " + inputsLSTM[ix, iy]);
                    inputsFinaRetornoslLSTM[ix, iy] = inputsFinalLSTM[ix + 1, iy] - inputsFinalLSTM[ix, iy];

                    //Console.Write(Math.Round(inputsFinaRetornoslLSTM[ix, iy], 5) + " , ");
                    toTextFile = toTextFile + inputsFinaRetornoslLSTM[ix, iy].ToString() + ",";
                    //file.Write(inputsFinaRetornoslLSTM[ix, iy]);

                    //it is comman and not a tab
                    //file.Write(",");
                }
                //toTextFile = toTextFile + "\n";
                //file.Write("\n");

            }


            passadoDOL[43] = inputsFinaRetornoslLSTM[14, 5];
            passadoMIX[43] = inputsFinaRetornoslLSTM[14, 7];

            for (int ix = 0; ix < passadoDOL.Length - 1; ix++)
            {
                passadoDOL[ix] = passadoDOL[ix + 1];
                passadoMIX[ix] = passadoMIX[ix + 1];

            }

            //if (passadoDOL.Sum() > 11 && passadoMIX.Sum() > 4)
            //{
            //    //tradesBook1.Add();
            //    Console.WriteLine("COMPRA");
            //    Console.Beep(1700, 900);
            //}

            //if (passadoDOL.Sum() < -11 && passadoMIX.Sum() < -4)
            //{
            //    Console.WriteLine("VENDE");
            //    Console.Beep(900, 900);

            //}



            //Console.WriteLine("passadoDOL.sum: " + passadoDOL.Sum());
            //Console.WriteLine("passadoMIX.sum: " + passadoMIX.Sum());

            //Console.WriteLine("");
            //Console.WriteLine("----------------------" + DateTime.Now.ToString("hh:mm:ss.fffffff") + "-----------------------------------");


            //System.IO.File.WriteAllText(@"C: \Users\world\Documents\AmostragemDolar\RealTimeInputs\inputsFinalLSTM" + Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")) + ".csv", toTextFile);




            iInputsAcumulados++;
            linesAcumuladas.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffffff") + "," + toTextFile);

            if (iInputsAcumulados > 300)
            {
                iInputsAcumulados = 0;


                System.IO.File.WriteAllText(@"linesAcumuladas.csv" + Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd-HH")) + ".csv", String.Join("\n", linesAcumuladas.ToArray()));

            }









            //Console.WriteLine("----------------------" + DateTime.Now.ToString("hh:mm:ss.fffffff") + "-----------------------------------");

            //Random rnd = new Random();

            //double last6E = rnd.NextDouble();
            //double lastES = rnd.NextDouble();
            //double lastMXN = rnd.NextDouble();
            ////double lastDOL = rnd.NextDouble();
            //double lastWIN = rnd.NextDouble();
            //double lastCL = rnd.NextDouble();
            //double lastAUDUSD = rnd.NextDouble();
            //double lastMIX = rnd.NextDouble();



            //Console.WriteLine(DOL.LastPrice);
            //Console.WriteLine(WIN.LastPrice);

            //Console.WriteLine(ES.LastPrice);
            //Console.WriteLine(E6.LastPrice);
            //Console.WriteLine(USDMXN.LastPrice);
            //Console.WriteLine(AUDUSD.LastPrice);
            //Console.WriteLine(CL.LastPrice);




            chart1.Series[0].Points.Add(-ES.UpdateLastPrice);
            chart1.Series[1].Points.Add(-E6.UpdateLastPrice);
            chart1.Series[2].Points.Add(USDMXN.UpdateLastPrice);
            chart1.Series[3].Points.Add(DOL.LastPrice); DOL.addHistorico(DOL.LastPrice);
            chart1.Series[4].Points.Add(-WIN.LastPrice);
            chart1.Series[5].Points.Add(-AUDUSD.UpdateLastPrice);
            chart1.Series[6].Points.Add(-CL.UpdateLastPrice);
            chart1.Series[7].Points.Add(MIX.LastPrice); MIX.addHistorico(MIX.LastPrice);
            chart1.Series[8].Points.Add(difDolMix); difDolMixAtivo.addHistorico(difDolMix);
            chart1.Series[9].Points.Add(DOLagr.LastPrice); DOLagr.addHistorico(DOLagr.LastPrice);
            //chart1.Series[9].Points.Add(Convert.ToDouble(label3.Text.Split('/')[0]));
            //Console.WriteLine(DOLagr.LastPrice);


            string lastCotacoes = "";
            foreach (Series serie in chart1.Series)
            {
                lastCotacoes += serie.Points.Last().YValues[0].ToString("F") + Environment.NewLine ;
            }
            labelCotacoes.Text = lastCotacoes;



            int posiacaoAtualComStopFinal = 0;
            foreach (double posicaoAberta in listPosicoesAbertasComStop)
            {
                posiacaoAtualComStopFinal += posicaoAberta < 0 ? 1 : posicaoAberta > 0 ? -1 : 0;
            }
            //posiacaoAtualComStopFinal = Convert.ToInt32( Math.Round(Convert.ToDouble( posiacaoAtualComStopFinal / 100), 0));
            //posiacaoAtualComStopFinal = posiacaoAtualComStopFinal > 15 ? 15 : posiacaoAtualComStopFinal;
            //posiacaoAtualComStopFinal = listDOL.Count - 5 < iTick ? 0 : posiacaoAtualComStopFinal;
            if (posicaoAtualAnterior != posiacaoAtualComStopFinal)
            {
                BackgroundBeep.Beep();
                bookComStop += ( posicaoAtualAnterior - posiacaoAtualComStopFinal) * DOL.LastPrice;

            }

            labelPosicaoAtualStop.Text = "PosicaoAtual: " + posiacaoAtualComStopFinal.ToString() + " | ResultAberto: " + bookComStop; 
            posicaoAtualAnterior = posiacaoAtualComStopFinal;



            string stgPosicaoStop = "";



            for (int i = 0; i < listPosicoesAbertasComStop.Count ; i++)
            {

                if (listPosicoesAbertasComStop.Count == 0)
                {
                    break;
                }

                if (listPosicoesAbertasComStop[i] < 0 && DOL.LastPrice - Math.Abs(listPosicoesAbertasComStop[i]) > 10)
                {
                    //Ganhou na compra!!!
                    listPosicoesAbertasComStop.Remove(listPosicoesAbertasComStop[i]);
                    i = 0;
                    pontosTotalComStop += 10;

                    pontosRealizados.Add("+10");
                    using (TextWriter tw = new StreamWriter("pontosRealizados.txt"))
                    {
                        foreach (String s in pontosRealizados)
                            tw.WriteLine(s);
                    }

                    qtdTradesTotalComStop++;
                    if (listPosicoesAbertasComStop.Count == 0)
                    {
                        break;
                    }
                }
                if (listPosicoesAbertasComStop[i] < 0 && DOL.LastPrice - Math.Abs(listPosicoesAbertasComStop[i]) < -10)
                {
                    //Perdeu na compra!!!
                    listPosicoesAbertasComStop.Remove(listPosicoesAbertasComStop[i]);
                    i = 0;
                    //i--;
                    pontosTotalComStop -= 10;

                    pontosRealizados.Add("-10");
                    using (TextWriter tw = new StreamWriter("pontosRealizados.txt"))
                    {
                        foreach (String s in pontosRealizados)
                            tw.WriteLine(s);
                    }

                    qtdTradesTotalComStop++;
                    if (listPosicoesAbertasComStop.Count == 0)
                    {
                        break;
                    }

                }
                if (listPosicoesAbertasComStop[i] > 0 && Math.Abs(listPosicoesAbertasComStop[i]) - DOL.LastPrice < -10)
                {
                    //Ganhou na venda!!!
                    listPosicoesAbertasComStop.Remove(listPosicoesAbertasComStop[i]);
                    i = 0;
                    //i--;
                    pontosTotalComStop += 10;

                    pontosRealizados.Add("Venda+10");
                    using (TextWriter tw = new StreamWriter("pontosRealizados.txt"))
                    {
                        foreach (String s in pontosRealizados)
                            tw.WriteLine(s);
                    }


                    qtdTradesTotalComStop++;
                    if (listPosicoesAbertasComStop.Count == 0)
                    {
                        break;
                    }

                }
                if (listPosicoesAbertasComStop[i] > 0 && Math.Abs(listPosicoesAbertasComStop[i]) - DOL.LastPrice > 10)
                {
                    //Perdeu na venda!!!
                    listPosicoesAbertasComStop.Remove(listPosicoesAbertasComStop[i]);
                    i = 0;
                    //i--;
                    pontosTotalComStop -= 10;

                    pontosRealizados.Add("Venda-10");
                    using (TextWriter tw = new StreamWriter("pontosRealizados.txt"))
                    {
                        foreach (String s in pontosRealizados)
                            tw.WriteLine(s);
                    }

                    qtdTradesTotalComStop++;
                    if (listPosicoesAbertasComStop.Count == 0)
                    {
                        break;
                    }
                }



                //stgPosicaoStop += Environment.NewLine + listPosicoesAbertasComStop[i].ToString("N2");
            }
            labelPosicaoComStop.Text = listPosicoesAbertasComStop.Count.ToString();

            labelResumoPosicaoStop.Text = "PtsTotal: " + pontosTotalComStop.ToString("N2") + " qtdTrades: " + qtdTradesTotalComStop.ToString("N2") + " ptsTrade: " + (pontosTotalComStop / qtdTradesTotalComStop).ToString("N2");



            double posicaoAnterior = posicaoArray[0];


            //labelPosicao.Text = "Posicao: " + posicaoArray[0] + " | " + posicaoArray[1] + " | " + posicaoArray[1] + " | " + posicaoArray[] + " | " + posicaoArray[0] + " | ";

            foreach (KeyValuePair<int,int> menorQueMaiorQue in dictOperacionaisAtuais)
            {

            }











            double[,] matrixPtsTradeVisual = new double[matrixCount, matrixCount];



            if (DOL.historico3s.Count - periodosPraTraz - 5 > 0)
            {

                double difAgr = DOLagr.historico3s[DOLagr.historico3s.Count - 1] - DOLagr.historico3s[DOLagr.historico3s.Count - 1 - periodosPraTraz];

                Console.WriteLine(difAgr);

                foreach (Operacional operSelecionado in operacionaisSelecionadosCompra)
                {
                    //matrixOperacionaisSelecionados[Convert.ToInt32(operSelecionado.x) - inferiorMatrix, Convert.ToInt32(operSelecionado.y) - inferiorMatrix] = 1;

                    if (DOL.historico3s[DOL.historico3s.Count - 1] - DOL.historico3s[DOL.historico3s.Count - 1 - periodosPraTraz] < operSelecionado.x && MIX.historico3s[DOL.historico3s.Count - 1] - MIX.historico3s[DOL.historico3s.Count - 1 - periodosPraTraz] > operSelecionado.y)
                    {
                        Console.WriteLine(operSelecionado.x + " compra " + operSelecionado.y);
                        PosicaoArrayAdd1(1);
                        listPosicoesAbertasComStop.Add(-DOL.LastPrice);

                        tradesSalvos.Add(periodosDecorridos.ToString());
                        using (TextWriter tw = new StreamWriter("tradesSalvos.txt"))
                        {
                            foreach (String s in tradesSalvos)
                                tw.WriteLine(s);
                        }
                    }


                }
                foreach (Operacional operSelecionado in operacionaisSelecionadosVenda)
                {

                    //matrixOperacionaisSelecionados[Convert.ToInt32(operSelecionado.x) - inferiorMatrix, Convert.ToInt32(operSelecionado.y) - inferiorMatrix] = -1;

                    if (DOL.historico3s[DOL.historico3s.Count - 1] - DOL.historico3s[DOL.historico3s.Count - 1 - periodosPraTraz] < operSelecionado.x && MIX.historico3s[DOL.historico3s.Count - 1] - MIX.historico3s[DOL.historico3s.Count - 1 - periodosPraTraz] > operSelecionado.y)
                    {
                        Console.WriteLine(operSelecionado.x + " venda " + operSelecionado.y);
                        //PosicaoArrayAdd1(-1);
                        listPosicoesAbertasComStop.Add(DOL.LastPrice);

                    }

                }




                double[,] matrixQ3 = new double[matrixCount, matrixCount];
                double[,] matrixQ1 = new double[matrixCount, matrixCount];
                double[,] matrixQ2 = new double[matrixCount, matrixCount];
                double[,] matrixQ4 = new double[matrixCount, matrixCount];

                for (int r = 0; r < matrixCount; r++)
                {
                    for (int c = 0; c < matrixCount; c++)
                    {
                        matrixQ3[r, c] = matrixOperacionaisSelecionados[r, c];

                        if (DOL.historico3s[DOL.historico3s.Count - 1] - DOL.historico3s[DOL.historico3s.Count - 1 - periodosPraTraz] < c + inferiorMatrix && MIX.historico3s[MIX.historico3s.Count - 1] - MIX.historico3s[MIX.historico3s.Count - 1 - periodosPraTraz] > r + inferiorMatrix)
                        {
                            matrixQ3[r, c] = -999;

                        }

                        if (DOL.historico3s[DOL.historico3s.Count - 1] - DOL.historico3s[DOL.historico3s.Count - 1 - periodosPraTraz] < c + inferiorMatrix && MIX.historico3s[MIX.historico3s.Count - 1] - MIX.historico3s[MIX.historico3s.Count - 1 - periodosPraTraz] < r + inferiorMatrix)
                        {
                            matrixQ1[r, c] = -999;

                        }

                        if (DOL.historico3s[DOL.historico3s.Count - 1] - DOL.historico3s[DOL.historico3s.Count - 1 - periodosPraTraz] > c + inferiorMatrix && MIX.historico3s[MIX.historico3s.Count - 1] - MIX.historico3s[MIX.historico3s.Count - 1 - periodosPraTraz] < r + inferiorMatrix)
                        {
                            matrixQ2[r, c] = -999;

                        }

                        if (DOL.historico3s[DOL.historico3s.Count - 1] - DOL.historico3s[DOL.historico3s.Count - 1 - periodosPraTraz] > c + inferiorMatrix && MIX.historico3s[MIX.historico3s.Count - 1] - MIX.historico3s[MIX.historico3s.Count - 1 - periodosPraTraz] > r + inferiorMatrix)
                        {
                            matrixQ4[r, c] = -999;

                        }

                    }
                }


                MatrixToPictureBox(matrixQ3, pictureBoxQ3, 0);

                MatrixToPictureBox(matrixQ1, pictureBoxQ1, 0);
                MatrixToPictureBox(matrixQ4, pictureBoxQ4, 0);
                MatrixToPictureBox(matrixQ2, pictureBoxQ2, 0);


                if (DOL.historico3s.Count - periodosPraTraz - 100 > 0)
                { 



                    double[,,] matrixPtsTrade = new double[matrixCount, matrixCount, DOL.historico3s.Count - 6];

                for (int x = 0; x < matrixCount; x++)
                {
                    for (int y = 0; y < matrixCount; y++)
                    {
                        //matrixPtsTrade[x, y] = x - 20;

                        for (int i = DOL.historico3s.Count - 100; i < DOL.historico3s.Count - 6; i++)
                        {


                            //if (difDolMixAtivo.historico3s[i] > x + inferiorMatrix && difDolMixAtivo.historico3s[i] < y + inferiorMatrix)
                            if (DOL.historico3s[i] - DOL.historico3s[i - periodosPraTraz] > x + inferiorMatrix && MIX.historico3s[i] - MIX.historico3s[i - periodosPraTraz] < y + inferiorMatrix)
                            {
                                double retornoDolEmi =
                                    DOL.historico3s[i + 1] - DOL.historico3s[i + 0]
                                    + DOL.historico3s[i + 2] - DOL.historico3s[i + 1]
                                    + DOL.historico3s[i + 3] - DOL.historico3s[i + 2]
                                    + DOL.historico3s[i + 4] - DOL.historico3s[i + 3]
                                    + DOL.historico3s[i + 5] - DOL.historico3s[i + 4];



                                matrixPtsTrade[x, y, i] = retornoDolEmi;



                            }
                        }

                    }
                }

                double resultPtsTotal = 0;
                double resultQtdTradesTotal = 0;
                //GERAR A MATRIZ DE PONTOS POR TRADE PARA VISUALIZACAO
                for (int x = 0; x < matrixCount; x++)
                {
                    for (int y = 0; y < matrixCount; y++)
                    {
                        //matrixPtsTrade[x, y] = x - 20;
                        double qtdAcertos = 0;
                        double qtdErros = 0;
                        double ptsTotal = 0;

                        double qtdAcertosPos = 0;
                        double qtdErrosPos = 0;
                        double ptsTotalPos = 0;


                        double qtdTradesTotal = 0;

                        for (int i = 0; i < DOL.historico3s.Count - 6; i++)
                        {



                            if (matrixPtsTrade[x, y, i] > 0)
                            {
                                qtdAcertos++;
                                ptsTotal = ptsTotal + Math.Abs(matrixPtsTrade[x, y, i]);
                            }
                            else if (matrixPtsTrade[x, y, i] < 0)
                            {
                                qtdErros++;
                                ptsTotal = ptsTotal - Math.Abs(matrixPtsTrade[x, y, i]);


                            }




                        }

                        //if (DOL.historico3s[DOL.historico3s.Count - 1] - DOL.historico3s[DOL.historico3s.Count - 1 - periodosPraTraz] > x + inferiorMatrix && MIX.historico3s[DOL.historico3s.Count - 1] - MIX.historico3s[DOL.historico3s.Count - 1 - periodosPraTraz] < y + inferiorMatrix)
                        //{
                        //   

                        //}


                        if (qtdAcertos + qtdErros > 0)
                        {
                            matrixPtsTradeVisual[x, y] = ptsTotal / (qtdAcertos + qtdErros);

                        }



                    }
                }




                if (resultQtdTradesTotal > 0)
                {
                    //chartPtsTradeFInal = resultPtsTotal / resultQtdTradesTotal;
                    chartPtsTradeFInal = resultPtsTotal;

                    Console.WriteLine("Pts/TradeTotal= " + resultPtsTotal);
                    label1.Text = resultPtsTotal.ToString("N") + " / " + resultQtdTradesTotal.ToString("N") + " / " + (resultPtsTotal / resultQtdTradesTotal).ToString("N2");

                    if (resultPtsTotal / resultQtdTradesTotal > 0.5)
                    {
                        Aplicar_Click(new object(), new EventArgs());
                    }
                    else if (resultQtdTradesTotal > 10000 && resultPtsTotal / resultQtdTradesTotal > 0.1)
                    {
                        Aplicar_Click(new object(), new EventArgs());

                    }
                }






                MatrixToPictureBox(matrixPtsTradeVisual, pictureBox2, 1);



            }

 

                //MatrixToPictureBox(matrixPosCongelamento, pictureBox3, 1);


            }




            //TEM QUE CALCULAR AQUIA DIFERENCA DE POSICAO:

            //posicaoArray[posicaoArray.Length - 1] = 0;

            //Console.WriteLine("Antes");
            //for (int i = 0; i < posicaoArray.Length; i++)
            //{
            //    Console.WriteLine(posicaoArray[i]);
            //}

            //double[] newPosicaoArray = new double[posicaoArray.Length];

            //Array.Copy(posicaoArray, 1, newPosicaoArray, 0, posicaoArray.Length - 1);

            //Array.ConstrainedCopy(posicaoArray, 1, posicaoArray, 0, posicaoArray.Length - 1);
            //posicaoArray[posicaoArray.Length - 1] = 0;


            //for (int i = 0; i < posicaoArray.Length - 1; i++)
            //{
            //    Console.WriteLine(posicaoArray[i] + " = " + posicaoArray[i + 1]);
            //    double value = new double();
            //    value = posicaoArray[i + 1];
            //     posicaoArray[i] = value;
            //}



            //Console.WriteLine("Depois");

            //for (int i = 0; i < posicaoArray.Length; i++)
            //{
            //    Console.WriteLine(posicaoArray[i]);
            //}

            //for (int i = 0; i < posicaoArray.Length - 1 ; i++)
            //{
            //    Console.WriteLine(posicaoArray[i] + " = " + posicaoArray[i + 1]);

            //    posicaoArray[i] = posicaoArray[i + 1];
            //}

            Array.ConstrainedCopy(posicaoArray, 1, posicaoArray, 0, posicaoArray.Length - 1);
            posicaoArray[posicaoArray.Length - 1] = 0;

            double posicaoAnteriorMenosAtual = posicaoAnterior - posicaoArray[0];


            if (posicaoArray[0] != posicaoAnteriorAntedAdd )
            {
                //BackgroundBeep.Beep();
                bookAberto += (posicaoArray[0] - posicaoAnteriorAntedAdd) * -DOL.LastPrice;
            }

            //if (posicaoArray[0] != posicaoAnterior)
            //{
            //    bookAberto += (posicaoArray[0] - posicaoAnterior) * -DOL.LastPrice;

            //}

            ptsGanhos = bookAberto - posicaoArray[0] * -DOL.LastPrice;
            //qtdOrdensRealtime1 += Math.Abs(posicaoAnteriorMenosAtual);

            string posicaoStg = "Fechado:" + ptsGanhos.ToString("N2") + " | " + bookAberto.ToString("N2") + " | ptsTrades: " + (ptsGanhos / qtdOrdensRealtime1  ).ToString("N2") + " | Dif: " + posicaoAnteriorMenosAtual.ToString("N2") + " # Posicao: ";



            for (int i = 0; i < posicaoArray.Length; i++)
            {
                posicaoStg += posicaoArray[i] + " | ";
            }
            labelPosicao.Text = posicaoStg;


            posicaoAnteriorAntedAdd = posicaoArray[0];





            //DEFINE O RANGE DO EIXO Y:
            for (int i = 0; i <= Nca; ++i)
            {

                //JOGA A ESCALA DO EIXO X PRO ULTIMO VALOR:
                chart1.ChartAreas[i].AxisX.ScaleView.Position = chart1.ChartAreas[0].AxisX.Maximum - axeXsize;
                //RANGE DO Y1:
                if (Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2) <= chart1.ChartAreas[i].AxisX.Minimum && chart1.Series[2 * i].Points.FindMaxByValue("Y1", Convert.ToInt32(chart1.ChartAreas[i].AxisX.Minimum)).YValues[0] != chart1.Series[2 * i].Points.FindMinByValue("Y1", Convert.ToInt32(chart1.ChartAreas[i].AxisX.Minimum)).YValues[0])
                {
                    chart1.ChartAreas[i].AxisY2.Maximum = chart1.Series[2 * i].Points.FindMaxByValue("Y1", Convert.ToInt32(chart1.ChartAreas[i].AxisX.Minimum)).YValues[0];
                    chart1.ChartAreas[i].AxisY2.Minimum = chart1.Series[2 * i].Points.FindMinByValue("Y1", Convert.ToInt32(chart1.ChartAreas[i].AxisX.Minimum)).YValues[0];

                }
                else if (Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2) > chart1.ChartAreas[i].AxisX.Minimum && chart1.Series[2 * i].Points.FindMaxByValue("Y1", Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2)).YValues[0] != chart1.Series[2 * i].Points.FindMinByValue("Y1", Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2)).YValues[0])
                {
                    chart1.ChartAreas[i].AxisY2.Maximum = chart1.Series[2 * i].Points.FindMaxByValue("Y1", Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2)).YValues[0];
                    chart1.ChartAreas[i].AxisY2.Minimum = chart1.Series[2 * i].Points.FindMinByValue("Y1", Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2)).YValues[0];
                }
                else
                {
                    chart1.ChartAreas[i].AxisY2.Maximum = chart1.ChartAreas[i].AxisY2.MinorGrid.Interval;
                    chart1.ChartAreas[i].AxisY2.Minimum = -chart1.ChartAreas[i].AxisY2.MinorGrid.Interval;
                }
                //RANGE DO Y2:
                if (Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2) <= chart1.ChartAreas[i].AxisX.Minimum && chart1.Series[(2 * i) + 1].Points.FindMaxByValue("Y1", Convert.ToInt32(chart1.ChartAreas[i].AxisX.Minimum)).YValues[0] != chart1.Series[(2 * i) + 1].Points.FindMinByValue("Y1", Convert.ToInt32(chart1.ChartAreas[i].AxisX.Minimum)).YValues[0])
                {
                    chart1.ChartAreas[i].AxisY.Maximum = chart1.Series[(2 * i) + 1].Points.FindMaxByValue("Y1", Convert.ToInt32(chart1.ChartAreas[i].AxisX.Minimum)).YValues[0];
                    chart1.ChartAreas[i].AxisY.Minimum = chart1.Series[(2 * i) + 1].Points.FindMinByValue("Y1", Convert.ToInt32(chart1.ChartAreas[i].AxisX.Minimum)).YValues[0];

                }
                else if (Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2) > chart1.ChartAreas[i].AxisX.Minimum && chart1.Series[(2 * i) + 1].Points.FindMaxByValue("Y1", Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2)).YValues[0] != chart1.Series[(2 * i) + 1].Points.FindMinByValue("Y1", Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2)).YValues[0])
                {
                    chart1.ChartAreas[i].AxisY.Maximum = chart1.Series[(2 * i) + 1].Points.FindMaxByValue("Y1", Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2)).YValues[0];
                    chart1.ChartAreas[i].AxisY.Minimum = chart1.Series[(2 * i) + 1].Points.FindMinByValue("Y1", Convert.ToInt32(chart1.ChartAreas[0].AxisX.ScaleView.Position - 2)).YValues[0];
                }
                else
                {
                    chart1.ChartAreas[i].AxisY.Maximum = chart1.ChartAreas[i].AxisY.MinorGrid.Interval;
                    chart1.ChartAreas[i].AxisY.Minimum = -chart1.ChartAreas[i].AxisY.MinorGrid.Interval;
                }


            }









        }


        public void MatrixToPictureBox(double[,] matrixEntrada, PictureBox picBox, int escalaMax)
        {
            bool azul = false;
            if(escalaMax == 0)
            {
                azul = true;
                escalaMax = 1;
            }

            int width = matrixEntrada.GetLength(0);
            int height = matrixEntrada.GetLength(1);

            
            Bitmap bmp3 = new Bitmap(width, height);

            for (int r = 0; r < height; r++)
            {
                for (int c = 0; c < width; c++)
                {
                    //Byte value = Convert.ToByte(matrixPtsTradeVisual[r * width + c ]);

                    if (matrixEntrada[r, c] > 0)
                    {
                        double dado = matrixEntrada[r, c];
                        dado = dado > escalaMax ? escalaMax : dado;
                        bmp3.SetPixel(c, r, Color.FromArgb(Convert.ToInt32((1 - dado / escalaMax) * 255), 255, Convert.ToInt32((1 - dado / escalaMax) * 255)));
                    }
                    else if (matrixEntrada[r, c] < 0)
                    {
                        double dado = matrixEntrada[r, c];
                        dado = dado < -escalaMax ? -escalaMax : dado;
                        bmp3.SetPixel(c, r, Color.FromArgb(255, Convert.ToInt32((dado / escalaMax + 1) * 255), Convert.ToInt32((dado / escalaMax + 1) * 255)));

                    }
                    else
                    {
                        bmp3.SetPixel(c, r, Color.FromArgb(255, 255, 255));

                    }
                    if (matrixEntrada[r, c] == -999)
                    {
                        double dado = matrixEntrada[r, c];
                        dado = dado < escalaMax ? escalaMax : dado;
                        bmp3.SetPixel(c, r, Color.FromArgb(Convert.ToInt32((1 - dado / escalaMax) * 255),  Convert.ToInt32((1 - dado / escalaMax) * 255), 255));
                    }

                }
            }


            picBox.Image = bmp3;
        }



        public void PosicaoArrayAdd1(double valorAdicionar)
        {

            for (int i = 0; i < posicaoArray.Length; i++)
            {
                posicaoArray[i] += valorAdicionar;
            }
            qtdOrdensRealtime1++;

        }


        List<double> listPosicoesAbertasComStop = new List<double>();

        //public void PosicaoComStopAdd(double precoEntrada)
        //{

        //}



        private void button1_Click(object sender, EventArgs e)
        {

            var pythonPath = @"C:\NewPythonEnv1\Scripts";

            //string pathToVirtualEnv = @"C:\Users\world\AppData\Local\Programs\Python\Python36";
            string pathToParentDLL = @"C:\Users\world\AppData\Local\Programs\Python\Python36";

            string pathToVirtualEnv = @"C:\Py3.6.5Env1";

            Environment.SetEnvironmentVariable("PATH", pathToParentDLL, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("PYTHONHOME", pathToParentDLL, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("PYTHONPATH", $"{pathToParentDLL}\\Lib\\site-packages;{pathToParentDLL}\\Lib;{pathToParentDLL}\\DLLs;{pathToParentDLL};{pathToVirtualEnv}\\Scripts", EnvironmentVariableTarget.Process);



            //python home= bibliotecas padrão ( deve ser o com DLL)
            //PYTHON PATH= AUMENTA A PROCURA POR PACOTES (Deve ser o virtual eviroment)

            PythonEngine.PythonHome = Environment.GetEnvironmentVariable("PYTHONHOME", EnvironmentVariableTarget.Process);
            PythonEngine.PythonPath = Environment.GetEnvironmentVariable("PYTHONPATH", EnvironmentVariableTarget.Process);

            Environment.SetEnvironmentVariable("PYTHONPATH", $"{pathToVirtualEnv}\\Lib\\site-packages;{pathToVirtualEnv}\\Lib;{pathToParentDLL}\\DLLs;{pathToParentDLL};{pathToVirtualEnv}\\Scripts", EnvironmentVariableTarget.Process);


            PythonEngine.PythonPath = PythonEngine.PythonPath + ";" + Environment.GetEnvironmentVariable("PYTHONPATH", EnvironmentVariableTarget.Process);


            using (Py.GIL())
            {
                //dynamic tf = Py.Import("tensorflow");


                //dynamic keras = Py.Import("tensorflow.keras");


                //dynamic cand = keras.models.Sequential();


                //Shape inputShape = new Shape(50, 14);

                //cand.add(keras.layers.Bidirectional(keras.layers.LSTM(50, input_shape: inputShape, dropout: Convert.ToSingle(0.6), return_sequences: true)));
                //cand.add(keras.layers.Bidirectional(keras.layers.LSTM(50, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null)));


                var model = Keras.Models.Model.LoadModel(@"C:\Users\world\Documents\FEA-USP\2021-2\TCC2\PesosTest1.h5");


                Console.WriteLine("stop");

            }


            //using (Py.GIL())
            //{
            //    //dynamic tf = Py.Import("tensorflow");

            //    //dynamic keras = Py.Import("tensorflow.keras");

            //    //var backend = Backend.Instance.keras.backend.tf;
            //    //backend.disable_eager_execution();




            //    //double[] inputs_shapes = new double[2];

            //    //inputs_shapes[0] = 50;
            //    //inputs_shapes[1] = 14;

            //    //Shape inputShape = new Shape(50,14);
            //    //inputShape.Dimensions[0] = 50;
            //    //inputShape.Dimensions[1] = 14;

            //    //Sequential cand = new Sequential();
            //    ////cand.Add(new Bidirectional(new LSTM(50, input_shape: inputShape, dropout: Convert.ToSingle(0.6), return_sequences: true)));
            //    //cand.Add(new Dense(50));

            //cand.Add(new LSTM(50,,,,,,,,,,,,,,,,,,,,,,,,));

            //    //cand.Add(new LSTM(50, input_shape: inputShape, dropout: Convert.ToSingle(0.6), return_sequences: true));
            //    //cand.Add(new LSTM(50, input_shape: inputShape, dropout: Convert.ToSingle(0.6), return_sequences: true));

            //    //cand.Add(new Dense(50));
            //    //cand.Add(new Dense(4, activation: "relu"));
            //    //cand.Add(new Dense(1));

            //    //cand.Compile(loss: "mean_squared_error", optimizer:"nadam");


            //    //cand.LoadWeight(@"C:\Users\world\Documents\FEA-USP\2021-2\TCC2\PesosTest1.h5");

            //    //Numpy.NDarray numpyArray1;

            //    //numpyArray1 = inputs_shapes;


            //    //Console.WriteLine("stop");

            //    //cand.Predict(numpyArray1);


            //    //dynamic cand = tf.keras.models.Sequential();
            //    //cand.add(tf.keras.layers.Bidirectional(tf.keras.layers.LSTM(50)));


            //    //cand.add(tf.keras.layers.Bidirectional(tf.python.keras.layers.recurrent_v2.LSTM(50, input_shape = (xtrain.shape[1], xtrain.shape[2]), dropout = 0.6, return_sequences = True)));
            //    //PythonEngine.Exec("import tensorflow");

            //    //PythonEngine.Exec("import tensorflow \rcand = tensorflow.keras.models.Sequential()");

            //    //PythonEngine.Exec("cand.add(tf.keras.layers.Bidirectional(tf.python.keras.layers.recurrent_v2.LSTM(50, input_shape = (xtrain.shape[1], xtrain.shape[2]), dropout = 0.6, return_sequences = True)))");


            //    //dynamic oPath = os.path;
            //    //Console.WriteLine(oPath);

            //    //dynamic sys = Py.Import("sys");
            //    //string s = sys.executable;
            //    //Console.WriteLine(s);
            //    ////PythonEngine.Exec("cand.add(tf.keras.layers.Bidirectional(tf.python.keras.layers.recurrent_v2.LSTM(50, input_shape = (xtrain.shape[1], xtrain.shape[2]), dropout = 0.6, return_sequences = True)))");
            //}




            //C:\NewPythonEnv1\Scripts\python.exe
            using (Py.GIL())
            {
                dynamic os = Py.Import("os");

                dynamic oPath = os.path;
                Console.WriteLine(oPath);

                dynamic sys = Py.Import("sys");
                string s = sys.executable;
                Console.WriteLine(s);
                //PythonEngine.Exec("from tensorflow.keras import backend as K");
            }


            //using (Py.GIL())
            //{
            //    dynamic np = Py.Import("numpy");
            //    Console.WriteLine(np.cos(np.pi * 2));

            //    dynamic sin = np.sin;
            //    Console.WriteLine(sin(5));

            //    double c = np.cos(5) + sin(5);
            //    Console.WriteLine(c);

            //    dynamic a = np.array(new List<float> { 1, 2, 3 });
            //    Console.WriteLine(a.dtype);

            //}


        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WIN.DisconnectDdeTryd();
            DOL.DisconnectDdeTryd();
            ES.DisconnectNinja();
            E6.DisconnectNinja();
            USDMXN.DisconnectNinja();
            AUDUSD.DisconnectNinja();
            CL.DisconnectNinja();
            DOLagr.DisconnectDdeTryd();

        }



        int periodosDecorridos = 0;
        int periodoDoCongelamento = 0;
        double[,] matrixPosCongelamento = new double[40, 40];

        double[,] matrixCongelada = new double[40, 40];
        double[,] matrixPtsAcumulados = new double[40, 40];



        bool congelarMatrix = false;
        bool aplicarMatrix = false;
        private void Aplicar_Click(object sender, EventArgs e)
        {
            congelarMatrix = true;
            aplicarMatrix = true;


            labelPontosAcumulados += Convert.ToDouble(label1.Text.Split('/')[0]);


            labelqtdTradesAcumulados += Convert.ToDouble(label1.Text.Split('/')[1]);



            label3.Text = labelPontosAcumulados.ToString("N2") + " / " + (labelPontosAcumulados/ labelqtdTradesAcumulados).ToString("N2") + "";

        }


        double[,] matrixResultadoPtdsTrade = new double[40, 40];

        bool verResultados = false;
        double labelPontosAcumulados = 0;
        double labelPtsTradeAcumulados = 0;
        double labelqtdTradesAcumulados = 0;

        private void VerResultados_Click(object sender, EventArgs e)
        {
            PosicaoArrayAdd1(1);



        }

        private void GerarImagem_Click(object sender, EventArgs e)
        {
            PosicaoArrayAdd1(-1);

        }

        bool simulador = false;
        private void button3_Click(object sender, EventArgs e)
        {


            using (var reader = new StreamReader(textBoxDiaSimulador.Text))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listDOL.Add(Convert.ToDouble(values[6]) * 1000 );

                    listMIX.Add(
                        Convert.ToDouble(values[1]) * -10000 +
                        Convert.ToDouble(values[2]) * -5000 +
                        Convert.ToDouble(values[3]) * -5 +
                        Convert.ToDouble(values[4]) * -0.5 +
                        Convert.ToDouble(values[5]) * 500 +
                        Convert.ToDouble(values[7]) * -0.014286

                        );
                }

                //DOL.ListPrecosReplay = listDOL;
                //MIX.ListPrecosReplay = listMIX;
            }

            Console.WriteLine(DOL.GetType().Name);
            if (DOL.GetType().Name != "SimulaAtivo")
            {
                MessageBox.Show("Voce esta na classe Realtime (Ativo)");
            }

            simulador = true;
            button3.BackColor = Color.Red;
            button0_Click(new object(), new EventArgs());
        }
    }
}


