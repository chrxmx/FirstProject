using System;

class Program
{
    static int Osszegzes(int[] tomb)
    {
        int osszeg = 0;

        for (int i = 0; i < tomb.Length; i++)
        {
            osszeg += tomb[i];
        }

        return osszeg;
    }

    static void ParosSzamok(int[] tomb)
    {
        for (int i = 0; i < tomb.Length; i++)
        {
            if (tomb[i] % 2 == 0)
            {
                Console.WriteLine(tomb[i]);
            }
        }
    }
    static void Abszolutszamok(int[] tomb)
    {
        for (int i = 0; i < tomb.Length; i++)
        {
            Console.WriteLine(Math.Abs(tomb[i]));
        }
    }
    static void NegativSzamok(int[] tomb)
    {
        int paratlanok = 0;
        for (int i = 0; i < tomb.Length; i++)
        {
            if (tomb[i] < 0)
            {
                paratlanok++;
            }
        }
        Console.WriteLine(paratlanok);
    }
    static void LegNagyobbSzam(int[] tomb)
    {
        int max = tomb[0];
        for (int i = 1; i < tomb.Length; i++)
        {
            if (tomb[i] > max)
            {
                max = tomb[i];
            }
        }
        Console.WriteLine(max);
    }
    static void HanyParosSzam(int[] tomb)
    {
        int parosok = 0;
        for (int i = 0; i < tomb.Length; i++)
        {
            if (tomb[i] % 2 == 0)
            {
                parosok++;
            }
        }
        Console.WriteLine(parosok);
    }
    static void Main()
    {
        int[] tomb = { -5, 10, 15, -20, 25 };

        ///Console.WriteLine(Osszegzes(tomb));
        ///ParosSzamok(tomb);
        ///Abszolutszamok(tomb);
        ///NegativSzamok(tomb);
        ///LegNagyobbSzam(tomb);
        ///HanyParosSzam(tomb);
    }
}