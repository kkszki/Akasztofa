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

            

            string[] akasztofa = new string[]
          {
            "        ------------------                 ",
            "         || //       ",
            "         ||//        ",
            "         ||/         ",
            "         ||          ",
            "         ||          ",
            "         ||          ",
            "         ||          ",
            "         ||          ",
            "         ||          ",
            "-------------------------------------------",
          };

            string[] ember = new string[]
            {
                "         ",
                "    |    ",
                "    O    ",
                "   /|\\   ",
                "    |    ",
                "   /|\\   "
              
               

            };







            string[] szavak = { "elso", "alma", "vízibicikli", "kukac" };
            Random rnd = new Random();
            
            bool kitalalva = false;
            string szo = szavak[rnd.Next(szavak.Length)];
            Console.WriteLine(szo);
            int akasztofa_elet = 11;
            int ember_elet = 5;
           
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

                if (nem_jok.Contains(betu))
                {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("ez már volt!");
                    Console.WriteLine("Enterrel tovább");
                    Console.ReadLine();
                    continue;
                }
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
                    
                    if (akasztofa_elet > 0)
                    {
                        akasztofa_elet--;
                    }
                    else
                    {
                        ember_elet--;
                    }
                    Console.Clear();
                    betu += ", ";
                    nem_jok += betu;

                  
                       
                    }

                for (int i = 1; i < (5 - ember_elet + 1); i++)
                {
                    akasztofa[i] += ember[i];
                }
                Console.WriteLine("\n\n\n");
                    for (int i = akasztofa_elet; i <= 10; i++)
                    {
                        Console.WriteLine(akasztofa[i]);
                    }
                    if (akasztofa_elet == 0)
                    {
                        for (int i = 1; i <= (5 - ember_elet); i++)
                        {
                            akasztofa[i] = akasztofa[i].Substring(0, akasztofa[i].Length - 9);

                        }
                    



                }
                Console.WriteLine($"Kitalálni: {eddig_talalt_betuk}");
                Console.WriteLine($"Élet: {akasztofa_elet+ember_elet} ");
                Console.WriteLine($"Nem jó betűk: {nem_jok}");
                Console.Beep();



            } while ((akasztofa_elet+ember_elet)!=0 && !kitalalva);
            Console.WriteLine(kitalalva ? "Nyertél" : "Vesztettél");
            Console.Beep();
            Console.Beep();
            Console.Beep();

            Console.WriteLine("Enterre tovább..");
            Console.ReadLine(); 
        }
    }
}
