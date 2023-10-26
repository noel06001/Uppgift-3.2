using System;

namespace Upgift_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara antingen \"j\" för ja eller \"n\" för nej");
            string x = Console.ReadLine().ToLower();
           
            Console.WriteLine("Hur gammal är du?");
            int y = int.Parse(Console.ReadLine());

            if (x=="j" && y<22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
            Console.ReadKey();
        }
    }
}
