using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_3
{
    class KuliahMahasiswa_2311104060
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class CourseList
        {
            public List<Course> courses { get; set; }
        }

        public void ReadJSON()
        {
            string path = "tp7_2_1234567890.json";
            string jsonString = File.ReadAllText(path);

            CourseList courseList = JsonSerializer.Deserialize<CourseList>(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int index = 1;
            foreach (var course in courseList.courses)
            {
                Console.WriteLine($"MK {index} {course.code} - {course.name}");
                index++;
            }
        }
    }
}
