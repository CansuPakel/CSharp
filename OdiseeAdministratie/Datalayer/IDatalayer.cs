using Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datalayer
{
    public interface IDatalayer
    {
        IEnumerable<Docent> GetDocents();
        IEnumerable<OPO> GetDocentOpo(Docent id);

        void AddDocent(string naam, string voornaam, string personeelsnummer);
        void AddOpo(string code, string naam, int studiepunten, Fase fase, Semester sem, Docent verantwoordelijke);
        void AddOla(string code, string naam, int studiepunten, Docent docent, OPO opo);
        void UpdateOla(OLA ola);
        List<ListViewItem> GetOlaDocent(Docent docent);
        IEnumerable<OPO> GetAllOPOs();
        OPO GetOPOById(int id);
        OLA GetOlaByCode(string id);
        Docent GetDocentById(int id);
        void DeleteOla(string ola);



    }
}
