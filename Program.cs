using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2915
{
    class Program
    {
        static void Main(string[] args)

        {
            Karyawan karyawan1 = new Karyawan(1, 2915, "Aril", 10000000);
            karyawan1.gaji();

            Karyawan karyawan2 = new Karyawan(2, 3301, "Nednod", 8000000);
            karyawan2.gaji();

            Karyawan karyawan3 = new Karyawan(1, 2915, "Aril", 10000000);
            karyawan3.gajinaik();

            Karyawan karyawan4 = new Karyawan(2, 3301, "Nednod", 8000000);
            karyawan4.gajinaik();

            Console.ReadKey(true)
        }
    }
}
