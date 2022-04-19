using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman21._11._4276
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan kry = new karyawan();
            karyawan kry2 = new karyawan();

            kry.Nama = "Jonathan Ade";
            kry.NIK = "33234852";
            kry.GajiBulanan = 3000000;

            kry2.Nama = "Adi Kusworo";
            kry2.NIK = "33235654";
            kry2.GajiBulanan = 2800000;

            Console.WriteLine("No. Nama/NIK          Gaji Bulanan");
            Console.WriteLine("==============================");
            Console.WriteLine("1. "); kry.NikNama();
            Console.WriteLine("2. "); kry2.NikNama();
            Console.WriteLine();

            kry.NaikGaji();
            kry2.NaikGaji();
            Console.WriteLine();


            Console.WriteLine("No. Nama/NIK          Gaji Bulanan");
            Console.WriteLine("==============================");
            Console.WriteLine("1. "); kry.NikNama();
            Console.WriteLine("2. "); kry2.NikNama();
            Console.WriteLine();

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
