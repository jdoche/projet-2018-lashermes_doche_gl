using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Courses
    {
        public virtual int courId
        {
            get;
            set;
        }

        public virtual string courNom
        {
            get;
            set;
        }

        public virtual int courNbPartMax
        {
            get;
            set;
        }

        public virtual int courDistance
        {
            get;
            set;
        }

        public virtual string courLieu
        {
            get;
            set;
        }

        public virtual DateTime courDate
        {
            get;
            set;
        }

        public virtual Resultats Resultats
        {
            get;
            set;
        }

        public Courses(string Nom, DateTime Date, int Distance, string Lieu, int NbPartMax)
        {
            this.courNom = Nom;
            this.courDate = Date;
            this.courDistance=Distance;
            this.courLieu = Lieu;
            this.courNbPartMax = NbPartMax;
        }

        public Courses()
        { }
    }
}
