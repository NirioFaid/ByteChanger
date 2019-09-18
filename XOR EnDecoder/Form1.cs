using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XOR_EnDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string stringCrypt(string text, string key)
        {
            if (key == null || key == "") return text;
            char[] arr1 = text.ToCharArray();
            Array.Reverse(arr1);
            byte[] txt = Encoding.Default.GetBytes(new string(arr1));
            byte[] ckey = Encoding.Default.GetBytes(key);
            byte[] res = new byte[text.Length];
            for (int i = 0; i < txt.Length; i++)
                res[i] = (byte)(txt[i] ^ key[i % key.Length]);
            char[] arr2 = Encoding.Default.GetString(res).ToCharArray();
            Array.Reverse(arr2);
            return new string(arr2);
        }
        public byte[] byteCrypt(byte[] bytes, string key)
        {
            if (key == null || key == "") return bytes;
            progressBar1.Maximum = bytes.Length;
            progressBar1.Value = 0;
            Array.Reverse(bytes);
            byte[] content = bytes;
            byte[] ckey = Encoding.Default.GetBytes(key);
            byte[] res = new byte[bytes.Length];
            for (int i = 0; i < content.Length; i++)
            {
                res[i] = (byte)(content[i] ^ key[i % key.Length]);
                progressBar1.Value++;
            }
            bytes = res;
            Array.Reverse(bytes);
            return bytes;
        }
        public byte[] repackCrypt(byte[] bytes, string key)
        {
            if (key == null || key == "") return bytes;
            progressBar1.Maximum = 800;
            progressBar1.Value = 0;
            Array.Reverse(bytes);
            byte[] content = bytes;
            byte[] ckey = Encoding.Default.GetBytes(key);
            byte[] res = bytes;
            for (int i = 0; i < 400; i++)
            {
                res[i] = (byte)(content[i] ^ key[i % key.Length]);
                progressBar1.Value++;
            }
            for (int i = bytes.Length-400; i < bytes.Length; i++)
            {
                res[i] = (byte)(content[i] ^ key[i % key.Length]);
                progressBar1.Value++;
            }
            bytes = res;
            Array.Reverse(bytes);
            return bytes;
        }
        public static string intCrypt(string text, int Key)
        {
            string CryptedString = string.Empty;
            foreach (char c in text)
            {
                CryptedString += (char)((int)c ^ Key);
            }
            return CryptedString;
        }

        private void button_Click(object sender, EventArgs e)
        {
            string t = System.Text.Encoding.Default.GetString(System.Text.Encoding.Default.GetBytes(inputRTB.Text));
            outputRTB.Clear();
            outputRTB.AppendText(stringCrypt(t, keyInput.Text));
        }

        private void testStringButton_Click(object sender, EventArgs e)
        {
            string t = "Съешь ещё этих мягких французских булок, да выпей же чаю.\nThe five boxing wizards jump quickly.";
            inputRTB.Clear();
            inputRTB.AppendText(t);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string t = System.Text.Encoding.Default.GetString(System.Text.Encoding.Default.GetBytes(outputRTB.Text));
            Clipboard.SetText(t);
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            inputRTB.Clear();
            inputRTB.AppendText(Clipboard.GetText());
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string text = System.Text.Encoding.Default.GetString(System.Text.Encoding.Default.GetBytes(inputRTB.Text));
            for(int i=0; ;i++)
            {
                string name = $"cfile{i}";
                if (File.Exists(name)) continue;
                else { File.WriteAllText(name, stringCrypt(text, keyInput.Text)); break; }
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            string fileName, text;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if ((fileName = openFileDialog.FileName) != null)
                {
                    text = File.ReadAllText(fileName);
                    outputRTB.Clear();
                    outputRTB.AppendText(stringCrypt(text, keyInput.Text));
                }
            }
        }

        private void byteConvertButton_Click(object sender, EventArgs e)
        {
            string fileName;
            byte[] content;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if ((fileName = openFileDialog.FileName) != null)
                {
                    content = File.ReadAllBytes(fileName);
                    content = byteCrypt(content, keyInput.Text);
                    File.WriteAllBytes(fileName,content);
                    MessageBox.Show("Готово!");
                    progressBar1.Value = 0;
                }
            }
        }

        private void byteRepackButton_Click(object sender, EventArgs e)
        {
            string fileName;
            byte[] content;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if ((fileName = openFileDialog.FileName) != null)
                {
                    content = File.ReadAllBytes(fileName);
                    content = repackCrypt(content, keyInput.Text);
                    File.WriteAllBytes(fileName, content);
                    MessageBox.Show("Готово!");
                    progressBar1.Value = 0;
                }
            }
        }
    }
}
