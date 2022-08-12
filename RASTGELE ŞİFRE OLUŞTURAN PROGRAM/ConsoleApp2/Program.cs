using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int ascii = rastgele.Next(65, 127);
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter);

            }
            Console.WriteLine(sb.ToString());
            Console.Read();
        }
        
    }
}
