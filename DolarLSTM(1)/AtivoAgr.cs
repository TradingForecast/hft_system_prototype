using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolarLSTM_1_
{
    class AtivoAgr
    {

        //public string Name   { get; set; }
        //public Ativo(string iniCodAtivo)
        //{
        //    CodAtivo = iniCodAtivo;
        //}

        public List<double> historico3s { get; set; }
        private bool listaIniciada = false;


        public void addHistorico(double valorPraAdd)
        {
            if (listaIniciada == false)
            {
                historico3s = new List<double>();
                listaIniciada = true;
            }

            historico3s.Add(valorPraAdd);
        }


        public string CodAtivo { get; set; }
        public NDde.Client.DdeClient DdeClient { get; set; }
        private double _lastPrice;
        public double LastPrice
        {
            //get;set;
            get
            {
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
                if (connectedNinja == true)
                {
                    _lastPrice = NtClient.MarketData(CodAtivo, 0);
                }
                return _lastPrice;
            }
            set
            {
                _lastPrice = value;
            }
        }
        private bool connectedTryd = false;
        private bool connectedNinja = false;
        public void adviseVoid(object obj, NDde.Client.DdeAdviseEventArgs e)
        {
            //Console.WriteLine(e.Text);
            LastPrice = Convert.ToDouble(e.Text);
            //Console.WriteLine();
            //try
            //{
            //    if (e.Text != "0")
            //    {
            //        LastPrice = Convert.ToDouble(e.Text.Substring(0, 1) + "." + e.Text.Substring(1, e.Text.Length - 1));
            //    }
            //}
            //catch { }
            //LastPrice = CodAtivo.StartsWith("DOL") ? LastPrice * 1000 : LastPrice;
            //LastPrice = CodAtivo.StartsWith("WIN") ? LastPrice * 100 : LastPrice;

        }

        public void ConnectDdeTryd()
        {
            if (connectedTryd == false)
            {


                DdeClient = new NDde.Client.DdeClient("Stech", "COT");

                DdeClient.Connect();
                //DdeClient.StartAdvise(CodAtivo + ".0.0.2", 1, true, 15000);
                DdeClient.StartAdvise("DOLFUT.SldAgrN", 1, true, 15000);
                DdeClient.Advise += new EventHandler<NDde.Client.DdeAdviseEventArgs>(adviseVoid);
                connectedTryd = true;
            }
            else
            {
                Console.WriteLine("Tryd ja esta conectado em " + CodAtivo);

            }

        }

        public void DisconnectDdeTryd()
        {
            if (connectedTryd == true)
            {
                if (DdeClient.IsConnected)
                {
                    DdeClient.Disconnect();
                    connectedTryd = false;

                    Console.WriteLine("Tryd: " + CodAtivo + " Disconected sucessfully!");
                }
            }
            else
            {
                Console.WriteLine("Tryd: " + CodAtivo + " wasnt connected.");
            }
        }


        public NinjaTrader.Client.Client NtClient { get; set; }

        public void ConnectNinja()
        {
            if (connectedNinja == false)
            {
                NtClient = new NinjaTrader.Client.Client();

                int subscricao = NtClient.SubscribeMarketData(CodAtivo);
                LastPrice = NtClient.MarketData(CodAtivo, 0);
                connectedNinja = true;
            }
            else
            {
                Console.WriteLine("NinjaTrader ja esta conectado em " + CodAtivo);
            }
        }

        public void DisconnectNinja()
        {
            if (connectedNinja == true)
            {

                NtClient.UnsubscribeMarketData(CodAtivo);
                NtClient.TearDown();
                connectedNinja = false;



                Console.WriteLine("Ninja: " + CodAtivo + " Disconected sucessfully!");

            }
            else
            {
                Console.WriteLine("Ninja: " + CodAtivo + " wasnt connected.");
            }
        }




    }
}
