using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenèreCipher
{
    public partial class Form1 : Form
    {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        int rotation;        
        string function;

        public Form1()
        {
            InitializeComponent();
            OutputTextbox.ReadOnly = true;
            TimeTextbox.ReadOnly = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            string key = KeyTextbox.Text;
            string input = InputTextbox.Text;
            string output;

            if (function == "Encrypt")
            {
                output = Encrypt(key, input, rotation);
            }
            else
            {
                output = Decrypt(key, input, rotation);
            }
            
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            TimeTextbox.Text = elapsedTime.ToString();
        }

        private string Encrypt(string key, string input, int rotation)
        {
            input = input.ToUpper();
            key = key.ToUpper();

            return "";
        }

        private string Decrypt(string key, string input, int rotation)
        {
            input = input.ToUpper();
            key = key.ToUpper();

            return "";
        }

        private void FunctionBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbSender = (RadioButton)sender;

            if (rbSender.Text == "Encrypt")
            {
                function = "Encrypt";
            }
            else
            {
                function = "Decrypt";
            }
        }

        private void RotationBtn_CheckChanged(object sender, EventArgs e)
        {
            RadioButton rbSender = (RadioButton)sender;

            if (rbSender.Text == "ROT0")
            {
                rotation = 0;
            }
            else
            {
                rotation = 1;
            }
        }
    }
}
