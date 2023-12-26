using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FileProject
{
    internal class Program
    {
        static void TextEditor(string path1, string path2)
        {
            string text = File.ReadAllText(path1);            
            for(int i = 1; i < text.Length; i++)
            {
                while (text[i-1]==' ' && text[i]==' ')
                {
                    string line = text.Remove(i, 1);
                    text = line;
                }
            }
            using(StreamWriter sw = new StreamWriter(path2))
            {
                sw.WriteLine(text);
            }
        }
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("testText.txt"))
            {
                sw.WriteLine("Бездна, в   которой работал   Аззи, называлась Северный Дискомфорт №405. " +
                    "Это была  одна из самых  старых  бездн; её ввели  в строй  во времена Вавилона,   " +
                    "когда люди ещё умели  грешить по настоящему.");
                sw.WriteLine("Роберт  Шекли, Роджер   Желязны");
                sw.Write("История рыжего  демона.");
            }
            TextEditor("testText.txt", "text.txt");
        }
    }
}
