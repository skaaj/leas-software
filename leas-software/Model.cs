using System;
using System.Collections.Generic;

namespace leas_software
{
    public class Model
    {
        private List<Situation> sList;
        private User currentUser;

        public Model()
        {
            this.LoadSituations();
        }

        private void LoadSituations()
        {
            sList = new List<Situation>();
            sList.Add(new Situation(0, "Vous vous tapez le doigt devant votre voisin."));
            sList.Add(new Situation(1, "Vous êtes dans le désert mais vous n'avez plus d'eau dans votre gourde."));
            sList.Add(new Situation(2, "Vous avez oublié l'anniversaire de votre conjoint(e)."));
            sList.Add(new Situation(2, "Votre Hyundai Matrix a un pneu crevé et vous n'avez pas de roue de secours."));
        }

        public Situation getSituation(int index)
        {
            if (index < 0 || index >= sList.Count)
                return null;

            return sList[index];
        }

        public void setCurrentUser(string nom, int age, string sexe)
        {
            currentUser = new User(nom, age, sexe);
        }

        public int getNbSituations()
        {
            return sList.Count;
        }

        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
        }
    }
}
