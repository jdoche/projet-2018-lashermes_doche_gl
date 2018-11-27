using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Domain;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoursesRepository coursesRepository = new CoursesRepository();
            IUtilisateursRepository utilisateursRepository = new UtilisateursRepository();
            IParticipantsRepository participantsRepository = new ParticipantsRepository();
            IResultatsRepository resultatsRepository = new ResultatsRepository();

            List<Utilisateurs> utils = utilisateursRepository.GetAll();
            foreach (Utilisateurs util in utils)
            {
                Console.WriteLine(util);
            }
            Console.Write("Ajout d'un nouvel utilisateur... ");
            Utilisateurs empr = new Utilisateurs("jdoche","LeHardenBlanc","realMVP");
            utilisateursRepository.Save(empr);
            Console.WriteLine(empr);

            Courses crs = new Courses("Rallye des Apparts", new DateTime(2018,11,29), 12, "Talence", 75);
            coursesRepository.Save(crs);
            Participants part = new Participants("Loizel", "Antoine", new DateTime(1996, 12, 14), 'M', "aloizel@ensc.fr");
            participantsRepository.Save(part);
            Resultats rtl = new Resultats(crs, part, new TimeSpan(7, 8, 15), 007);
            resultatsRepository.Save(rtl);
            Console.ReadLine();
        }
    }
}
