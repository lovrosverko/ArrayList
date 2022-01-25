using System;
using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            int broj = 5;
            string nesto = "C# i .NET";

            for (int i = 0; i<=100; i++) {
                lista.Add(i);
            }

            lista.Add(broj);
            lista.Add(nesto);
            Console.WriteLine("Broj elemenata liste: " + lista.Count);

            Console.WriteLine("Ispis svih elemenata prije Insert-a");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("Element br." + i + " ");
                Console.WriteLine(lista[i]);
            }

            lista.Insert(1, "Programiranje");

            Console.WriteLine(
                Environment.NewLine +
                "Ispis svih elemenata nakon Insert-a");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("Element br." + i + " ");
                Console.WriteLine(lista[i]);
            }
            /*
            Console.WriteLine(
                Environment.NewLine +
                "Ispis elemenata po danom uvjetu");

            for (int i = 0; i < lista.Count; i++)
            {
              if (lista[i].ToString() == "Programiranje")
                {
                    Console.WriteLine(lista[i]);
                    Console.WriteLine("Broj: " + i 
                        + Environment.NewLine);
                }
                try
                {
                    if (Convert.ToInt32(lista[i]) == 5)
                    {
                        Console.WriteLine(lista[i]);
                        Console.WriteLine("Broj: " + i
                            + Environment.NewLine);

                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            */

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.Contains(5))
                {
                    lista.Remove(5);
                }
            }

            Console.WriteLine(
                Environment.NewLine +
                "Ispis svih elemenata nakon Remove-a");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("Element br." + i + " ");
                Console.WriteLine(lista[i]);
            }

            int pozicija = lista.IndexOf(97);
            Console.WriteLine("Pozicija broja 97 je: " + pozicija);

            if (pozicija >= 0)
            {
                lista.RemoveAt(97);
            }

            Console.WriteLine(
                Environment.NewLine +
                "Ispis svih elemenata nakon Remove-a");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("Element br." + i + " ");
                Console.WriteLine(lista[i]);
            }

            Console.ReadKey();

        }
    }
}
