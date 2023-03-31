//Fibonacci

/* Given code :

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1, y = 1, z = 1;

            Console.Write("Masukan jumlah bilangan fibonacci = ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jumlah; i++)
            {
                Console.Write(z + " ");
                z = x + y;
                x = y;
                y = z;
            }
            Console.Read();

        }
    }
}

*/

/*
Berikut ini adalah penjelasan dan perbaikannya:

1. Variabel x, y, dan z awalnya harus diatur menjadi 0 karena deret Fibonacci dimulai dengan 0 dan 1.
2. Variabel z harus diatur ke nilai awal y, bukan 1, karena z adalah hasil penjumlahan dari x dan y.
3. Setelah perulangan for, Console.Read() tidak perlu ditambahkan karena itu hanya memblokir program dan tidak ada input dari pengguna yang diambil.
*/

using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 1, z;

            Console.Write("Masukkan jumlah bilangan Fibonacci = ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            Console.Write("Deret Fibonacci: ");

            for (int i = 0; i < jumlah; i++)
            {
                Console.Write(x + " ");

                z = x + y;
                x = y;
                y = z;
            }
        }
    }
}
