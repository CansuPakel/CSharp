using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals
{

    // [Table("Docents")]
    public class Docent : Personeelslid
    {
        public virtual ICollection<OLA> olas { get; set; }
        public virtual ICollection<OPO> opos { get; set; }


        public Docent(int id, string personeelsnummer, string naam, string voornaam) : base(id, personeelsnummer, naam, voornaam)
        {
            this.olas = new List<OLA>();
            this.opos = new List<OPO>();
        }

        public Docent()
        {
            this.olas = new List<OLA>();
            this.opos = new List<OPO>();
        }

        public void AddOla(OLA ola)
        {
            olas.Add(ola);
        }
        public void RemoveOla(OLA ola)
        {
            olas.Remove(ola);
        }
        public void AddOpo(OPO opo)
        {
            opos.Add(opo);
        }
        public string fullName
        {
            get
            {
                return Voornaam + " " + Naam + " " + Personeelsnummer;
            }
        }
    }
}
