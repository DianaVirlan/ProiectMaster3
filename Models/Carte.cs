using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMaster3.Models
{
    public class Carte
    {
        public int ID { get; set; }
        public string Titlu { get; set; }
        public DateTime DataPublicare { get; set; }
        public int ProfesorID { get; set; }
        public Profesor Profesor { get; set; }
    }
}
