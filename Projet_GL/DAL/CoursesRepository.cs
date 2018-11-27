
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CoursesRepository : Repository, ICoursesRepository
    {
        public IList<Courses> GetAll()
        {
            return Session.Query<Courses>().ToList();
        }

        public void Save(Courses courses)
        {
            Session.SaveOrUpdate(courses);
            Session.Flush();
        }
    }
}