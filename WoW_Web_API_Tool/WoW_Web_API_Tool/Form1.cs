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

namespace WoW_Web_API_Tool
{
    /****************************************************************
     * Version 1.0 - WoW Web API Tool-  Written by Jessica Rizzo 4-27-2014
     *
     * This tool allows a user to test calls to the Item and Item Set 
     * API's which are part of the WoW Web API system.  
     * 
     * The tool makes HTTP Requests and receives HTTP Responses and tracks
     * the results.  A user can specify if they wish to call the Item API
     * or if they wish to call the Item Set API.  The user can specify
     * an item Id they wish to send in their request.  In addition they can
     * specify how many times they wish to send the request.
     * 
     * Additional Features:
     * -Added a randomize Item Id function which will send random Ids to
     * test for broader coverage across each API.
     * -Added reporting which will record how many successes or failures
     *   -Tracking for failures caused by timeout
     *   -Tracking for failures caused by item not found.
     * 
     * Updated - 4-27-14
     * -Added Error log structure to save a file with the contents of
     *  the exceptions. (note this has not been fully implemented as of 4-27-14)
     *     
     *
     * * *************************************************************/



    public partial class Form1 : Form
    {
        string itemId;
        string urlAddress;
        string getUrlAddress;
        string Host;
        string GetData;
        byte[] data;

        // Reporting Global Variables
        int timeOutCounter = 0;
        int reportError = 0;
        int numberOfGetsSent = 0;
        int getSucceeded = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public string SetUrl
        {
            set
            {
                // If the item API is selected and the Randomize checkbox is NOT selected then use the Item ID specified by the user.
                if (ApiSelectCbo.Text == "Item" && (!(RndIdCb.Checked)))
                {
                    itemId = EnterIdTb.Text;      
                    Host = "http://us.battle.net";
                    urlAddress = Host + "/api/wow/item/" + itemId;
                    GetData = urlAddress + EnterIdTb.Text;
                    data = Encoding.ASCII.GetBytes(GetData);
                }
                
                // If the Item API is selected and the Randomize checkbox is also selected then randomize an item ID for the user.
                else if (ApiSelectCbo.Text == "Item" && (RndIdCb.Checked))
                {
                    Random random = new Random();
                    int randItemId = random.Next(0, 99999);
                    Host = "http://us.battle.net";
                    urlAddress = Host + "/api/wow/item/" + randItemId;
                    GetData = urlAddress + EnterIdTb.Text;
                    data = Encoding.ASCII.GetBytes(GetData);
                }
                else if (ApiSelectCbo.Text == "Item Set" && (RndIdCb.Checked))
                {
                    Random random = new Random();
                    int randSetItemId = random.Next(0, 1300);
                    Host = "http://us.battle.net";
                    urlAddress = Host + "/api/wow/item/set/" + randSetItemId;
                    GetData = urlAddress + EnterIdTb.Text;
                    data = Encoding.ASCII.GetBytes(GetData);
                }
                else
                {
                    itemId = EnterIdTb.Text;
                    Host = "http://us.battle.net";
                    urlAddress = Host + "/api/wow/item/set/" + itemId;
                    GetData = urlAddress + EnterIdTb.Text;
                    data = Encoding.ASCII.GetBytes(GetData);
                }
            }
        }

        // The SetGet property ensures that the Get KeyUpDown control value is always greater than 0.

        public int SetGet
        {
            set
            {
                if (!(GetControllerUD.Value > 0))
                {
                    MessageBox.Show("The number of GET requests must be more than 0.");
                    GetControllerUD.Focus();
                }
            }
        }

        private void GetRequest_Click(object sender, EventArgs e)
        {
            if (ApiSelectCbo.Text == "")
            {
                MessageBox.Show("You must first select an API");
                ApiSelectCbo.Focus();
            }

            else if (!(GetControllerUD.Value > 0))
            {
                MessageBox.Show("The number of GET requests must be more than 0.");
                GetControllerUD.Focus();
            }
            else
                // We will continue the loop to send Get Requests to the server until our counter variable is no longer equivalent to the
                // user specified KeyUpDown value. 
                // Using a private numberOfGetsSent variable we will keep track of how many times a request has been sent for reporting purposes.
                for (int i = 0; i < GetControllerUD.Value; i++)
                {
                    GetRequest();
                    numberOfGetsSent++;
                }
            UpdateReport();
        }

