using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public   class Resultats
    {
        protected virtual int resId
        {
            get;
            set;
        }

        protected virtual int resDossard
        {
            get;
            set;
        }

        protected virtual TimeSpan resTemps
        {
            get;
            set;
        }

        protected virtual int partId
        {
            get;
            set;
        }

        protected virtual int courId
        {
            get;
            set;
        }

        public virtual Courses laCourse
        {
            get;
            set;
        }

        public virtual Participants leParticipant
        {
            get;
            set;
        }

        public Resultats()
        {
        }

       
        public Resultats(Courses c, Participants p, TimeSpan t, int dossard )
        {
            this.resDossard = dossard;
            this.resTemps = t;
            this.partId = p.partId;
            this.courId = c.courId;

        }
    }
}
