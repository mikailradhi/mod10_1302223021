using Microsoft.AspNetCore.Mvc;

namespace mod9_1302223021.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> Mahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Naufal", "1302223023", new List<string>{"KPL","PBO","BasisData"},2024),
            new Mahasiswa("Mika", "1302223021", new List<string>{"Proting","Jarkom","IMK"},2023),
            new Mahasiswa("Kean", "1302223024", new List<string>{"AKA","Alpro","Matdis"},2022)
        };
        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return Mahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            if (id < 0 || id >= Mahasiswa.Count)
            {
                NotFound();
            }
            return Mahasiswa[id];
        }

        [HttpDelete]
        public void Delete(int id)
        {
            Mahasiswa.RemoveAt(id);
        }

        [HttpPost]
        public void Post(Mahasiswa mahasiswa)
        {
            Mahasiswa.Add(mahasiswa);
        }
    }
}
