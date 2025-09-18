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

            string[] rajz = new string[]
          {
    "------------------",
    "    ||",
    "    ||",
    "    ||",
    "    ||        / \\",
    "    ||         |",
    "    ||        \\|/",
    "    ||/        O",
    "    || /       |",
    "---------------------"
          };
            //foreach (var sor in rajz)
            //{
            //    Console.WriteLine(sor);
            //}







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
            string nem_jok = "";

            do
            {
                
                Console.WriteLine("Adjon meg egy betűt!: ");
                string betu = Console.ReadLine();
                if (szo.Contains(betu)){
                    Console.Clear();

                    for (int i = 0; i < szohossz; i++)
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
                    if (szo == uj)
                    {
                        kitalalva=true;
                    }
                    
                    eddig_talalt_betuk = uj;
                    uj = "";
                }
                else
                {
                    elet--;
                    Console.Clear();
                    betu += ", ";
                    nem_jok += betu;



                }
                Console.WriteLine($"Kitalálni: {eddig_talalt_betuk}");
                Console.WriteLine($"Élet: {elet} ");
                Console.WriteLine($"Nem jó betűk: {nem_jok}");
                for(int i = 9; i >= elet; i--)
                {
                    Console.WriteLine(rajz[i]);
                }

            } while (elet!=0 && !kitalalva);
            Console.WriteLine(kitalalva ? "Nyertél" : "Vesztettél");

            Console.WriteLine("Enterre tovább..");
            Console.ReadLine(); 
        }
    }
}
