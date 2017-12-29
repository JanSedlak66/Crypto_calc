using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

//using Newtonsoft.Json.Converters;

using System.Web;

namespace Crypto_calc
{
    public partial class Main_win : Form
    {
        static string[] burzy = {"blockchain","bitstamp","poloniex","bitfinex","bittrex"};
        string actual_burza;
        string last_mena_input;

        string str2double_format = "N2";
        string str2double_format_btc = "N8";

        System.Net.WebClient wc;

        Chart_win myChart_win;

        public Main_win()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            myChart_win = new Chart_win(this);

            // nazvy burz
            radioButton1.Text = burzy[0];
            radioButton2.Text = burzy[1];
            radioButton3.Text = burzy[2];

            int a = 0;
            textBox_btc.Text = a.ToString(str2double_format_btc);
            textBox_usd.Text = a.ToString(str2double_format);
            textBox_czk.Text = a.ToString(str2double_format);

            // inicializace
            actual_burza = burzy[0];
            last_mena_input = "BTC";

            toolStripStatusLabel1.Text = "";

            // formatovani font
            //textBox_vystup.Font = new Font("Arial", 24, FontStyle.Bold);
            //textBox_vystup.CharacterCasing = CharacterCasing.Upper;

            // inicializace webove rozhranni
            wc = new System.Net.WebClient();

            set_TextBoxChenched_EventHandler(true);
            
            timer1_Tick(this,null);

            sToolStripMenuItem30s.Checked = true;
            timer1.Interval = 30000;
            timer1.Enabled = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            set_TextBoxChenched_EventHandler(false);
            int a = 0;
            textBox_btc.Text = a.ToString(str2double_format_btc);
            textBox_usd.Text = a.ToString(str2double_format);
            textBox_czk.Text = a.ToString(str2double_format);
            set_TextBoxChenched_EventHandler(true);
        }

        private void tOPWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tOPWinToolStripMenuItem.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        void set_TextBoxChenched_EventHandler(bool a){
            if(a){
                this.textBox_btc.TextChanged += new System.EventHandler(this.textBox_btc_TextChanged);
                this.textBox_usd.TextChanged += new System.EventHandler(this.textBox_usd_TextChanged);
                this.textBox_czk.TextChanged += new System.EventHandler(this.textBox_czk_TextChanged);
            }else{
                this.textBox_btc.TextChanged -= new System.EventHandler(this.textBox_btc_TextChanged);
                this.textBox_usd.TextChanged -= new System.EventHandler(this.textBox_usd_TextChanged);
                this.textBox_czk.TextChanged -= new System.EventHandler(this.textBox_czk_TextChanged);
            }
        }

        // akce vstup
        private void textBox_btc_TextChanged(object sender, EventArgs e)
        {
            vysledek("BTC");
            last_mena_input = "BTC";
        }

        private void textBox_usd_TextChanged(object sender, EventArgs e)
        {
            vysledek("USD");
            last_mena_input = "USD";
        }

        private void textBox_czk_TextChanged(object sender, EventArgs e)
        {  
            vysledek("CZK");
            last_mena_input = "CZK";
        }

