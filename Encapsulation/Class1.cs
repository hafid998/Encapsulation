using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    //PUBLIC
    class datadiri
    {
        public string Nama { get; set; }
        public int Umur { get; set; }
        public string Alamat { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine("========== PUBLIC =========");
            Console.WriteLine("Nama: " + Nama);
            Console.WriteLine("Umur: " + Umur);
            Console.WriteLine("Alamat: " + Alamat);
        }
    }
    // PRIVATE
    public class data_mhs
    {
        private string nama;
        private string nim;
        private double ipk;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Nim
        {
            get { return nim; }
            set { nim = value; }
        }

        public double Ipk
        {
            get { return ipk; }
            set { ipk = value; }
        }

        public void PrintDetails()
        {
            Console.WriteLine("======== PRIVATE ========");
            Console.WriteLine("Nama : " + Nama);
            Console.WriteLine("NIM  : " + Nim);
            Console.WriteLine("IPK  : " + Ipk);
        }
    }
    //PROTECTED
    public class Karyawan
    {
        private string nama;
        private int umur;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public int Umur
        {
            get { return umur; }
            set { umur = value; }
        }
    }

    public class Employee : Karyawan
    {
        private double gaji;

        public double Gaji
        {
            get { return gaji; }
            set { gaji = value; }
        }

        public void PrintDetails()
        {
            Console.WriteLine("======== PROTECTED ========");
            Console.WriteLine("Nama : " + Nama);
            Console.WriteLine("Umur : " + Umur);
            Console.WriteLine("Gaji : " + Gaji);
        }
    }

    // INTERNAL
    public class Mahasiswa
    {
        private string nama;
        private int umur;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public int Umur
        {
            get { return umur; }
            set { umur = value; }
        }

        public void Perkenalan()
        {
            Console.WriteLine("======== INTERNAL ========");
            Console.WriteLine("Perkenalkan, nama saya adalah " + nama + " dan saya berumur " + umur);
        }

        // PROTECTED INTERNAL
        public class Mahasiswa1
        {
            protected internal string Nama { get; set; }
            protected internal int Umur { get; set; }
            protected internal string NIM { get; set; }
            protected internal string Kelas { get; set; }

            public Mahasiswa1(string nama, int umur, string nim, string kelas)
            {
                Nama = nama;
                Umur = umur;
                NIM = nim;
                Kelas = kelas;
            }

            protected internal void DisplayInfo()
            {
                Console.WriteLine("======== PROTECTED INERNAL ========");
                Console.WriteLine("Name     : " + Nama);
                Console.WriteLine("Umur     : " + Umur);
                Console.WriteLine("NIM      : " + NIM);
                Console.WriteLine("Kelas    : " + Kelas);
            }
        }

        public class Student : Mahasiswa1
        {
            public Student(string nama, int umur, string nim, string kelas) : base(nama, umur, nim, kelas)
            {

            }

            public void ShowInfo()
            {
                DisplayInfo();
            }
        }
    }
}
