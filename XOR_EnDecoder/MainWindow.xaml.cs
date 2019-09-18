using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XOR_EnDecoder
{
    public partial class MainWindow : Window
    {
        public static string stringCrypt(string text, string key) //simple, but enough for bonus thingy
        {
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
        public static string intCrypt(string text, int Key) //функция XOR-шифрования/расшифровки текста по числовому ключу Key
        {
            string CryptedString = string.Empty; //Создается переменная типа string
            foreach (char c in text)
            {
                CryptedString += (char)((int)c ^ Key); //каждый символ в строке "шифруется"/"расшифровывается" с помощью ключа и функции XOR
            }
            return CryptedString; //возвращает "зашифрованную"/"расшифрованную" строку
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string t = new TextRange(inputRTB.Document.ContentStart, inputRTB.Document.ContentEnd).Text;
                outputRTB.Document.Blocks.Clear();
                outputRTB.AppendText(intCrypt(t, int.Parse(keyInput.Text)));
            } catch { }
        }
    }
}
