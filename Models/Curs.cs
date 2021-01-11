using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMaster3.Models
{
    public class Curs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Denumire { get; set; }
        public int Credite { get; set; }
        public int ProfesorID { get; set; }
        public Profesor Profesor { get; set; }
        public ICollection<Participare> Participari { get; set; }
    }
}
