using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateurs
    {
        protected virtual int utilId
        {
            get;
            set;
        }

        protected virtual string utilNom
        {
            get;
            set;
        }

        protected virtual string utilMdp
        {
            get;
            set;
        }

        protected virtual string utilLogin
        {
            get;
            set;
        }

        public Utilisateurs(string Nom, string Login, string Mdp)
        {
            this.utilNom = Nom;
            this.utilLogin = Login;
            this.utilMdp = Mdp;

        }

        public Utilisateurs()
        {
        }

        public override string ToString()
        {
            return utilNom + utilLogin + utilMdp;
        }
    }
}
