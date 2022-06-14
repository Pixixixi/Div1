using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Div1
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader str = new StreamReader("tovar.txt");
            Dictionary<string, char> Tovar = new Dictionary<string, char>();
            while (!str.EndOfStream)
            {
                string a = str.ReadLine();
                char b = a[0];
                b = char.ToLower(b);
                Tovar.Add(a, b);
            }
            str.Close();
            Console.WriteLine("Введите букву слова которое хотите удалить");
            char s = char.Parse(Console.ReadLine());
            var z = Tovar.Where(x => x.Value == s).First().Key;
            Tovar.Remove(z.ToString());
            foreach (var item in Tovar)
            {
                if (item.Key == z)
                {
                    Tovar.Remove(z);
                }
            }
            StreamWriter sv = new StreamWriter("tovar1.txt");
            foreach (var item in Tovar)
            {
                sv.WriteLine(item);
            }
            sv.Close();
            Console.ReadLine();







        }
    }
}
