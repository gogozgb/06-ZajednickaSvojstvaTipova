using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // metoda ToString
            Console.WriteLine(mk1.ToString());
            Console.WriteLine(mk2.ToString());
            Console.WriteLine(mk3.ToString());


            // metoda GetType
            Console.WriteLine(mk1.GetType());
            Console.WriteLine(mk2.GetType());
            Console.WriteLine(mk2.GetType());
            var t = mk1.GetType();

            // metoda GetHashCode
            Console.WriteLine(mk1.GetHashCode());
            Console.WriteLine(mk2.GetHashCode());
            Console.WriteLine(mk2.GetHashCode());

            // metoda Equals
            Console.WriteLine(mk1.Equals(mk1));
            Console.WriteLine(mk1.Equals(mk2));
            Console.WriteLine(mk1.Equals(mk3));

            // TODO: ispise pohraniti u datoteku SystemObjects.txt priloženu projektu te u njoj obrazložiti rezultate za svaku metodu!
   

            Console.ReadKey();
        }
    }
}
