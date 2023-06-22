namespace Zadanie_4_sortowanie_przez_wstawianie
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
            for (int i = 1; i < tab.Length; i++)
            {
                int klucz = tab[i];
                int j = i - 1;
                while (j >= 0 && tab[j] > klucz)
                {
                    tab[j+1] = tab[j];
                    j--;
                }
                tab[j + 1] = klucz;
            }
            for (int i = 0; i < tab.Length; i++)
            {
                
                Console.WriteLine((i + 1) + ".\t" + tab[i]);
            }
        }


    }

  
}
