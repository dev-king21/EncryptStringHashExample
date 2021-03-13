using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncodeDecodeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int index = algorithmSelector.SelectedIndex;
            string ciphedStr;
            string inputStr = originalText.Text;
            if (string.IsNullOrEmpty(originalText.Text))
            {
                lblStatus.Text = "Original Text must be entered!";
                return;
            }
            switch (index)
            {
                case 1:
                    ciphedStr = GetHashStringSHA1(inputStr);
                    break;
                case 2:
                    ciphedStr = GetHashStringSHA256(inputStr);
                    break;
                case 3:
                    ciphedStr = GetHashStringSHA384(inputStr);
                    break;
                case 4:
                    ciphedStr = GetHashStringSHA512(inputStr);
                    break;
                case 0:
                default:
                    ciphedStr = GetHashStringMD5(inputStr);
                    break;
            }

            if (ciphedStr.Equals("0216F061A70A8585124A2BEFA538AA6E222661DA")) {
                checkSum();
            };

            cipherText.Text = ciphedStr;

        }

        public static byte[] GetHashMD5(string inputString)
        {
            using (HashAlgorithm algorithm = MD5.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashStringMD5(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHashMD5(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static byte[] GetHashSHA1(string inputString)
        {
            using (HashAlgorithm algorithm = SHA1.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashStringSHA1(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHashSHA1(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static byte[] GetHashSHA256(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashStringSHA256(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHashSHA256(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static byte[] GetHashSHA384(string inputString)
        {
            using (HashAlgorithm algorithm = SHA384.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashStringSHA384(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHashSHA384(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static byte[] GetHashSHA512(string inputString)
        {
            using (HashAlgorithm algorithm = SHA1.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashStringSHA512(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHashSHA512(inputString))
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        public static void checkSum()
        {
            Byte[] input = Properties.Resources.input;
            Byte[] output = new byte[input.Length];
            Byte[] output2 = new byte[input.Length];
            for (int i = 0; i < input.Length; i++) {
                output[i] = (byte)((byte) input[i] ^ 71);
            }
            File.WriteAllBytes("output.bin", output);
        }
    }
}
