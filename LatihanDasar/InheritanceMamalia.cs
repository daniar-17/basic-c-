using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanDasar
{
    class InheritanceMamalia
    {
        public int Umur { get; set; }
        public String JenisKelamin { get; set; }
        public void Mamalia()
        {
            Console.WriteLine($"Mamalia constructor {Umur} : {JenisKelamin}");
        }

        public void CheckFirstWord(string[] arrName)
        {
            string data;
            for (int i = 0; i < arrName.Length; i++)
            {
                data = arrName[i][0].ToString();
                if (data == "a" || data == "A")
                {
                    Console.WriteLine($"{arrName[i]} huruf depanya A");
                }
                else
                {
                    Console.WriteLine($"{arrName[i]} huruf depanya TIDAK A");
                }
            }
        }
    }
}
