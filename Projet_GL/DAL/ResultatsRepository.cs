using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ResultatsRepository : Repository, IResultatsRepository
    {
        public IList<Resultats> GetAll()
        {
            return Session.Query<Resultats>().ToList();
        }

        public void Save(Resultats resultats)
        {
            Session.SaveOrUpdate(resultats);
            Session.Flush();
        }
    }
}