using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectMaster3.Models
{
    public class Participare
    {
        public int ID { get; set; }
        public int CursID { get; set; }
        public int StudentID { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Nota { get; set; }
        public Curs Curs { get; set; }
        public Student Student { get; set; }
    }
}
