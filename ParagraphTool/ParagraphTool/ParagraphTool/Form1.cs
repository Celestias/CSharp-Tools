using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ParagraphTool
{
    public partial class Form1 : Form
    {
        string changedString;
        string paragraph;

        public Form1()
        {
            InitializeComponent();
            // Sets the focus to typing in the rich textbox control.
            rtfInputTb.Select();
            rtfInputTb.SelectionStart = rtfInputTb.TextLength;
        }

        // The button event handler for the Reverse Paragraph function
        private void ReverseParaBtn_Click(object sender, EventArgs e)
        {
            ReversePara();
            PrintParagraph(changedString);
        }

        // This method reverses the paragraph taken from the user input using the Array reverse method.
        // For each index in the array it then adds each word into a string, appending a space.
        private void ReversePara()
        {
            changedString = string.Empty;
            paragraph = rtfInputTb.Text;
            string[] paragraphArray = paragraph.Split();
            Array.Reverse(paragraphArray);

            for (int i = 0; i < paragraphArray.Length; i++)
            {
                changedString += paragraphArray[i];
                changedString += " ";
            }
        }

        // This Overloaded method was programmed to take a string which has already had its
        // letters re-arranged and reverse the words within the paragraph - Thus achieving the reversal of a paragraphs individual words
        // while retaining the original order of the words. 
        private void ReversePara(string text)
        {
            string reversedLetters = text;
            changedString = string.Empty;

            string[] sArr = reversedLetters.Split();
            Array.Reverse(sArr);

            for (int i = 0; i < sArr.Length; i++)
            {
                changedString += sArr[i];
                changedString += " ";
            }
        }
        // This method is in charge of formatting and outputting the string
        // to the appropriate reporting space.
        private void PrintParagraph(string text)
        {
            OutputTb.Text = text.Trim();
        }

        // The button event handler for the Reverse Words function
        // It calls the ReverseTheWords method and after returning the data it calls the Print method.
        private void RevWordsBtn_Click(object sender, EventArgs e)
        {
            changedString = ReverseTheWords(rtfInputTb.Text);
            PrintParagraph(changedString);
        }

        private string ReverseTheWords(string s)
        {
            string text = rtfInputTb.Text;
            changedString = string.Empty;

            foreach (char letter in text)
            {
                changedString = letter + changedString;
            }
            ReversePara(changedString);

            return changedString;
        }

        // The button event handler for the Alpha order function
        // It calls the SortAlphabetical method and after returning the string it calls the print method.
        private void AlphaBtn_Click(object sender, EventArgs e)
        {
            changedString = SortAlphabetical(rtfInputTb.Text);
            PrintParagraph(changedString);
        }

        private string SortAlphabetical(string s)
        {
            changedString = string.Empty;
            paragraph = rtfInputTb.Text;
            string[] paragraphArray = paragraph.Split();
            Array.Sort(paragraphArray);
            for (int i = 0; i < paragraphArray.Length; i++)
            {
                changedString += paragraphArray[i];
                changedString += " ";
            }
            return changedString;
        }

        public static string SHA384Hash(string Paragraph)
        {
            SHA384 sha = new SHA384Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(Paragraph));
            StringBuilder sb = new StringBuilder();
            foreach (byte bt in hash)
            {
                sb.AppendFormat("{0:x2}", bt);
            }
            return sb.ToString();
        }

        public void SHA384Btn_Click(object sender, EventArgs e)
        {       
            PrintParagraph(SHA384Hash(rtfInputTb.Text));         
        }
    }
}
