using Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Encapsulation.Mahasiswa;

class Program
{
    // PUBLIC
    static void Main(string[] args)
    {
        // PUBLIC
        datadiri p = new datadiri();
        p.Nama = "Muhammad Hafid A";
        p.Umur = 19;
        p.Alamat = "Cilacap, Jawa Tengah";
        p.PrintDetails();

        // PRIVATE
        data_mhs data = new data_mhs();
        data.Nama = "Muhammad Hafid A";
        data.Nim = "22.11.4828";
        data.Ipk = 3.9;

        data.PrintDetails();

        // PROTECTED
        Employee emp = new Employee();
        emp.Nama = "Bayu Setiawan";
        emp.Umur = 25;
        emp.Gaji = 10000000;

        emp.PrintDetails();

        // INTERNAL
        Mahasiswa mhs = new Mahasiswa();
        mhs.Nama = "Muhammad Hafid Assidiqi";
        mhs.Umur = 19;
        mhs.Perkenalan();

        // PROTECTED INTERNAL
        Student s = new Student("Muhammad Hafid A", 19, "22.11.4828", "IF 05");
        s.ShowInfo();
    }

        

}