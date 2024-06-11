using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("taille de petits tableau : ");
        int taille = int.Parse(Console.ReadLine());
        int[] tab = new int[taille];
        int[] tab2 = new int[taille];
        for (int i = 0; i < taille; i++)
        {
            tab[i] = i;
            tab2[i] = 2 * i;
        }
        int[] tab3 = tab.Concat(tab2).ToArray();
        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine("premier tableau : " + tab[i]);
        }
        for (int i = 0; i < tab2.Length; i++)
        {
            Console.WriteLine("deuxieme tableau : " + tab2[i]);
        }
        for (int i = 0; i < tab3.Length; i++)
        {
            Console.WriteLine("troisieme tableau : " + tab3[i]);
        }

    }
}