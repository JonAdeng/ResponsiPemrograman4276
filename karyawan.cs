using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman21._11._4276
{
    class karyawan
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }

        //method
        public void NikNama()
        {
            Console.WriteLine("{0} {1}          {2}", Nama,NIK,GajiBulanan);
        }

        public void NaikGaji()
        {
            Console.WriteLine("Selamat gaji anda naik 10%");

            int kenaikan;

            kenaikan = GajiBulanan * 110;
            GajiBulanan = kenaikan / 100;
        }
    }
}
