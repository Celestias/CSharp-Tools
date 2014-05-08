using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WoW_Web_API_POST
{
    public partial class Form1 : Form
    {
        private int getCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public int GetCounter
        {
            get
            {
                return getCounter;
            }
            set
            {
                getCounter += numberOfGetsSent;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(GetControllerUD.Value > 0))
            {
                MessageBox.Show("Please specify how many GET requests to send.");
                GetControllerUD.Focus();
            }
            else
            SendInfo();
        }
        
        int timeOutCounter = 0;
        int numberOfGetsSent = 0;
        private void SendInfo()
        {
            
            try
            {
                string itemId = textBox1.Text;
                // Enter 17193
                //string itemSetId = textBox2.Text;
                string urladdress;
                string Host = "http://us.battle.net";
                urladdress = Host + "/api/wow/item/" + itemId;
                
               
                ASCIIEncoding uniCharacters = new ASCIIEncoding();
                string postData = urladdress + textBox1.Text; // "itemSetId = " + itemSetId;
                byte[] data = Encoding.ASCII.GetBytes(postData); // uniCharacters.GetBytes(getData);

                //WebRequest Request = WebRequest.Create("http://us.battle.net/api/wow/item/17193");
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(urladdress);
                req.Method = "GET";
                req.ContentType = "application/json";
                req.Timeout = 3000;
                numberOfGetsSent++;
                getCounter = 1;
                /*if (TimeoutException)
                {
                    timeOutCounter++;
                }*/
                
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                //stream.Write(data, 0, data.Length);
                stream.Read(data, 0, data.Length);

                StreamReader reader = new StreamReader(stream);
                reader.ReadToEnd();
                reader.Close();
                stream.Close();
                

                /*Request.Timeout = 30000;
                Request.Method = "GET";
                //Request.Method = "POST";
                //Request.ContentType = "text/x-json";
                Request.ContentType = "application/json";
                //Request.ContentType = "application/x-www-form-urlencoded";
                Request.ContentLength = data.Length;

                Stream stream = Request.GetRequestStream();
                // Web Request stream for writing the web request data
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
                // re-use the stream object to get the response stream
                stream = Response.GetResponseStream();

                //create a stream reader object to read the response stream
                StreamReader sr = new StreamReader(stream);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
                stream.Close();
            */}
            
            catch (Exception ex)
            {
                if (ex is WebException && ex.Message.Contains("The operation has timed out"))
                {
                    timeOutCounter++;
                    MessageBox.Show("A Timeout has occurred with the GET request. " + "\n" + "Current Count: " + timeOutCounter);
                }
                else
                {
                    MessageBox.Show("The following error occurred: " + ex.Message);
                }
            }
                
        }

        public int TimeOutCounter(int timeOutCounter)
        {
            
            return timeOutCounter++; //return timeOutCounter;
        }
    }
}
