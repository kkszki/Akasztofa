using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            
            bool kitalalva = false;
            string szo = szavak[rnd.Next(szavak.Length)];
            Console.WriteLine(szo);
            int elet = 10;
           
            int szohossz = szo.Length;
            string also = new string('_', szohossz);

            string eddig_talalt_betuk = "";
            eddig_talalt_betuk += also;
            string uj = "";



            do
            {
                
                Console.WriteLine("Adjon meg egy betűt!: ");
                string betu = Console.ReadLine();
              
                for (int i=0; i < szohossz; i++)
                {
                    if (szo[i] == betu[0])
                    {
                        uj += betu[0];
                    }
                    else
                    {
                        uj += eddig_talalt_betuk[i];
                    }

                }

                Console.WriteLine(uj);
                eddig_talalt_betuk = uj;
                uj = "";
               

                
            }while (! kitalalva);

        }
    }
}
