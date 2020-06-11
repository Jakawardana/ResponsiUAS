using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraksi.Interface
{
    public class penance : INovel
    {
        public override void judul()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Penance");
            Console.WriteLine("Penulis  : Minato Kanae");
            Console.WriteLine("Penerbit : Haru");
        }
    }
}