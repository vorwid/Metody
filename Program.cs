using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{

    static void Main(string[] args)
    {
        int a = 10;
        //Console.WriteLine(Math.Abs(5));

        Math.IncreaseBy5(ref a);

        Console.WriteLine(a);

        int b;

        Math.Zeruj(out b);
        Console.WriteLine(Math.Dodaj(1, 2, 1, 2, 1, 2, 5, 6, 7, 8));
        Console.WriteLine(Math.Poteguj(6));

        Obywatel obywatel = new Obywatel(imie: "Łukasz", nazwisko: "Koscielniak");

        Console.WriteLine(obywatel.Imie);

        Console.ReadLine();
    }
}

class Math
{

    public static int Abs(int x)
    {

        if (x < 0)
            return x * (-1);

        return x;
    }

    public static int IncreaseBy5(int nr)
    {
        nr += 5;
        return nr;
    }
    public static int IncreaseBy5(ref int nr)
    {
        nr += 5;
        return nr;
    }
    public static void Zeruj(out int b)
    {
        b = 0;
    }
    public static int Dodaj(params int[] args)
    {
        int suma = 0;

        for (int i = 0; i < args.Length; i++)
        {
            suma += args[i];
        }

        return suma;
    }
    public static int Poteguj(int podstawa_potegi, int wykladnik = 2)
    {
        // 2 ^ 3 = 2 * 2 * 2 = 8
        int tmp = 1;

        for (int i = 0; i < wykladnik; i++)
        {
            tmp *= podstawa_potegi;
        }

        return tmp;
    }
}

class Obywatel
{
    public string Imie { get; private set; }
    public string Nazwisko { get; set; }

    public Obywatel(string imie, string nazwisko)
    {
        this.Imie = imie;
        this.Nazwisko = nazwisko;
    }
}