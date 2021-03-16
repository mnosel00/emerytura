using System;
using System.Numerics;

namespace ConsoleAppInterakcja
{
    
    class Program
    {
        
        static void Main(string[] args)
        {


            long suma = 0;
            long sumak = 0;
            while (true)
            {
                string napis = Console.ReadLine();
                string[] tab = napis.Split(' ');

                if (string.IsNullOrEmpty(napis))
                {
                    Console.WriteLine(sumak);
                    break;
                }
                else
                {
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
