namespace Zadanie_2_Znajdź_najmniejszy_i_największy_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int max = 0;
            int min = 101;
            int rozmiar = 10;
            int[] array = new int[rozmiar];
            for(int i = 0; i < rozmiar; i++)
            {
                array[i]= generator.Next(0,101);
                if (array[i]>max)
                {
                    max = array[i];
                }
                if (array[i]<min)
                {
                    min = array[i];
                }
                Console.WriteLine((i+1)+".\t"+array[i]);
            
            }
            Console.WriteLine("Max to:\t" + max);
            Console.WriteLine("Min to:\t" + min);



        }
    }
}