using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolarLSTM_1_
{
    class SimulaAtivo
    {

        public double firstPrice { get; set; }
        
        public List<double> ListPrecosReplay { get; set; }

        private int periodoRetivePrice = 0;

        //public string Name   { get; set; }
        public SimulaAtivo(double valorInicial)
        {
            LastPrice = valorInicial;
            firstPrice = valorInicial;

        }

        public string CodAtivo { get; set; }
        public List<double> historico3s { get; set; }

        public void addHistorico(double valorPraAdd)
        {
            if (listaIniciada == false)
            {
                historico3s = new List<double>();
                listaIniciada = true;
            }

            historico3s.Add(valorPraAdd);
        }



        public NDde.Client.DdeClient DdeClient { get; set; }
        private double _lastPrice;
        public double LastPrice
        {
            //get;set;
            get
            {
                if (ListPrecosReplay != null)
                {
                    _lastPrice = ListPrecosReplay[periodoRetivePrice];
                    periodoRetivePrice++;
                }
                return _lastPrice;
            }
            set
            {
                _lastPrice = value;
            }
        }
        public double UpdateLastPrice
        {
            //get;set;
            get
            {
                //if (connectedNinja == true)
                //{
                //_lastPrice = NtClient.MarketData(CodAtivo, 0);
                //}
                return _lastPrice;
            }
            set
            {
                _lastPrice = value;
            }
        }
        private bool listaIniciada = false;

        private bool connectedTryd = false;
        private bool connectedNinja = false;


        public double valorAtualMenosA100Periodos()
        {
            //double somaVars100Periodos = 0;
            //for (int i = historico3s.Count - 100; i < historico3s.Count -1; i++)
            //{
            //    somaVars100Periodos +=
            //}
            return historico3s[historico3s.Count - 1] - historico3s[historico3s.Count - 100];
        }

        public double addVar(double varToAdd)
        {
            _lastPrice = _lastPrice + varToAdd;
            return _lastPrice;

        }
        public void adviseVoid(object obj, NDde.Client.DdeAdviseEventArgs e)
        {
            Console.WriteLine("Simulador");
        }

        public void ConnectDdeTryd()
        {
            Console.WriteLine("Simulador");

        }

        public void DisconnectDdeTryd()
        {
            Console.WriteLine("Simulador");

        }


        public NinjaTrader.Client.Client NtClient { get; set; }

        public void ConnectNinja()
        {
            Console.WriteLine("Simulador");
        }

        public void DisconnectNinja()
        {
            Console.WriteLine("Simulador");
        }

    }
}
