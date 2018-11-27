using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            ICoursesRepository coursesRepository = new CoursesRepository();
            IUtilisateursRepository utilisateursRepository = new UtilisateursRepository();
            IParticipantsRepository participantsRepository = new ParticipantsRepository();
            IResultatsRepository resultatsRepository = new ResultatsRepository();

            IList<Utilisateurs> utils = utilisateursRepository.GetAll();
            foreach (Utilisateurs util in utils)
            {
                Console.WriteLine(util);
            }

            Utilisateurs U = new Utilisateurs("sss", "ssss", "sss");
            Resultats r = new Resultats();
            Participants p = new Participants();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
