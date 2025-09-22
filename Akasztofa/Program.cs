using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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







            string[] szavak = { "Elso", "Alma", "Vízibicikli", "Kukac" };
            Random rnd = new Random();
            
            bool kitalalva = false;
            string szo = szavak[rnd.Next(szavak.Length)];
            
            int akasztofa_elet = 11;
            int ember_elet = 5;
           
            int szohossz = szo.Length;
            string also = new string('_', szohossz);

            string eddig_talalt_betuk = "";
            eddig_talalt_betuk += also;
            string uj = "";
            string nem_jok = "";
           
            bool kis_nagy_kulonbseg=false;
            char letter = ' ';


            try
            {
                Console.WriteLine("Kérem adja meg, hogy nézzük-e a kis és nagy betűket szigorúan (i/n)");
                string kn = Console.ReadLine();
                if (kn == "i")
                {
                    kis_nagy_kulonbseg = true;
                }
                Console.Clear();
            }
            catch (Exception e){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hiba történt!");
                Console.WriteLine("Valószínű nem egy karakter-t kaptam");
                Console.WriteLine("Kér hibaüzenetet: (i/n)");
                Console.ForegroundColor = ConsoleColor.White;
                string i_n = Console.ReadLine();
                if (i_n == "i")
                {
                    Console.WriteLine(e);
                }
            }
            do
            {
                try
                {   
                   
                    Console.WriteLine("Adjon meg egy betűt!: ");
                    string betu = Console.ReadLine();
                    letter = Convert.ToChar(betu);
                    if (!kis_nagy_kulonbseg)
                    {
                        szo = szo.ToLower();
                        letter = char.ToLower(letter);
                    }

                    
                



                bool szoban_van = szo.Contains(letter);
                    bool rontottban_van = nem_jok.Contains(letter);
                if (nem_jok.Contains(letter))
                {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("ez már volt!");
                    Console.WriteLine("Enterrel tovább");
                    Console.ReadLine();
                      
                    
                }

                if (eddig_talalt_betuk.Contains(letter))
                {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("Ez már egyszer el lett találva, de szééép volt! :-)");
                    Console.WriteLine("Enterrel tovább");
                    Console.ReadLine();
                   Console.Clear();
               
                }






                if (szoban_van || rontottban_van){
                Console.Clear();
                    
                for (int i = 0; i < szohossz; i++)
                {
                    if (szo[i] == letter)
                    {
                        uj += letter;
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
                    
                    nem_jok += letter;

                  
                       
                    }

                for (int i = 1; i < (5 - ember_elet + 1); i++)
                {
                    akasztofa[i] += ember[i];
                }
                Console.WriteLine("\n\n\n");
                Console.ForegroundColor = ConsoleColor.Red;

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
                if (szoban_van)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                    Console.WriteLine(szoban_van ? "Talált" : "Nem talált");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Kitalálni: {eddig_talalt_betuk}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Élet: {akasztofa_elet+ember_elet} ");
                Console.ForegroundColor = ConsoleColor.Red;
                    if (nem_jok.Length > 0)
                    {
                        Console.Write(nem_jok[0]);
                        for (int i = 1; i < nem_jok.Length; i++)
                        {
                           
                                Console.Write($", {nem_jok[i]}");
                            
                            
                            


                        }

                    }
                    Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.Beep();



                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hiba történt!");
                    Console.WriteLine("Valószínű nem egy karakter-t kaptam");
                    Console.WriteLine("Kér hibaüzenetet: (i/n)");
                    Console.ForegroundColor= ConsoleColor.White;
                    string i_n = Console.ReadLine();
                    if (i_n == "i")
                    {
                        Console.WriteLine(e);
                    }
                  

                  
                }
            } while ((akasztofa_elet+ember_elet)!=0 && !kitalalva);
            if (kitalalva)
            {
               
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
        
                Console.ForegroundColor = ConsoleColor.Red;
            }

                Console.WriteLine(kitalalva ? "Nyertél" : "Vesztettél");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Enterre tovább..");
            Console.ReadLine(); 
        }
    }
}
