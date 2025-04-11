using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_3
{
    class KuliahMahasiswa2311104057
    {
        public class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
        }
        public class ListMatkul
        {
            public List<MataKuliah> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string path = "tp7_2_2311104057.json"; // ganti dengan nama file yang sudah diganti sesuai NIM
            string jsonContent = File.ReadAllText(path);
            ListMatkul listMatkul = JsonSerializer.Deserialize<ListMatkul>(jsonContent);
            int count = 1;
            foreach (var matkul in listMatkul.courses)
            {
                Console.WriteLine($"MK {count} {matkul.code} - {matkul.name}");
                count++;
            }
        }
    }
}
