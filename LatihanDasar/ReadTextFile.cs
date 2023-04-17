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
            try
            {
                Console.WriteLine("Read Text File");
                string folder = @"C:\DANIAR\LATE01\DANIAR N\JobSeeker\C# Latihan\Latihan Dasar\LatihanDasar\";
                string fileName = "startPrice.txt";
                string fileName2 = "finalPrice.txt";
                string fullPath = folder + fileName;
                string fullPath2 = folder + fileName2;
                string[] lines = File.ReadAllLines(fullPath);
                List<string> list = new List<string>();
                string[] final;
                int tempInt = 0;
                string tempString = "";
                for (int i = 0; i < lines.Length; i++)
                {
                    //Console.WriteLine($"Kata : {i} - {lines[i]}");
                    string[] kata = lines[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    tempInt = int.Parse(kata[1]) * int.Parse(kata[2]);
                    if (kata[3] == "EUR")
                    {
                        tempInt = tempInt * 19000;
                    }
                    else if (kata[3] == "USD")
                    {
                        tempInt = tempInt * 14000;
                    }
                    tempString = $"{kata[0]}, {kata[1]}, {kata[2]}, {kata[3]}, {tempInt}";
                    list.Add(tempString);
                    tempString = "";
                    tempInt = 0;
                }
                final = list.ToArray();
                File.WriteAllLines(fullPath2, final);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        //Last Line
        }
    }
}
