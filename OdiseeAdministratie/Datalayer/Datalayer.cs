using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Globals;
using SharpRepository.EfRepository;

namespace Datalayer
{
    public class Datalayer : IDatalayer
    {
        DocentenContext db;


        Repository repository;
        Docent d = new Docent();
        public Datalayer()
        {
            db = new DocentenContext();
            repository = new Repository(db);
         //  MaakDocenten();
            // MaakOpos();
        //   MaakOlas();

        }

        public void MaakDocenten()
        {
            repository.InsertDocent(new Docent { Personeelsnummer = "Personeel1", Naam = "Demeester", Voornaam = "Peter" });
            repository.InsertDocent(new Docent { Personeelsnummer = "Personeel2", Naam = "Verbeeck", Voornaam = "Katja" });
       
        }

        public void MaakOlas()
        {
            repository.InsertOLA(new OLA { Code = "L1234", Naam = "C# Labo", Studiepunten = 4, docenten = { repository.GetDocentById(1), repository.GetDocentById(2) }, Opo = repository.GetOPOById(1) });
            repository.InsertOLA(new OLA { Code = "T1234", Naam = "C# theorie", Studiepunten = 2, docenten = { repository.GetDocentById(1) }, Opo = repository.GetOPOById(1) });
            repository.InsertOLA(new OLA { Code = "L4567", Naam = "Datascience labo", Studiepunten = 3, docenten = { repository.GetDocentById(2) }, Opo = repository.GetOPOById(2) });
            repository.InsertOLA(new OLA { Code = "T4567", Naam = "Datascience theorie", Studiepunten = 2, docenten = { repository.GetDocentById(2) }, Opo = repository.GetOPOById(2) });

        }

        public void MaakOpos()
        {
            repository.InsertOPO(new OPO { Code = "O9876", Naam = "C# techniques", Studiepunten = 6, Verantwoordelijke = repository.GetDocentById(1), Semester = Semester.sem2, Fase = Fase.fase2 });
            repository.InsertOPO(new OPO { Code = "O4568", Naam = "Datascience", Studiepunten = 6, Fase = Fase.fase2, Semester = Semester.sem2, Verantwoordelijke = repository.GetDocentById(2) });

        }
        public IEnumerable<OPO> GetAllOPOs()
        {
            return repository.GetAllOPOs();
        }

        public IEnumerable<Docent> GetDocents()
        {
            return repository.GetAllDocenten();
        }

        public IEnumerable<OPO> GetDocentOpo(Docent id)
        {
            return repository.GetOpoDocent(id);
        }

        public void AddDocent(string naam, string voornaam, string personeelsnummer)
        {
            repository.InsertDocent(new Docent { Naam = naam, Voornaam = voornaam, Personeelsnummer = personeelsnummer });
        }

        public void AddOpo(string code, string naam, int studiepunten, Fase fase, Semester sem, Docent verantwoordelijke)
        {
            repository.InsertOPO(new OPO { Code = code, Naam = naam, Studiepunten = studiepunten, Fase = fase, Semester = sem, Verantwoordelijke = verantwoordelijke });
        }

        public void AddOla(string code, string naam, int studiepunten, Docent docent, OPO opo)
        {
            repository.InsertOLA(new OLA { Code = code, Naam = naam, Studiepunten = studiepunten, docenten = { docent }, Opo = repository.GetOPOById(opo.id) });
        }

        public void UpdateOla(OLA ola)
        {
            repository.UpdateOla(ola);
        }

        public void DeleteOla(string ola)
        {
            repository.DeleteOla(ola);
        }
        public List<ListViewItem> GetOlaDocent(Docent docent)
        {
            return repository.GetOlaDocent(docent);
        }

        public OPO GetOPOById(int id)
        {
            return repository.GetOPOById(id);
        }

        public Docent GetDocentById(int id)
        {
            return repository.GetDocentById(id);
        }

        public OLA GetOlaByCode(string id)
        {
            return repository.GetOlaByCode(id);
        }


    }
}
