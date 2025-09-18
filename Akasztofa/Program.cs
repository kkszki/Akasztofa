using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Akasztofa
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] szavak = { "elso", "alma", "vízibicikli", "kukac" };
            Random rnd = new Random();
            
            bool talalt = false;
            string szo = szavak[rnd.Next(szavak.Length)];
            Console.WriteLine(szo);
            Console.ReadLine(); 

            do
            {
                Console.WriteLine("Adjon meg egy betűt!: ");
                string betu = Console.ReadLine();

                
            }while (! talalt);

        }
    }
}
