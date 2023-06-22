using System.Runtime.CompilerServices;

namespace Zadanie_1_zawartość_tablicy_od_tyłu
{
   
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Random generator = new Random();
             
            int rozmiar = 10;
            int[] array1=new int[rozmiar];
            for(int i=rozmiar-1;i>=0;i--)
            {
                
                array1[i] = generator.Next();

            }

            for (int i = 0;i<10 ; i++)
            {
                
                Console.WriteLine(array1[i]);

            }
        }   
    }
}