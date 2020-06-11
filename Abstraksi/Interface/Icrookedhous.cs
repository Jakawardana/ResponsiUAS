using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraksi.Interface
{
    public class crookedhouse : Novel
    {
        public override void judul()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Crooked House");
            Console.WriteLine("Penulis  : Agatha Christie");
            Console.WriteLine("Penerbit : Gramedia Pustaka Utama");
        }
    }
}