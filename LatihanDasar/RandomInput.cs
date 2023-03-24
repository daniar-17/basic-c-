using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanDasar
{
    class RandomInput
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input 2 Nilai Random Output");
            int startN, endN, tempRnd1, tempRnd2 = 0;
            Random rndNilai = new Random();
            Random rndNilai2 = new Random();
            Console.Write("Input Start Number : "); 
            startN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input End Number : ");
            endN = Convert.ToInt32(Console.ReadLine());
            tempRnd1 = rndNilai.Next(startN, endN);
            tempRnd2 = rndNilai2.Next(startN, endN);
            Console.WriteLine($"Random Number 1 : {tempRnd1}");
            Console.WriteLine($"Random Number 2 : {tempRnd2}");
            string hasil = (tempRnd1 == tempRnd2) ? "Tie" : "Not Tie";
            Console.WriteLine(hasil);
        }
    }
}
