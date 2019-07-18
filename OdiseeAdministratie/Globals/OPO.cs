using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals
{
    // [Table("OPOes")]
    public class OPO : IComparable<OPO>
    {
        public int id;
        private string code;
        private string naam;
        private int studiepunten;
        //private string verantwoordelijke;
        private Semester sem;
        private Fase fase;

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
        //public string Verantwoordelijke
        //{
        //    get
        //    {
        //        return verantwoordelijke;
        //    }
        //    set
        //    {
        //        verantwoordelijke = value;
        //    }
        //}
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
        public Fase Fase
        {
            get
            {
                return fase;
            }
            set
            {
                fase = value;
            }
        }
        public Semester Semester
        {
            get
            {
                return sem;
            }
            set
            {
                sem = value;
            }
        }




        public virtual Docent Verantwoordelijke { get; set; }

        public OPO(int id, string code, string naam, int studiepunten, Docent verantwoordelijke, Fase fase, Semester sem)
        {
            this.id = id;
            this.naam = naam;
            this.studiepunten = studiepunten;
            this.code = code;
            this.Verantwoordelijke = verantwoordelijke;
            this.fase = fase;
            this.sem = sem;
        }

        public OPO()
        {
        }

        //public void AddOlas(List<OLA> olas)
        //{
        //    foreach(var ola in olas)
        //    {
        //        olas.Add(ola);
        //    }
        //}

        //public void AddOla(OLA ola)
        //{
        //    olas.Add(ola);
        //}

        public int CompareTo(OPO other)
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
                OPO p = (OPO)obj;
                return (code == p.code) && (code == p.code);
            }
        }

        public override String ToString()
        {
            return $"{code}: {naam} ({studiepunten}stp)";
        }
    }

}
