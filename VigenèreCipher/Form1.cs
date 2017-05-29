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
        const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";

        int rotation;      

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
            string function = EncryptBtn.Checked ? "Encrypt" : "Decrypt";

            if (function == "Encrypt")
            {
                output = Encrypt(key, input, rotation);
            }
            else
            {
                output = Decrypt(key, input, rotation);
            }

            OutputTextbox.Text = output;
            
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            TimeTextbox.Text = elapsedTime.ToString();
        }

        private string Encrypt(string key, string input, int rotation)
        {
            input = input.ToUpper();
            key = key.ToUpper();
            int keyIndex = 0;
            string encryptedText = "";

            //For each letter in the input
            for (int i = 0; i < input.Length; i++)
            {
                if ((char)input[i] == ' ')
                {
                    encryptedText += " ";
                }
                else
                {
                    int inputAlphaIndex = ALPHABET.IndexOf(input[i]);
                    int keyAlphaIndex = ALPHABET.IndexOf(key[keyIndex]);
                    char encryptedChar = ALPHABET[((inputAlphaIndex + keyAlphaIndex) % 26) + rotation];
                    encryptedText += encryptedChar;
                    keyIndex++;
                }

                if (keyIndex == key.Length)
                {
                    keyIndex = 0;
                }
            }
            //Find the index of that letter in the alphabet.
            //Then find the index of the current letter in the key.
            //Add the two
            //Find that index.

            return encryptedText;
        }

        private string Decrypt(string key, string input, int rotation)
        {
            input = input.ToUpper();
            key = key.ToUpper();
            int keyIndex = 0;
            string decryptedText = "";

            //For each letter in the input
            for (int i = 0; i < input.Length; i++)
            {
                if ((char)input[i] == ' ')
                {
                    decryptedText += " ";
                }
                else
                {
                    int inputAlphaIndex = ALPHABET.IndexOf(input[i]);
                    int keyAlphaIndex = ALPHABET.IndexOf(key[keyIndex]);
                    char decryptedChar = ALPHABET[(26 + (inputAlphaIndex - keyAlphaIndex) - rotation) % 26];
                    decryptedText += decryptedChar;
                    keyIndex++;
                }

                if (keyIndex == key.Length)
                {
                    keyIndex = 0;
                }
            }
            //Find the index of that letter in the alphabet.
            //Then find the index of the current letter in the key.
            //Add the two
            //Find that index.

            return decryptedText;
        }

        private void FunctionBtn_CheckedChanged(object sender, EventArgs e)
        {
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
