class Program
{
    static void Main(string[] args)
    {
        Wypelnienie();
    }
    static void Wypelnienie()
    {
        bool[] tab = new bool[100];
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = true;
        }
        Pierwsze(tab);
    }
    static void Pierwsze(bool[] tab)
    {
        for (int i = 2; i < Math.Sqrt(100); i ++)
        {
            if (tab[i] == true)
            {
                for (int j = i * i; j < 100; j += i )
                {
                    tab[j] = false;
                }
            }
        }
        Wyswietlanie(tab);
    }
    static void Wyswietlanie(bool[] tab)
    {
        for ( int i = 2; i < tab.Length; i++)
        {
            if (tab[i] == true)
            {
                Console.Write(i + ",");
            }
            else
            {

            }
        }
    }
}