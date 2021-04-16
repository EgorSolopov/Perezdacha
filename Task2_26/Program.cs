using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8
{
   public class VigenereCipher
    {
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // задаётся стандартный алфавит для конструктора
        readonly string letters;

        // конструктор (можно ввести свой алфавит или оставить прежний, если конструктор пустой
        public VigenereCipher(string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
        }

        // для генерации повторяющегося пароля
        private string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }
            return p.Substring(0, n);
        }

        // сам шифр Виженера
        private string Vigenere(string text, string password, bool encrypting = true)
        {
            var gamma = GetRepeatKey(password, text.Length);
            var retValue = "";
            var q = letters.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = letters.IndexOf(text[i]);
                var codeIndex = letters.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    // не найденная буква добавляется в том виде, в котором написана
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += letters[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }
            return retValue;
        }

        public string Encrypt(string plainMessage, string password)
            => Vigenere(plainMessage, password);

        public string Decrypt(string encryptedMessage, string password)
            => Vigenere(encryptedMessage, password, false);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

            // 1.txt и 2.txt находятся в C:\Users\keklik\source\repos\Task2_26\Task2_26\bin\Debug (чтобы они не зависели от директории распаковки таска)
            // 1.txt - Вводный текст для КОДИРОВКИ и выходной текст ПОСЛЕ РАСКОДИРОВКИ
            // 2.txt - Выходной текст ПОСЛЕ КОДИРОВКИ и вводный текст для РАСКОДИРОВКИ
            // крайне топорный цикл для бесконечного использования программы
            while (true)
            {
                Console.WriteLine("Напишите \"кодировка\" или \"раскодировка\". Для выхода из кодировщика: \"выход\".");
                string toDecide = Convert.ToString(Console.ReadLine());

                if (toDecide == "кодировка" || toDecide == "Кодировка")
                {
                    Console.WriteLine("Введите пароль:");
                    string password = Convert.ToString(Console.ReadLine());
                    string inputText = File.ReadAllText("1.txt", Encoding.UTF8).ToUpper();
                    File.WriteAllText("2.txt", cipher.Encrypt(inputText, password));
                    Console.WriteLine("Закодированный текст: " + File.ReadAllText("2.txt", Encoding.UTF8).ToUpper());
                }
                else if (toDecide == "раскодировка" || toDecide == "Раскодировка")
                {
                    Console.WriteLine("Введите пароль:");
                    string password = Convert.ToString(Console.ReadLine());
                    string inputText = File.ReadAllText("2.txt", Encoding.UTF8).ToUpper();
                    File.WriteAllText("1.txt", cipher.Decrypt(inputText, password));
                    Console.WriteLine("Раскодированный текст: " + File.ReadAllText("1.txt", Encoding.UTF8).ToUpper());
                }
                else if (toDecide == "выход" || toDecide == "Выход")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}