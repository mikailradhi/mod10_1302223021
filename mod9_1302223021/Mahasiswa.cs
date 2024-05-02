using Microsoft.VisualBasic;

namespace mod9_1302223021
{
    public class Mahasiswa
    {
        public String Name { get; set; }
        public String NIM { get; set; }
        public List<String> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa(string name, string NIM, List<string> course, int year)
        {
            this.Name = name;
            this.NIM = NIM;
            this.Course = course;
            this.Year = year;
        }
    }
}