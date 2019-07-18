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
    public interface ILogica
    {
        IEnumerable<Docent> GetDocents();
        IEnumerable<OPO> GetDocentOpo(Docent id);
        void AddDocent(string naam, string voornaam, string personeelsnummer);
        void AddOpo(string code, string naam, int studiepunten, Fase fase, Semester sem, Docent verantwoordelijke);
        void AddOla(string code, string naam, int studiepunten, Docent docent, OPO opo);
        void UpdateOla(OLA ola);
        void DeleteOla(string ola);
        List<ListViewItem> GetOlaDocent(Docent docent);
        IEnumerable<OPO> GetAllOPOs();
        OPO GetOPOById(int id);
        OLA GetOlaByCode(string id);
        Docent GetDocentById(int id);
    }
}
