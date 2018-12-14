using Controller.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Kitchen
{
    public class Cook : Actor
    {
        public Cook(string name) : base(name)
        {
            this.mapActions.Add("PrepareDish", new PrepareDish());
            this.mapActions.Add("PrepareMorningDish", new PrepareMorningDish());
        }

        public override void action(String choice)
        {
            switch (choice)
            {
                case "PrepareDish":
                    this.mapActions["PrepareDish"].act();
                    break;
                case "PrepareMorningDish":
                    this.mapActions["PrepareMorningDish"].act();
                    break;
                default:
                    //Do nothing ?
                    break;
            }
        }
    }
}
