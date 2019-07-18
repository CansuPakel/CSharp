using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Globals;
using SharpRepository.EfRepository;

namespace Datalayer
{
    public class Repository
    {
        private DocentenContext dataContext;
        private EfRepository<Docent, int> docenten;
        private EfRepository<OLA, int> olas;
        private EfRepository<OPO, int> opos;

        public Repository(DocentenContext dataContext)
        {
            this.dataContext = dataContext;
            docenten = new EfRepository<Docent, int>(dataContext);
            olas = new EfRepository<OLA, int>(dataContext);
            opos = new EfRepository<OPO, int>(dataContext);
        }

        public IEnumerable<Docent> GetAllDocenten()
        {
            return docenten.GetAll().OrderBy(x => x.Naam).ToList();
        }

        public Docent GetDocentById(int id)
        {
            return docenten.Get(id);
        }

        public OLA GetOLAById(int id)
        {
            return olas.Get(id);
        }

        public OPO GetOPOById(int id)
        {
            return opos.Get(id);
        }

        public IEnumerable<OPO> GetAllOPOs()
        {
            return opos.GetAll();
        }
        public IEnumerable<OLA> GetAllOLAs()
        {
            return olas.GetAll();
        }
        public OLA GetOlaByCode(string id)
        {
            return GetAllOLAs().Single(x => x.Code == id);
        }

        public IEnumerable<OPO> GetOpoDocent(Docent id)
        {
            List<OPO> test = GetAllOPOs().Where(x => x.Verantwoordelijke == id).ToList();
            return test;
        }

        public IEnumerable<string> GetOpoOla(OLA ola)
        {
            return (from OPO in opos.GetAll()
                    where OPO.id == ola.Id
                    select OPO.Naam);
        }

        public List<ListViewItem> GetOlaDocent(Docent docent)
        {
            var olas = new List<ListViewItem>();
            if (docent.olas != null)
            {
                foreach (var ola in docent.olas)
                {
                    olas.Add(new ListViewItem(new string[] { ola.Code, ola.Naam, ola.Opo.Naam, ola.Studiepunten.ToString() }));
                }
            }
            return olas;
        }

        public void InsertDocent(Docent docent)
        {
            docenten.Add(docent);
            dataContext.SaveChanges();
        }

        public void InsertOLA(OLA ola)
        {
            olas.Add(ola);
            dataContext.SaveChanges();
        }

        public void InsertOPO(OPO opo)
        {
            opos.Add(opo);
            dataContext.SaveChanges();
        }

        public void DeleteOla(string ola)
        {
            olas.Delete(GetOlaByCode(ola));
            dataContext.SaveChanges();
        }


        public void UpdateOla(OLA ola)
        {
            olas.Update(ola);
            dataContext.SaveChanges();
        }
    }
}
