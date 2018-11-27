
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class UtilisateursRepository : Repository, IUtilisateursRepository
    {
        public List<Utilisateurs> GetAll()
        {
            return Session.Query<Utilisateurs>().ToList();
        }

        public void Save(Utilisateurs utilisateurs)
        {
           Session.SaveOrUpdate(utilisateurs);
           Session.Flush();
        }
    }
}