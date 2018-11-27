using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ParticipantsRepository : Repository, IParticipantsRepository
    {
        public IList<Participants> GetAll()
        {
            return Session.Query<Participants>().ToList();
        }

        public void Save(Participants participants)
        {
            Session.SaveOrUpdate(participants);
            Session.Flush();
        }
    }
}