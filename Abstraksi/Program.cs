using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Abstraksi.AbstractClass;
using Abstraksi.Interface;
namespace Absrtaksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informasi Novel");
            
            //abstraksi
            Novel novel1;
            Novel novel2;
            Novel novel3;

            //interface
            INovel inovel1;
            INovel inovel2;
            iNovel iNovel3;

            Console.WriteLine("1. Novel a");
            novel1 = new penance(); //abstraksi
            novel1.judul();

            inovel1 = new Ipenance(); //interface
            inovel1.judul();

            Console.WriteLine("2. Novel b");
            novel2 = new gariswaktu(); //abstraksi
            novel2.judul();

            inovel2 = new Igariswaktu(); //interface
            inovel2.judul();

            Console.WriteLine("3. Novel c");
            novel3 = new crookedhouse(); //abstraksi
            novel3.judul();

            inovel3 = new Icrookedhouse(); //interface
            inovel3.judul();

        }
    }
}