using System;

namespace LatihanDasar
{
    class Program
    {
        static void Main(string[] args)
        {
            float alas, tinggi, hasil = 0;
            string[] kata;
            kata = new string[] {"angsa","gajah","ayam","burung"};

            //Call InheritanceHuman
            InheritanceHuman steven = new InheritanceHuman();
            steven.Umur = 17;
            steven.JenisKelamin = "Pria";
            steven.Human();
            steven.Mamalia();

            steven.CheckFirstWord(kata);
            int nilaiPersegiPanjang = steven.PersegiPanjang(2, 10);
            Console.WriteLine($"Persegi Panjang : {nilaiPersegiPanjang}");
            Console.WriteLine("----------------------------------------");

            //Test Hello World
            Console.WriteLine("Hello World! Daniar Nur Amin");
            Console.WriteLine("----------------------------------------");

            //Search Luas Segitiga
            Console.Write("Input Alas : ");
            alas = Single.Parse(Console.ReadLine());
            Console.Write("Input Tinggi : ");
            tinggi = Single.Parse(Console.ReadLine());
            hasil = LuasSegitiga(alas, tinggi);
            Console.WriteLine("Hasil Luas Segitiga : " + hasil);
            Console.WriteLine("----------------------------------------");

            //Search Bilangan Prima
            Console.WriteLine("Bilangan Prima");
            for (int i = 0; i<= 100; i++)
            {
                int a = 0;
                for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        a++;
                    }
                }
                if(a == 2)
                {
                    Console.Write(i + ", ");
                }
            }
            
            Console.ReadLine();
        }

        public static float LuasSegitiga(float alas, float tinggi)
        {
            float luas = (float)0.5 * alas * tinggi;
            return luas;
        }
    }
}
