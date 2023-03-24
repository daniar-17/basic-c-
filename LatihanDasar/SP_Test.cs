using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanDasar
{
    class SP_Test
    {
        
        public static void Main(string[] args)
        {
            var context = new Artis();
        }

        public class Artis
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
        }
    }
}
