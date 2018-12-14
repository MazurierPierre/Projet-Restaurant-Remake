using Controller.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Kitchen
{
    public class MainChef : Actor
    {
        private IsDishAchievable isDishAvailable = new IsDishAchievable();
        public MainChef(string name) : base(name)
        {
            this.mapActions.Add("AuthorizeOrder", new AuthorizeOrder());
            this.mapActions.Add("RefuseOrder", new RefuseOrder());
            this.mapActions.Add("FindDishSimilarities", new FindDishSimilarities());
        }

        public override void action(String choice)
        {
            switch (choice)
            {
                case "isDishAchievable":
                    if (isDishAvailable.isAvailable()) //If dish is Achievable
                    {
                        this.mapActions["FindDishSimilarities"].act(); //Regroupement des similarités
                        this.mapActions["AuthorizeOrder"].act();  //Envoyer en cuisine & autoriser
                    }
                    else
                    {
                        this.mapActions["RefuseOrder"].act();
                    }
                    break;
                default:
                    //Do nothing ?
                    break;
            }
        }

    }
}