        private void GetRequest()
        {

            try
            {
                HttpRequestData();
            }

            // We catch the exceptions, sectioning out timeout exceptions from general exceptions.

            catch (Exception ex)
            {   
                if (ex is WebException && ex.Message.Contains("The operation has timed out"))
                {
                    timeOutCounter++;
                //  MessageBox.Show("A Timeout has occurred with the GET request. " + "\n" + "Current Count: " + timeOutCounter);
                }

                // *Generally other exceptions are caused by a 404 returned by the HTTP request -- This is typically indicative of Status | reason "nok" 
                else
                {
                //  MessageBox.Show("The following error occurred: " + ex.Message);
                    reportError++;
                }                
            } 
        }

        // This method controls the entierty of the HTTP Request, HTTP Response and Streamreader information.  
        // It handles creating the request, reading and closing the stream.

        public void HttpRequestData()
        {
            SetUrl = "";
            getUrlAddress = urlAddress;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(getUrlAddress);
            req.Method = "GET";
            req.ContentType = "application/json";

            // Sets the timeout value for testing purposes
            req.Timeout = 1;
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            string GetData = getUrlAddress;
            byte[] data = Encoding.ASCII.GetBytes(GetData);
            Stream stream = resp.GetResponseStream();
            stream.Read(data, 0, data.Length);
            StreamReader reader = new StreamReader(stream);
            reader.ReadToEnd();
            reader.Close();
            stream.Close();
            getSucceeded++;
        }

        // Any time the Get KeyUpDown controls value changes we check it's property condition.

        private void GetControllerUD_ValueChanged(object sender, EventArgs e)
        {
            SetGet = (int)GetControllerUD.Value;
        }

        // If this checkbox is enabled the control that handles sending individual Item or Item Sets will be disabled and cleared
        // When calling GetRequest() the system will check the status of this checkbox to determine if the Item/Set Id should be randomized or not.
        private void RndIdCb_CheckedChanged(object sender, EventArgs e)
        {
            if (RndIdCb.Checked)
            {
                EnterIdTb.Text = "";
                EnterIdTb.Enabled = false;
                
            }
            else 
                EnterIdTb.Enabled = true;
        }

        // The reporting function keeps track of all of the reporting variables and updates it on the form.
        // This will list out the number of requests sent, the number of successes, failures and the likely types of failure (timeout, etc.) for the user.

        private void UpdateReport()
        {
            if (numberOfGetsSent > 0)
            {
                ResultRptTb.Text = "GET Request Results for " + numberOfGetsSent + " requests:" + "\r\n" + "\r\n" +
                                    "Succeeded: " + getSucceeded +
                                    "\r\n" + "\r\n" + "Failed: " + (timeOutCounter + reportError) + "\r\n" + "Timed out: "
                                    + (int)timeOutCounter + "\t" + "Item Not Found: " + reportError;
                if (timeOutCounter > 0)
                {
                    DialogResult resultmsg = MessageBox.Show("Server timeouts were detected in the response" + "\r\n" + "Do you wish to Save a Log?",
                                                            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    // TODO: This section is reserved for future versions -- We will be saving an Error log which the user will save
                    // 4-27-14 -- Added SaveDialogue and streamwriter Open file logic.
                    {
                        if (resultmsg == DialogResult.Yes)
                        {
                            SaveFileDialog save = new SaveFileDialog();

                            DateTime currentDateTime = DateTime.Now;
                            //currentDateTime.ToString("dd-MM-yyy-hh-mm-ss");
                            save.FileName = "WoWAPIErrorLog" + currentDateTime.ToString("MM-dd-HH-mm-ss");
                            save.Filter = "Text File | *.txt";
                            if (save.ShowDialog() == DialogResult.OK)
                            {
                                StreamWriter sw = new StreamWriter(save.OpenFile());

                            }
                        }
                    }
                }
            }

        }

        // This method resets the reporting display on the form and sets the global variables back to their defaults
        private void ResetRptBtn_Click(object sender, EventArgs e)
        {
            ResultRptTb.Text = "Results:";
            timeOutCounter = 0;
            reportError = 0;
            numberOfGetsSent = 0;
            getSucceeded = 0;
        }
    }
}