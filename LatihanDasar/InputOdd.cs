using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LatihanDasar
{
    class InputOdd
    {
        public static void Main(string[] args)
        {
            string folder = @"C:\DANIAR\LATE01\DANIAR N\JobSeeker\C# Latihan\Latihan Dasar\LatihanDasar\";
            string fileName = "OddText.txt";
            string fullPath = folder + fileName;
            int[] arrNilai = new int[10];

            File.WriteAllText(fullPath, string.Empty);
            File.AppendAllText(fullPath, "Odd Number : ");
            Console.WriteLine("Input Numbers : ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Input - {0} : ", i);
                arrNilai[i] = Convert.ToInt32(Console.ReadLine());
            }

            //int[] nilai = { 10, 13, 21, 40, 35, 22 };
            for (int i = 0; i < arrNilai.Length; i++)
            {
                if (arrNilai[i] % 2 != 0)
                {
                    Console.Write(arrNilai[i] + ", ");
                    string sNilai = arrNilai[i].ToString();
                    File.AppendAllText(fullPath, $"{sNilai}, ");
                }
            }

            Console.ReadLine();
        }

        public void LateAkhir()
        {
            string folder = @"C:\DANIAR\LATE01\DANIAR N\JobSeeker\C# Latihan\Latihan Dasar\LatihanDasar\";
            string fileName = "OddText.txt";
            string fileName2 = "OddText2.txt";
            string fullPath = folder + fileName;
            string fullPath2 = folder + fileName2;
            string[] authors = { "Mahesh Chand", "Allen O'Neill", "David McCarter", "Raj Kumar", "Dhananjay Kumar" };
            int[] nilai = { 10, 13, 21, 40, 35, 22 };
            string[] nilaiAll = { };
            for (int i = 0; i < nilai.Length; i++)
            {
                if (nilai[i] % 2 != 0)
                {
                    Console.Write(nilai[i] + ", ");
                    string sNilai = nilai[i].ToString();
                    nilaiAll = nilaiAll.Append(sNilai).ToArray();
                    File.AppendAllText(fullPath2, sNilai);
                }
            }
            File.WriteAllLines(fullPath, nilaiAll);

            Console.ReadLine();
        }

        public static int ReadInputInt()
        {
            bool sudahValid = false;
            int hasil = 0;

            while (!sudahValid)
            {
                string str = Console.ReadLine();

                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Silahkan Isi Nilai");
                    sudahValid = false;
                }
                else
                {
                    try
                    {
                        hasil = int.Parse(str);
                        sudahValid = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Input Harus Angka");
                        sudahValid = false;
                    }
                }
            }

            return hasil;
        }
    }
}
