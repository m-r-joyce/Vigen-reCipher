using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace VigenèreCipher
{
    public partial class Form1 : Form
    {
        const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int rotation;      

        public Form1()
        {
            InitializeComponent();

            //"A user must be able to cut/paste text from/into the text boxes."...
            OutputTextbox.ReadOnly = true;
            TimeTextbox.ReadOnly = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Message must be at least 20 characters, no punctuation...
            Regex inputExpression = new Regex(@"^[a-zA-Z\s+]{20,}$");
            //...and key must be at least 5 characters, no punctuation.
            Regex keyExpression = new Regex(@"^[a-zA-Z]{5,}$");     
                   
            Stopwatch watch = Stopwatch.StartNew();

            string key = KeyTextbox.Text;
            string input = InputTextbox.Text;

            if (keyExpression.IsMatch(key) && inputExpression.IsMatch(input))
            {

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

                long elapsedTime = watch.ElapsedMilliseconds;
                TimeTextbox.Text = elapsedTime.ToString();
            }
            else
            {
                MessageBox.Show("Input message must be at least 20 alphabetic characters.\nKey must be at least 5 alphabetic characters.", 
                    "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private string Encrypt(string key, string input, int rotation)
        {
            input = input.ToUpper();
            key = key.ToUpper();
            int keyIndex = 0;
            string encryptedText = "";

            //For each letter in the input:
            for (int i = 0; i < input.Length; i++)
            {
                if ((char)input[i] == ' ')
                {
                    encryptedText += " ";
                }
                else
                {
                    //Find the index of that letter in the alphabet...
                    int inputAlphaIndex = ALPHABET.IndexOf(input[i]);
                    //...then find the index of the current letter in the key...
                    int keyAlphaIndex = ALPHABET.IndexOf(key[keyIndex]);
                    //...add the two, modulo 26 for wraparound, plus ROT value, and find that character in the alphabet...
                    char encryptedChar = ALPHABET[((inputAlphaIndex + keyAlphaIndex) % 26) + rotation];
                    //...add to the cipher text.
                    encryptedText += encryptedChar;
                    keyIndex++;
                }

                if (keyIndex == key.Length)
                {
                    keyIndex = 0;
                }
            }
            return encryptedText;
        }

        private string Decrypt(string key, string input, int rotation)
        {
            input = input.ToUpper();
            key = key.ToUpper();
            int keyIndex = 0;
            string decryptedText = "";

            //For each letter in the input:
            for (int i = 0; i < input.Length; i++)
            {
                if ((char)input[i] == ' ')
                {
                    decryptedText += " ";
                }
                else
                {
                    //Find the index of that letter in the alphabet...
                    int inputAlphaIndex = ALPHABET.IndexOf(input[i]);
                    //...then find the index of the current letter in the key...
                    int keyAlphaIndex = ALPHABET.IndexOf(key[keyIndex]);
                    //...add the difference plus 26, then modulo 26 for wraparound. Find that index in the alphabet...
                    char decryptedChar = ALPHABET[(26 + (inputAlphaIndex - keyAlphaIndex) - rotation) % 26];
                    //...and add to plaintext.
                    decryptedText += decryptedChar;
                    keyIndex++;
                }

                if (keyIndex == key.Length)
                {
                    keyIndex = 0;
                }
            }

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
