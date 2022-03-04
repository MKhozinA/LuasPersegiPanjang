using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasPersegiPanjang
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class LuasPersegiPanjang dapat membuat operasi menghitung luas persegi panjang</remarks>
    class LuasPersegiPanjang1
    {
        /// <summary>
        /// Panjang Persegi Panjang
        /// </summary>
        /// <param name="panjang">panjang persegi panjang</param>
        public double panjang;
        /// <summary>
        /// Lebar Persegi Panjang
        /// </summary>
        /// <param name="lebar">lebar persegi panjang</param>
        public double lebar;
    
        /// <summary>
        /// Memasukkan data panjang dan lebar persegi panjang
        /// </summary>
        public void MasukkanData()
        {
            Console.Write("Masukkan panjang: ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar: ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Menghitung Luas Persegi Panjang
        /// </summary>
        /// <returns>hasil dari penghitungan luas persegi panjang</returns>
        public double Hitungluas()
        {
            double hasil;
            hasil = panjang * lebar;
            return hasil;
        }

        /// <summary>
        /// hasil dari penghitungan luas persegi panjang
        /// </summary>
        public void Hasil()
        {
            Console.Write("Luas persegi panjang = {0}", Hitungluas());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();

            LuasPersegiPanjang1 lp1 = new LuasPersegiPanjang1();
            lp1.MasukkanData();
            lp1.Hasil();

            Console.ReadKey();
        }
    }
}
