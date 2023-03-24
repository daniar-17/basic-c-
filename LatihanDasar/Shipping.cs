using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanDasar
{
    class Shipping
    {
        public static void Main(string[] args)
        {
            //int N = 4;
            //int[] h = new int[] { 1, 4, 2, 4 };
            //int[] fromCity = new int[] { 1, 1, 3, 3 };
            //int[] nAkhir = new int[N];
            //List<int> nListA = new List<int>();
            //int itemPrice = 0;
            //int itemCost = 0;
            //int checkArr = 0;
            //for (int i = 0; i < N; i++)
            //{

            //    itemPrice = h[fromCity[i] - 1];
            //    if((i+1) >= fromCity[i])
            //    {
            //        itemCost = (i + 1) - fromCity[i];
            //    }
            //    else
            //    {
            //        itemCost = fromCity[i] - (i + 1);
            //    }
            //    nAkhir[i] = itemPrice + itemCost;
            //    Console.WriteLine($"In City {i+1}, buy an item from city : {fromCity[i]} with item price {itemPrice} and shipping cost {itemCost}");
            //}
            //Console.WriteLine();
            //Console.Write($"Output : ");
            //for (int z = 0; z < nAkhir.Length; z++)
            //{
            //    Console.Write(nAkhir[z] + ", ");
            //}
            //nListA.AddRange(nAkhir);
            //Console.WriteLine();
            //foreach (int a in nListA)
            //{
            //    Console.Write(a + "-");
            //}
            //Console.ReadLine();

            int[] h = new int[] { 1, 4, 2, 4 };
            List<int> nListA = new List<int>(h);
            shipping(5, nListA);
        }
        public static List<int> shipping(int N, List<int> h)
        {
            // Your code starts here.
            int[] lengthN = h.ToArray();
            Console.WriteLine(String.Join(", ", lengthN));
            List<int> nListA = new List<int>();
            int[] fromCity = new int[] { 1, 1, 3, 3 };
            Random rnd = new Random();
            int fromCity2 = 0;
            int[] nAkhir = new int[N];
            int itemPrice = 0;
            int itemCost = 0;
            int checkArr = 0;
            for (int i = 0; i < N; i++)
            {
                fromCity2 = Convert.ToInt32(Console.ReadLine());
                itemPrice = fromCity2 - 1;
                if ((i + 1) >= fromCity2)
                {
                    itemCost = (i + 1) - fromCity2;
                }
                else
                {
                    itemCost = fromCity2 - (i + 1);
                }
                nAkhir[i] = itemPrice + itemCost;
                Console.WriteLine($"In City {i + 1}, buy an item from city : {fromCity2} with item price {itemPrice} and shipping cost {itemCost}");
            }
            nListA.AddRange(nAkhir);
            return nListA;
        }
    }
}
