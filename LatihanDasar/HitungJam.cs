using System;

namespace LatihanDasar
{
    class HitungJam
    {
        public static void Main(string[] args)
        {
            double jam, menit, detik, awalJam, awalMenit, awalDetik, akhirJam, akhirMenit, akhirDetik = 0;
            double awalAll, akhirAll, allNilai = 0;
            Console.WriteLine("Masukan Waktu Awal : ");
            Console.Write("Jam : "); awalJam = int.Parse(Console.ReadLine());
            Console.Write("Menit : "); awalMenit = int.Parse(Console.ReadLine());
            Console.Write("Detik : "); awalDetik = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Masukan Waktu Akhir : ");
            Console.Write("Jam : "); akhirJam = int.Parse(Console.ReadLine());
            Console.Write("Menit : "); akhirMenit = int.Parse(Console.ReadLine());
            Console.Write("Detik : "); akhirDetik = int.Parse(Console.ReadLine());
            Console.WriteLine();
            awalAll = awalDetik + (awalMenit * 60) + (awalJam * (60 * 60));
            akhirAll = akhirDetik + (akhirMenit * 60) + (akhirJam * (60 * 60));
            allNilai = akhirAll - awalAll;
            jam = Math.Floor(allNilai / 3600);
            menit = Math.Floor((allNilai / 60) % 60);
            detik = Math.Floor(allNilai % 60);
            Console.WriteLine("Durasi Waktu : ");
            Console.WriteLine($"Jam : {jam}");
            Console.WriteLine($"Menit : {menit}");
            Console.WriteLine($"Detik : {detik}");

            Console.ReadLine();
        }
    }
}
