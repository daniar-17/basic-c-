using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LatihanDasar
{
    class ReadTextFile
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Read Text File");
            string folder = @"C:\DANIAR\LATE01\DANIAR N\JobSeeker\C# Latihan\Latihan Dasar\LatihanDasar\";
            string fileName = "Day.txt";
            string fullPath = folder + fileName;
            string[] lines = File.ReadAllLines(fullPath);
            for(int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"Kata : {i} - {lines[i]}");
                string[] kata = lines[i].Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.ReadLine();
        }
    }
}
