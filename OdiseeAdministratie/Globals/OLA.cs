using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals
{
    //[Table("OLAs")]
    public class OLA : IComparable<OLA>
    {
        private int id;
        private string code;
        private string naam;
        private int studiepunten;

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
        [Column(TypeName = "VARCHAR")]
        [Index(IsUnique = true)]
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
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

        public int Studiepunten
        {
            get
            {
                return studiepunten;
            }
            set
            {
                studiepunten = value;
            }
        }


        public virtual ICollection<Docent> docenten { get; set; }
        public virtual OPO Opo { get; set; }
        public OLA(int id, string code, string naam, int studiepunten, List<Docent> docenten, OPO opo)
        {
            this.id = id;
            this.naam = naam;
            this.studiepunten = studiepunten;
            this.code = code;
            this.Opo = opo;
            docenten = new List<Docent>();
        }

        public void RemoveDocent(Docent docent)
        {
            docenten.Remove(docent);
        }
        public void AddDocent(Docent docent)
        {
            docenten.Add(docent);
        }
        public OLA()
        {
            docenten = new List<Docent>();
        }

        public int CompareTo(OLA other)
        {
            if (this.code == other.code)
            {
                return this.code.CompareTo(other.code);
            }
            return other.code.CompareTo(this.code);
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                OLA p = (OLA)obj;
                return (code == p.code) && (code == p.code);
            }
        }

        public override String ToString()
        {
            return $"{code}: {naam} ({studiepunten} stp)";
        }
    }

}
