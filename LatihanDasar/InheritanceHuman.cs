using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanDasar
{
    class InheritanceHuman : InheritanceMamalia
    {
        public void Human()
        {
            Console.WriteLine("Human constructor...");
        }

        public int PersegiPanjang(int panjang, int lebar)
        {
            int nilai = 0;
            nilai = panjang * lebar;
            return nilai;
        }
    }
}
