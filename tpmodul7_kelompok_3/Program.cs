﻿using System;
using tpmodul7_kelompok_3;

using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("=== Data Mahasiswa ===");
        var dataMahasiswa = new DataMahasiswa_2311104060(); 
        dataMahasiswa.ReadJSON();

        Console.WriteLine(); // newline

        
        Console.WriteLine("=== Daftar Mata Kuliah ===");
        var kuliahMahasiswa = new KuliahMahasiswa_2311104060(); 
        kuliahMahasiswa.ReadJSON();

        Console.WriteLine(); // newline
    }
}
