namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   Random generator = new Random();
            int rozmiar = 10;
            int temp;
            int[] tab = new int[rozmiar];
            for(int i = 0; i < tab.Length; i++) 
            {
                tab[i]=generator.Next(0,1000);
                Console.WriteLine((i+1)+".\t"+tab[i]);
            }
        for(int j = 1; j < tab.Length; j++)
            {
                for (int i = 1; i < tab.Length; i++)
                {
                    if (tab[i - 1] > tab[i])
                    {
                        temp = tab[i - 1];
                        tab[i - 1] = tab[i];
                        tab[i] = temp;
                    }
                }
            }
            Console.WriteLine("Posortowane");
            for (int i = 0; i < tab.Length; i++)
            {
                
                Console.WriteLine((i + 1) + ".\t" + tab[i]);
            }


        }
    }
}