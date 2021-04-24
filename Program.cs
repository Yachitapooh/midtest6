using System;

namespace testmid
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            int wide = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int round = 1;
            while (round <= number) 
            {
                for(int i = 1; i <= high; i++) 
                {
                    for (int j = 1; j <= round * wide; j++) 
                    {
                        Console.Write(input);
                    }
                    Console.WriteLine();
                }
                round++;
                
            }        
            Console.ReadLine();

        }
    }
}
