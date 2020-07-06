using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();
        
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
                while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih menu aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection
            Produk produk = new Produk();
            Console.WriteLine("Tambah data produk");
            Console.Write("\nKode produk :");
            produk.Kode = Console.ReadLine();
            
            Console.WriteLine("Nama produk : ");
            produk.Nama = Console.ReadLine();
            
            Console.WriteLine("Harga beli  :");
            produk.Beli = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Harga jual  :");
            produk.Jual = Convert.ToDouble(Console.ReadLine());
            daftarProduk.Add(produk);

            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection
            int n = -1, hapus = -1;
            Console.WriteLine("Hapus data produk");
            Console.Write("Kode produk : ");
            string kode = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                n++;
                if (produk.Kode == kode)
                {
                    hapus = n;
                }
            }

            if (hapus != -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("Data produk berhasil dihapus");
            }

            else
            {
                Console.WriteLine("Kode produk tidak ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection
            int urutkan = 0;
            Console.WriteLine("Data produk");
            foreach (Produk produk in daftarProduk)
            {
                urutkan++;
                Console.WriteLine("{0}. Kode produk {1}, Nama produk : {2}, Harga beli : {3}, Harga jual : {4}", urutkan, produk.Kode, produk.Nama, produk.Beli, produk.Jual);
            }

            if (urutkan < 1)
            {
                Console.WriteLine("Data produk kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
