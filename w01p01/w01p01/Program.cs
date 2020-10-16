using System;

namespace w01p01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            //String s = Console.ReadLine();
            //a = int.Parse(s);
           // a = int.Parse(Console.ReadLine());

            Console.WriteLine("Witaj Świecie");
            String s = "Ala ma kota";
            s=s.ToLower();
            Console.WriteLine(s);

            Console.WriteLine(s.Equals("Ala ma kota"));

            Console.WriteLine(String.Equals(s, "ala ma kota"));
        }
    }
}
