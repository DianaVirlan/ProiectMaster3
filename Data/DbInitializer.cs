using ProiectMaster3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMaster3.Data
{
    public class DbInitializer
    {
        public static void Initialize(ContextFacultate context)
        {
            context.Database.EnsureCreated();

            if (context.Studenti.Any())
            {
                return; // BD a fost creata anterior
            }

            var profesori = new Profesor[]
            {
               new Profesor{Nume="Anton", Prenume="Vasile", Email="anton.vasile@yahoo.com"},
               new Profesor{Nume="Popa", Prenume="Ana", Email="popa.ana@yahoo.com"},
               new Profesor{Nume="Marin", Prenume="Angel", Email="marin.a@yahoo.com"},
               new Profesor{Nume="Vamanu", Prenume="Dana", Email="danuta@gmail.com"},
               new Profesor{Nume="Morariu", Prenume="Anamaria", Email="morariua@gmail.com"},
               new Profesor{Nume="Popa", Prenume="Andrei", Email="popa.andrei78@yahoo.com"},
            };
            foreach (Profesor p in profesori)
            {
                context.Profesori.Add(p);
            }
            context.SaveChanges();

            var cursuri = new Curs[]
            { new Curs{ID=1, Denumire="Informatica Economica",Credite=5, ProfesorID=1},
              new Curs{ID=2, Denumire="Economie",Credite=4, ProfesorID=2},
              new Curs{ID=3, Denumire="Matematica",Credite=5, ProfesorID=3},
              new Curs{ID=4, Denumire="Statistica",Credite=3, ProfesorID=4},
              new Curs{ID=5, Denumire="Management",Credite=4, ProfesorID=5},
              new Curs{ID=6, Denumire="Finante",Credite=5, ProfesorID=6}
            };
            foreach (Curs c in cursuri)
            {
                context.Cursuri.Add(c);
            }
            context.SaveChanges();

            var studenti = new Student[]
            {
               new Student{Nume="Moculescu", Prenume="Flaviu", DataNasterii=DateTime.Parse("1997-07-08"), An=2},
               new Student{Nume="Nita", Prenume="Adi", DataNasterii=DateTime.Parse("1997-03-03"), An=1},
               new Student{Nume="Stanescu", Prenume="Stela", DataNasterii=DateTime.Parse("1998-08-08"), An=2},
               new Student{Nume="Vlaicu", Prenume="Corina", DataNasterii=DateTime.Parse("1997-07-23"), An=3},
               new Student{Nume="Stefan", Prenume="Horatiu", DataNasterii=DateTime.Parse("1997-07-08"), An=2},
               new Student{Nume="Mironescu", Prenume="Victor", DataNasterii=DateTime.Parse("1998-09-03"), An=1},
               new Student{Nume="Prunea", Prenume="Delia", DataNasterii=DateTime.Parse("1997-07-08"), An=1},
               new Student{Nume="Apostu", Prenume="Isabella", DataNasterii=DateTime.Parse("1996-04-03"), An=3},
               new Student{Nume="Stefanescu", Prenume="Sorin", DataNasterii=DateTime.Parse("1997-07-08"), An=2},
               new Student{Nume="Bogza", Prenume="Mihai", DataNasterii=DateTime.Parse("1997-06-05"), An=3},
            };
            foreach (Student st in studenti)
            {
                context.Studenti.Add(st);
            }
            context.SaveChanges();

            var carti = new Carte[]
            {
               new Carte{Titlu="Programare in C", DataPublicare=DateTime.Parse("1997-03-03"), ProfesorID=1},
               new Carte{Titlu="Economie", DataPublicare=DateTime.Parse("1995-02-02"), ProfesorID=2},
               new Carte{Titlu="Economie aplicata", DataPublicare=DateTime.Parse("1995-07-02"), ProfesorID=2},
               new Carte{Titlu="Finante", DataPublicare=DateTime.Parse("1997-09-09"), ProfesorID=6},
            };
            foreach (Carte b in carti)
            {
                context.Carti.Add(b);
            }
            context.SaveChanges();

            var participari = new Participare[]
            { new Participare{CursID=1, StudentID=1, Nota=Decimal.Parse("7.2")},
              new Participare{CursID=2, StudentID=2, Nota=Decimal.Parse("8")},
              new Participare{CursID=3, StudentID=2, Nota=Decimal.Parse("5.5")},
              new Participare{CursID=5, StudentID=1, Nota=Decimal.Parse("9")},
              new Participare{CursID=2, StudentID=2, Nota=Decimal.Parse("10")},
              new Participare{CursID=3, StudentID=3, Nota=Decimal.Parse("8.5")},
              new Participare{CursID=4, StudentID=3, Nota=Decimal.Parse("6.7")},
              new Participare{CursID=2, StudentID=4, Nota=Decimal.Parse("9.4")},
              new Participare{CursID=5, StudentID=2, Nota=Decimal.Parse("4")},
              new Participare{CursID=1, StudentID=6, Nota=Decimal.Parse("3.4")},
              new Participare{CursID=5, StudentID=5, Nota=Decimal.Parse("4.6")},
              new Participare{CursID=1, StudentID=5, Nota=Decimal.Parse("7")}
            };
            foreach (Participare p in participari)
            {
                context.Participari.Add(p);
            }
            context.SaveChanges();
        }
    }
}