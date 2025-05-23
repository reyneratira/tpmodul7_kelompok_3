﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_3
{
    public class DataMahasiswa2311104057
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class Mahasiswa
        {
            public Nama nama { get; set; }
            public long nim { get; set; }
            public string fakultas { get; set; }
        }

        public static void ReadJSON()
        {
            string path = "tp7_1_2311104057.json"; // ganti dengan nama file yang sudah diganti sesuai NIM
            string jsonContent = File.ReadAllText(path);

            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonContent);

            Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
        }
    }
}
