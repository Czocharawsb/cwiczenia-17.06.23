namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int rozmiar = 10;
            int[] tab = new int[rozmiar];
           
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = generator.Next(0, 1000);
                Console.WriteLine((i + 1) + ".\t" + tab[i]);
            }
            for (int i = 0; i < rozmiar - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < rozmiar; j++)
                {
                    if (tab[j] < tab[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = tab[minIndex];
                tab[minIndex] = tab[i];
                tab[i] = temp;
            }

            for (int i = 0; i < tab.Length; i++)
            {
                
                Console.WriteLine((i + 1) + ".\t" + tab[i]);
            }
        }  
    }
}