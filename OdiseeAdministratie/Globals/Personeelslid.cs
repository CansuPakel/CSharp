using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals
{
    public abstract class Personeelslid : Persoon
    {

        private string personeelsnummer;
        [Column(TypeName = "VARCHAR")]
        [Index(IsUnique = true)]
        public string Personeelsnummer
        {
            get
            {
                return personeelsnummer;
            }
            set
            {
                personeelsnummer = value;
            }
        }

        public Personeelslid()
        {

        }

        public Personeelslid(int id, string personeelsnummer, string naam, string voornaam) : base(id,naam, voornaam)
        {
            this.personeelsnummer = personeelsnummer;

        }
    }

}
