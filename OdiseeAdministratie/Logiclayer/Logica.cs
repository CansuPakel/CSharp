using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datalayer;
using Globals;
namespace Logiclayer
{
    public class Logica : ILogica
    {
        private IDatalayer datalaag;

        public Logica()
        {
            this.datalaag = new Datalayer.Datalayer();
        }
        public IEnumerable<Docent> GetDocents()
        {
            return datalaag.GetDocents();
        }

        //public List<OLA> GetOLAs()
        //{
        //    return datalaag.GetOLAs();
        //}
        public void AddDocent(string naam, string voornaam, string personeelsnummer)
        {
            datalaag.AddDocent(naam, voornaam, personeelsnummer);
        }
        public IEnumerable<OPO> GetDocentOpo(Docent id)
        {
            return datalaag.GetDocentOpo(id);
        }
        public void AddOpo(string code, string naam, int studiepunten, Fase fase, Semester sem, Docent verantwoordelijke)
        {
           datalaag.AddOpo(code, naam, studiepunten, fase, sem, verantwoordelijke);
        }

        public void AddOla(string code, string naam, int studiepunten, Docent docent, OPO opo)
        {
            datalaag.AddOla(code, naam, studiepunten, docent,opo);
        }

        public void UpdateOla(OLA ola)
        {
            datalaag.UpdateOla( ola);
        }
        public IEnumerable<OPO> GetAllOPOs()
        {
           return datalaag.GetAllOPOs();
        }

        public void DeleteOla(string ola)
        {
            datalaag.DeleteOla(ola);
        }
        public List<ListViewItem> GetOlaDocent(Docent docent)
        {
            return datalaag.GetOlaDocent(docent);
        }
        public OPO GetOPOById(int id)
        {
            return datalaag.GetOPOById(id);
        }

        public Docent GetDocentById(int id)
        {
            return datalaag.GetDocentById(id);
        }
        public OLA GetOlaByCode(string id)
        {
            return datalaag.GetOlaByCode(id);
        }


    }
}
