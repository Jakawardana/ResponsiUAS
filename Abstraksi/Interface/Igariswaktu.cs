using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraksi.Interface
{
    public class gariswaktu : INovel
    {
        public override void judul()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Garis Waktu");
            Console.WriteLine("Penulis  : Fiersa Besari");
            Console.WriteLine("Penerbit : Mediakita");
        }
    }
}