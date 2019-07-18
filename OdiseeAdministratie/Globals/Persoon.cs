using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals
{
    public abstract class Persoon
    {
        private int id;
        private string naam;
        private string voornaam;
        [Key]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Naam
        {
            get
            {
                return naam;
            }
            set
            {
                naam = value;
            }
        }

        public string Voornaam
        {
            get
            {
                return voornaam;
            }
            set
            {
                voornaam = value;
            }
        }

        public Persoon(int id, string naam, string voornaam)
        {
            this.id = id;
            this.voornaam = voornaam;
            this.naam = naam;
        }

        public Persoon()
        {

        }

        public override string ToString()
        {
            return $"{Naam} {Voornaam}";
        }
    }

}
