using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Participants
    {
        public virtual int partId
        {
            get;
            set;
        }

        public virtual string partNom
        {
            get;
            set;
        }

        public virtual string partPrenom
        {
            get;
            set;
        }

        public virtual DateTime partAnnee
        {
            get;
            set;
        }

        public virtual char partSexe
        {
            get;
            set;
        }

        public virtual string partCourriel
        {
            get;
            set;
        }

        public virtual string partLicence
        {
            get;
            set;
        }

        
        public virtual IEnumerable<Resultats> lesResultats
        {
            get;
            set;
        }

        public Participants(string Nom, string Prenom, DateTime AnneeNaissance, char Sexe, string Courriel)
        {
            this.partNom = Nom;
            this.partPrenom = Prenom;
            this.partAnnee = AnneeNaissance;
            this.partSexe = Sexe;
            this.partCourriel = Courriel;
        }

        public Participants(string Nom, string Prenom, DateTime AnneeNaissance, char Sexe, string Courriel, string Licence)
        {
            this.partNom = Nom;
            this.partPrenom = Prenom;
            this.partAnnee = AnneeNaissance;
            this.partSexe = Sexe;
            this.partCourriel = Courriel;
            this.partLicence = Licence;
        }

        public Participants()
        {
        }


    }
}
