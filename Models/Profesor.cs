using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMaster3.Models
{
    public class Profesor
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public ICollection<Curs> Cursuri { get; set; }
        public ICollection<Carte> Carti { get; set; }
    }
}
