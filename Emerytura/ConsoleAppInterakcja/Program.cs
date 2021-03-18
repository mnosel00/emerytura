using System;
using System.Numerics;

namespace ConsoleAppInterakcja
{
    
    class Program
    {
        
        static void Main()
        {


            long suma = 0;
            long sumak = 0;
            while (true)
            {
                string napis = Console.ReadLine();
                

                if (string.IsNullOrEmpty(napis))
                {
                    Console.WriteLine(sumak);
                    break;
                }
                else
                {
                    string[] tab = napis.Split(' ');
                    for (int i = 0; i < tab.Length; i++)
                    {
                        suma += int.Parse(tab[i]);
                        sumak += int.Parse(tab[i]);
                     
                    }
                    Console.WriteLine(suma);
                    
                    suma = 0;
                    
                }
               
                
            }
          

        }
    }
}
