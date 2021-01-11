using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMaster3.Models.FacultateViewModels
{
    public class ProfesorIndexData
    {
        public IEnumerable<Profesor> Profesori { get; set; }
        public IEnumerable<Carte> Carti { get; set; }
        public IEnumerable<Curs> Cursuri { get; set; }
    }
}