        // vyber burza
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                actual_burza = burzy[0];
                vysledek(last_mena_input);
            }
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                actual_burza = burzy[1];
                vysledek(last_mena_input);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                actual_burza = burzy[2];
                vysledek(last_mena_input);
            }
        }

        private void radioButton_bitfinex_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_bitfinex.Checked)
            {
                actual_burza = burzy[3];
                vysledek(last_mena_input);
            }
        }

        private void radioButton_bittrex_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_bittrex.Checked)
            {
                actual_burza = burzy[4];
                vysledek(last_mena_input);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double ratio1 = 0;
            double[] data = new double[5];
            // vysledek(last_mena_input);

            toolStripStatusLabel1.Text = "OK";

            try
            {
                ratio1 = get_blockchain_exchange("1.0");  //  usd to btc
                data[0] = (1 / ratio1);
                radioButton1.Text = "blockchain " + (1 / ratio1).ToString(str2double_format) + " USD";
            }
            catch (Exception err)
            {
                radioButton1.Text = "blockchain " + "pool error";
                data[0] = 0;
                toolStripStatusLabel1.Text = "Error: " + err.Message;
            }

            try{
                ratio1 = get_bitstamp_exchange("btcusd");
                data[1] = ratio1;
                radioButton2.Text = "bitstamp     " + ratio1.ToString(str2double_format) + " USD";
            }catch (Exception err){
                radioButton2.Text = "bitstamp     " + "pool error";
                data[1] = 0;
                toolStripStatusLabel1.Text = "Error: " + err.Message;
            }

            try{
                ratio1 = get_poloniex_exchange();
                data[2] = ratio1;
                radioButton3.Text = "poloniex     " + ratio1.ToString(str2double_format) + " USD";
            }catch (Exception err){
                radioButton3.Text = "poloniex     " + "pool error";
                data[2] = 0;
                toolStripStatusLabel1.Text = "Error: " + err.Message;
            }
            
            try{
                ratio1 = get_bitfinex_exchange();
                data[3] = ratio1;
                radioButton_bitfinex.Text = "bitfinex       " + ratio1.ToString(str2double_format) + " USD";
            }catch (Exception err){
                radioButton_bitfinex.Text = "bitfinex       " + "pool error";
                data[3] = 0;
                toolStripStatusLabel1.Text = "Error: " + err.Message;
            }
            
            try{
                ratio1 = get_bittrex_exchange();
                data[4] = ratio1;
                radioButton_bittrex.Text = "bittrex        " + ratio1.ToString(str2double_format) + " USD";
            }catch (Exception err){
                radioButton_bittrex.Text = "bittrex        " + "pool error";
                data[4] = 0;
                toolStripStatusLabel1.Text = "Error: " + err.Message;
            }

                myChart_win.putData(data);
        
        }

        private void vysledek(string mena_in)
        {
            double inValue = 0;
            double ratio1 = 0, ratio2 = 0;

            set_TextBoxChenched_EventHandler(false); // stop preruseni pokud zmena textu v bunce

               try
               {
                    switch (actual_burza)
                    {
                        case "blockchain":

                            if (mena_in.Contains("BTC"))
                            {
                                Double.TryParse(textBox_btc.Text, out inValue);

                                ratio1 = get_blockchain_exchange("1.0");  //  usd to btc
                                ratio2 = get_usd_czk();

                                textBox_usd.Text = (inValue / ratio1).ToString(str2double_format);
                                textBox_czk.Text = ((inValue / ratio1) * ratio2).ToString(str2double_format);
                            }
                            else if (mena_in.Contains("USD"))
                            {
                                Double.TryParse(textBox_usd.Text, out inValue);
                               
                                ratio1 = get_blockchain_exchange(inValue.ToString());  //  usd to btc
                                ratio2 = get_usd_czk();

                                textBox_btc.Text = ratio1.ToString(str2double_format_btc);
                                textBox_czk.Text = (inValue * ratio2).ToString(str2double_format);
                            }
                            else if (mena_in.Contains("CZK"))
                            {
                                Double.TryParse(textBox_czk.Text, out inValue);

                                ratio1 = get_blockchain_exchange("1.0");  //  usd to btc
                                ratio2 = get_usd_czk();

                                textBox_usd.Text = (inValue / ratio2).ToString(str2double_format);
                                textBox_btc.Text = ((inValue / ratio2) * ratio1).ToString(str2double_format_btc);
                            }

                            break;

                        case "bitstamp":

                            if (mena_in.Contains("BTC")) {

                                Double.TryParse(textBox_btc.Text, out inValue);

                                ratio1 = get_bitstamp_exchange("btcusd");
                                ratio2 = get_usd_czk();

                                textBox_usd.Text = (inValue * ratio1).ToString(str2double_format);
                                textBox_czk.Text = ((inValue * ratio1) * ratio2).ToString(str2double_format);
                            }
                            else if (mena_in.Contains("USD")) 
                            {
                                Double.TryParse(textBox_usd.Text, out inValue);

                                ratio1 = get_bitstamp_exchange("btcusd");
                                ratio2 = get_usd_czk();

                                textBox_btc.Text = (inValue / ratio1).ToString(str2double_format_btc);
                                textBox_czk.Text = (inValue * ratio2).ToString(str2double_format);
                            }
                            else if (mena_in.Contains("CZK")) 
                            {
                                Double.TryParse(textBox_czk.Text, out inValue);

                                ratio1 = get_bitstamp_exchange("btcusd");
                                ratio2 = get_usd_czk();

                                textBox_usd.Text = (inValue / ratio2).ToString(str2double_format);
                                textBox_btc.Text = ((inValue / ratio2) / ratio1).ToString(str2double_format_btc);
                            }

                           
                            // currency_pair: btcusd, btceur, eurusd, xrpusd, xrpeur, xrpbtc, ltcusd, ltceur, ltcbtc, ethusd, etheur, ethbtc, bchusd, bcheur, bchbtc
                                
                            break;

                        case "poloniex":

                            //string request = String.Format("http://www.xe.com/ucc/convert.cgi?Amount={0}&From={1}&To={2}", value, inputCurrency, outputCurrency);

                            if (mena_in.Contains("BTC"))
                            {

                                Double.TryParse(textBox_btc.Text, out inValue);

                                ratio1 = get_poloniex_exchange();
                                ratio2 = get_usd_czk();

                                textBox_usd.Text = (inValue * ratio1).ToString(str2double_format);
                                textBox_czk.Text = ((inValue * ratio1) * ratio2).ToString(str2double_format);
                            }
                            else if (mena_in.Contains("USD"))
                            {
                                Double.TryParse(textBox_usd.Text, out inValue);

                                ratio1 = get_poloniex_exchange();
                                ratio2 = get_usd_czk();

                                textBox_btc.Text = (inValue / ratio1).ToString(str2double_format_btc);
                                textBox_czk.Text = (inValue * ratio2).ToString(str2double_format);
                            }
                            else if (mena_in.Contains("CZK"))
                            {
                                Double.TryParse(textBox_czk.Text, out inValue);

                                ratio1 = get_poloniex_exchange();
                                ratio2 = get_usd_czk();

                                textBox_usd.Text = (inValue / ratio2).ToString(str2double_format);
                                textBox_btc.Text = ((inValue / ratio2) / ratio1).ToString(str2double_format_btc);
                            }

                            break;

                        case "bitfinex":

                            if (mena_in.Contains("BTC"))
                            {

                                Double.TryParse(textBox_btc.Text, out inValue);

                                ratio1 = get_bitfinex_exchange();
                                ratio2 = get_usd_czk();

                                textBox_usd.Text = (inValue * ratio1).ToString(str2double_format);
                                textBox_czk.Text = ((inValue * ratio1) * ratio2).ToString(str2double_format);
                            }
                            else if (mena_in.Contains("USD"))
                            {
                                Double.TryParse(textBox_usd.Text, out inValue);

                                ratio1 = get_bitfinex_exchange();
                                ratio2 = get_usd_czk();

                                textBox_btc.Text = (inValue / ratio1).ToString(str2double_format_btc);
                                textBox_czk.Text = (inValue * ratio2).ToString(str2double_format);
                            }
                            else if (mena_in.Contains("CZK"))
                            {
                                Double.TryParse(textBox_czk.Text, out inValue);

                                ratio1 = get_bitfinex_exchange();
                                ratio2 = get_usd_czk();

                                textBox_usd.Text = (inValue / ratio2).ToString(str2double_format);
                                textBox_btc.Text = ((inValue / ratio2) / ratio1).ToString(str2double_format_btc);
                            }

                            break;

                        case "bittrex":

                            if (mena_in.Contains("BTC"))
                            {

                                Double.TryParse(textBox_btc.Text, out inValue);

                                ratio1 = get_bittrex_exchange();
                                ratio2 = get_usd_czk();

                                textBox_usd.Text = (inValue * ratio1).ToString(str2double_format);
                                textBox_czk.Text = ((inValue * ratio1) * ratio2).ToString(str2double_format);
                            }
                            else if (mena_in.Contains("USD"))
                            {
                                Double.TryParse(textBox_usd.Text, out inValue);

                                ratio1 = get_bittrex_exchange();
                                ratio2 = get_usd_czk();

                                textBox_btc.Text = (inValue / ratio1).ToString(str2double_format_btc);
                                textBox_czk.Text = (inValue * ratio2).ToString(str2double_format);
                            }
                            else if (mena_in.Contains("CZK"))
                            {
                                Double.TryParse(textBox_czk.Text, out inValue);

                                ratio1 = get_bittrex_exchange();
                                ratio2 = get_usd_czk();

                                textBox_usd.Text = (inValue / ratio2).ToString(str2double_format);
                                textBox_btc.Text = ((inValue / ratio2) / ratio1).ToString(str2double_format_btc);
                            }

                            break;

                        default:
                            textBox_btc.Text = "Error 1";
                            textBox_usd.Text = "Error 1";
                            textBox_czk.Text = "Error 1";
                            break;
                    }

                    // TODO: KURZ JE z BITSTAMP VZDY 
                    double kurz_usd_1eur = get_bitstamp_exchange("eurusd");
                    toolStripStatusLabel1.Text = "1 EUR = " + kurz_usd_1eur.ToString(str2double_format) + " USD";


                }
               catch (Exception err)
               {
                   textBox_btc.Text = "Error 2";
                   textBox_usd.Text = "Error 2";
                   textBox_czk.Text = "Error 2";

                   toolStripStatusLabel1.Text = "Error: " + err.Message;
               }

               set_TextBoxChenched_EventHandler(true); // start preruseni pokud zmena textu v bunce
                
        }

        
        double get_bittrex_exchange()
        {
            string request;
            dynamic apiResponse;

            request = "https://bittrex.com/api/v1.1/public/getticker?market=USDT-BTC";

            apiResponse = wc.DownloadString(request);    // This is a blocking operation.
            wc.Dispose();

            Zaznam_bittrex_root data = JsonConvert.DeserializeObject<Zaznam_bittrex_root>(apiResponse);

            return data.result.Last;
        }

        double get_bitfinex_exchange()
        {
            string request;
            dynamic apiResponse;
            double res;

            request = "https://api.bitfinex.com/v1/pubticker/BTCUSD";

            apiResponse = wc.DownloadString(request);    // This is a blocking operation.
            wc.Dispose();

            Zaznam_bitfinex data = JsonConvert.DeserializeObject<Zaznam_bitfinex>(apiResponse);

            Double.TryParse(data.last_price.Replace('.', ','), out res);

            return res;
        }

        double get_poloniex_exchange()
        {
            string request;
            dynamic apiResponse;
            double res;

            request = "https://poloniex.com/public?command=returnTicker";

            apiResponse = wc.DownloadString(request);    // This is a blocking operation.
            wc.Dispose();

            Zaznam_poloniex_root data = JsonConvert.DeserializeObject<Zaznam_poloniex_root>(apiResponse);

            Double.TryParse(data.USDT_BTC.last.Replace('.', ','), out res);

            return res;
        }
        
        double get_usd_czk(){

            string request;
            dynamic apiResponse;

            request = "https://api.fixer.io/latest?symbols=USD,CZK";

            apiResponse = wc.DownloadString(request);    // This is a blocking operation.
            wc.Dispose();

            Data_fixer data = JsonConvert.DeserializeObject<Data_fixer>(apiResponse);

            return (data.rates.CZK/data.rates.USD);
        }

        double get_blockchain_exchange(string numValue)  // zatim jen USD to btc 
        {
            string request;
            dynamic apiResponse;
            string mena = "USD";

            request = String.Format("https://blockchain.info/tobtc?currency={0}&value={1}", mena, numValue);
            apiResponse = wc.DownloadString(request);
            wc.Dispose();

            double numValue2 = 0;
            bool parsed2 = Double.TryParse(apiResponse.Replace('.', ','), out numValue2);

            return numValue2;
        }

        double get_bitstamp_exchange(string strValue)
        {
            string request;
            double kurz = 0;
            dynamic apiResponse;

            if (strValue.Equals(""))
            {
                return 0;
            }

            if(false){
                /*
                request = String.Format("https://www.bitstamp.net/api/v2/transactions/{0}/", strValue);

                apiResponse = wc.DownloadString(request);    // This is a blocking operation.
                wc.Dispose();

                JArray array = JArray.Parse(apiResponse);

                Zaznam[] klm = new Zaznam[array.Count];
                double[] price = new Double[array.Count];

                int index = 0;

                foreach (JObject obj in array.Children<JObject>())
                {
                    Zaznam data = JsonConvert.DeserializeObject<Zaznam>(obj.ToString());
                    klm[index] = data;
                    Double.TryParse(data.price.Replace('.', ','), out price[index]);
                    index++;
                }

                // aritmeticky prumer
                double sum = 0;
                for (int i = 0; i <= price.Length - 1; i++)
                {
                    sum += price[i];
                }

                kurz = sum / price.Length;
                */
            }else{

                request = String.Format("https://www.bitstamp.net/api/v2/ticker_hour/{0}/", strValue);

                apiResponse = wc.DownloadString(request);    // This is a blocking operation.
                wc.Dispose();

                Zaznam_bitstamp data = JsonConvert.DeserializeObject<Zaznam_bitstamp>(apiResponse);

                Double.TryParse(data.last.Replace('.', ','), out kurz);

            }

            return kurz;
        }

        private void sToolStripMenuItem10s_Click(object sender, EventArgs e)
        {

            if (sToolStripMenuItem10s.Checked == true)
            {
                timer1.Enabled = true;
                timer1.Interval = 10000;
            }
            else
            {
                timer1.Enabled = false;
            }

            sToolStripMenuItem1s.Checked = false;
            sToolStripMenuItem5s.Checked = false;
            sToolStripMenuItem30s.Checked = false;
        }

        private void sToolStripMenuItem30s_Click(object sender, EventArgs e)
        {
            if (sToolStripMenuItem30s.Checked == true)
            {
                timer1.Enabled = true;
                timer1.Interval = 30000;
            }
            else
            {
                timer1.Enabled = false;
            }

            sToolStripMenuItem1s.Checked = false;
            sToolStripMenuItem5s.Checked = false;
            sToolStripMenuItem10s.Checked = false;
        }

        private void sToolStripMenuItem5s_Click(object sender, EventArgs e)
        {
            if (sToolStripMenuItem5s.Checked == true)
            {
                timer1.Enabled = true;
                timer1.Interval = 5000;
            }
            else
            {
                timer1.Enabled = false;
            }

            sToolStripMenuItem1s.Checked = false;
            sToolStripMenuItem10s.Checked = false;
            sToolStripMenuItem30s.Checked = false;
        }

        private void sToolStripMenuItem1s_Click(object sender, EventArgs e)
        {
            if (sToolStripMenuItem1s.Checked == true)
            {
                timer1.Enabled = true;
                timer1.Interval = 1000;
            }
            else
            {
                timer1.Enabled = false;
            }

            sToolStripMenuItem5s.Checked = false;
            sToolStripMenuItem10s.Checked = false;
            sToolStripMenuItem30s.Checked = false;
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myChart_win.Visible)
            {
                myChart_win.Visible = false;
            }else{
                myChart_win.Visible = true;
            }

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutWindow = new AboutBox();
            aboutWindow.Show();
        }

    }

    public class Zaznam_bittrex
    {
        public double Bid { get; set; }
        public double Ask { get; set; }
        public double Last { get; set; }
    }

    public class Zaznam_bittrex_root
    {
        public bool success { get; set; }
        public string message { get; set; }
        public Zaznam_bittrex result { get; set; }
    }

    public class Zaznam_bitfinex
    {
        public string mid { get; set; }
        public string bid { get; set; }
        public string ask { get; set; }
        public string last_price { get; set; }
        public string low { get; set; }
        public string high { get; set; }
        public string volume { get; set; }
        public string timestamp { get; set; }
    }

    public class Rates
    {
        public double CZK { get; set; }
        public double USD { get; set; }
    }

    public class Data_fixer
    {
        public string @base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
    }


    public class Zaznam_poloniex
    {
        public int id { get; set; }
        public string last { get; set; }
        public string lowestAsk { get; set; }
        public string highestBid { get; set; }
        public string percentChange { get; set; }
        public string baseVolume { get; set; }
        public string quoteVolume { get; set; }
        public string isFrozen { get; set; }
        public string high24hr { get; set; }
        public string low24hr { get; set; }
    }
    public class Zaznam_poloniex_root
    {
        public Zaznam_poloniex BTC_BCN { get; set; }
        public Zaznam_poloniex BTC_BELA { get; set; }
        public Zaznam_poloniex BTC_BLK { get; set; }
        public Zaznam_poloniex BTC_BTCD { get; set; }
        public Zaznam_poloniex BTC_BTM { get; set; }
        public Zaznam_poloniex BTC_BTS { get; set; }
        public Zaznam_poloniex BTC_BURST { get; set; }
        public Zaznam_poloniex BTC_CLAM { get; set; }
        public Zaznam_poloniex BTC_DASH { get; set; }
        public Zaznam_poloniex BTC_DGB { get; set; }
        public Zaznam_poloniex BTC_DOGE { get; set; }
        public Zaznam_poloniex BTC_EMC2 { get; set; }
        public Zaznam_poloniex BTC_FLDC { get; set; }
        public Zaznam_poloniex BTC_FLO { get; set; }
        public Zaznam_poloniex BTC_GAME { get; set; }
        public Zaznam_poloniex BTC_GRC { get; set; }
        public Zaznam_poloniex BTC_HUC { get; set; }
        public Zaznam_poloniex BTC_LTC { get; set; }
        public Zaznam_poloniex BTC_MAID { get; set; }
        public Zaznam_poloniex BTC_OMNI { get; set; }
        public Zaznam_poloniex BTC_NAV { get; set; }
        public Zaznam_poloniex BTC_NEOS { get; set; }
        public Zaznam_poloniex BTC_NMC { get; set; }
        public Zaznam_poloniex BTC_NXT { get; set; }
        public Zaznam_poloniex BTC_PINK { get; set; }
        public Zaznam_poloniex BTC_POT { get; set; }
        public Zaznam_poloniex BTC_PPC { get; set; }
        public Zaznam_poloniex BTC_RIC { get; set; }
        public Zaznam_poloniex BTC_STR { get; set; }
        public Zaznam_poloniex BTC_SYS { get; set; }
        public Zaznam_poloniex BTC_VIA { get; set; }
        public Zaznam_poloniex BTC_XVC { get; set; }
        public Zaznam_poloniex BTC_VRC { get; set; }
        public Zaznam_poloniex BTC_VTC { get; set; }
        public Zaznam_poloniex BTC_XBC { get; set; }
        public Zaznam_poloniex BTC_XCP { get; set; }
        public Zaznam_poloniex BTC_XEM { get; set; }
        public Zaznam_poloniex BTC_XMR { get; set; }
        public Zaznam_poloniex BTC_XPM { get; set; }
        public Zaznam_poloniex BTC_XRP { get; set; }
        public Zaznam_poloniex USDT_BTC { get; set; }
        public Zaznam_poloniex USDT_DASH { get; set; }
        public Zaznam_poloniex USDT_LTC { get; set; }
        public Zaznam_poloniex USDT_NXT { get; set; }
        public Zaznam_poloniex USDT_STR { get; set; }
        public Zaznam_poloniex USDT_XMR { get; set; }
        public Zaznam_poloniex USDT_XRP { get; set; }
        public Zaznam_poloniex XMR_BCN { get; set; }
        public Zaznam_poloniex XMR_BLK { get; set; }
        public Zaznam_poloniex XMR_BTCD { get; set; }
        public Zaznam_poloniex XMR_DASH { get; set; }
        public Zaznam_poloniex XMR_LTC { get; set; }
        public Zaznam_poloniex XMR_MAID { get; set; }
        public Zaznam_poloniex XMR_NXT { get; set; }
        public Zaznam_poloniex BTC_ETH { get; set; }
        public Zaznam_poloniex USDT_ETH { get; set; }
        public Zaznam_poloniex BTC_SC { get; set; }
        public Zaznam_poloniex BTC_BCY { get; set; }
        public Zaznam_poloniex BTC_EXP { get; set; }
        public Zaznam_poloniex BTC_FCT { get; set; }
        public Zaznam_poloniex BTC_RADS { get; set; }
        public Zaznam_poloniex BTC_AMP { get; set; }
        public Zaznam_poloniex BTC_DCR { get; set; }
        public Zaznam_poloniex BTC_LSK { get; set; }
        public Zaznam_poloniex ETH_LSK { get; set; }
        public Zaznam_poloniex BTC_LBC { get; set; }
        public Zaznam_poloniex BTC_STEEM { get; set; }
        public Zaznam_poloniex ETH_STEEM { get; set; }
        public Zaznam_poloniex BTC_SBD { get; set; }
        public Zaznam_poloniex BTC_ETC { get; set; }
        public Zaznam_poloniex ETH_ETC { get; set; }
        public Zaznam_poloniex USDT_ETC { get; set; }
        public Zaznam_poloniex BTC_REP { get; set; }
        public Zaznam_poloniex USDT_REP { get; set; }
        public Zaznam_poloniex ETH_REP { get; set; }
        public Zaznam_poloniex BTC_ARDR { get; set; }
        public Zaznam_poloniex BTC_ZEC { get; set; }
        public Zaznam_poloniex ETH_ZEC { get; set; }
        public Zaznam_poloniex USDT_ZEC { get; set; }
        public Zaznam_poloniex XMR_ZEC { get; set; }
        public Zaznam_poloniex BTC_STRAT { get; set; }
        public Zaznam_poloniex BTC_NXC { get; set; }
        public Zaznam_poloniex BTC_PASC { get; set; }
        public Zaznam_poloniex BTC_GNT { get; set; }
        public Zaznam_poloniex ETH_GNT { get; set; }
        public Zaznam_poloniex BTC_GNO { get; set; }
        public Zaznam_poloniex ETH_GNO { get; set; }
        public Zaznam_poloniex BTC_BCH { get; set; }
        public Zaznam_poloniex ETH_BCH { get; set; }
        public Zaznam_poloniex USDT_BCH { get; set; }
        public Zaznam_poloniex BTC_ZRX { get; set; }
        public Zaznam_poloniex ETH_ZRX { get; set; }
        public Zaznam_poloniex BTC_CVC { get; set; }
        public Zaznam_poloniex ETH_CVC { get; set; }
        public Zaznam_poloniex BTC_OMG { get; set; }
        public Zaznam_poloniex ETH_OMG { get; set; }
        public Zaznam_poloniex BTC_GAS { get; set; }
        public Zaznam_poloniex ETH_GAS { get; set; }
        public Zaznam_poloniex BTC_STORJ { get; set; }
    }

    public class Zaznam_bitstamp
    {
        public string high { get; set; }
        public string last { get; set; }
        public string timestamp { get; set; }
        public string bid { get; set; }
        public string vwap { get; set; }
        public string volume { get; set; }
        public string low { get; set; }
        public string ask { get; set; }
        public string open { get; set; }
    }
    public class Zaznam : ICloneable
    {

        [JsonProperty("date")]
        public string date { get; set; }
        [JsonProperty("tid")]
        public string tid { get; set; }
        [JsonProperty("price")]
        public string price { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("amount")]
        public string amount { get; set; }

        public Zaznam()
        {
            date = "0";
            tid = "0";
            price = "0";
            amount = "0";
            type = "0";
        }

        public object Clone()
        {
            return (Zaznam) this.MemberwiseClone();
        }
    }

}
