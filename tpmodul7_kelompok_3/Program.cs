using System;
using tpmodul7_kelompok_3;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Menjalankan deserialisasi JSON mahasiswa (soal no. 2)
        Console.WriteLine("=== Data Mahasiswa ===");
        var dataMahasiswa = new DataMahasiswa_2311104060(); // Ganti dengan NIM kamu
        dataMahasiswa.ReadJSON();

        Console.WriteLine(); // newline

        // Menjalankan deserialisasi JSON mata kuliah (soal no. 4)
        Console.WriteLine("=== Daftar Mata Kuliah ===");
        var kuliahMahasiswa = new KuliahMahasiswa_2311104060(); // Ganti dengan NIM kamu
        kuliahMahasiswa.ReadJSON();

        Console.WriteLine(); // newline
    }
}
