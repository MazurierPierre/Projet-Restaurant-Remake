using Controller.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Kitchen
{
    public class DishWasher : Actor
    {
        public DishWasher(string name) : base(name)
        {
            this.mapActions.Add("CleanKitchen", new CleanKitchen());
            this.mapActions.Add("ChopVegetables", new ChopVegetables());
            this.mapActions.Add("CleanKitchenware", new CleanKitchenware());
            this.mapActions.Add("CleanTableware", new CleanRoomware());
        }

        //Intéragir avec la plonge
        public override void action(String choice)
        {
            switch (choice)
            {
                case "CleanKitchen":
                    this.mapActions["CleanKitchen"].act();
                    break;
                case "ChopVegetables":
                    this.mapActions["ChopVegetables"].act();
                    break;
                case "CleanKitchenware":
                    this.mapActions["CleanKitchenware"].act();
                    break;
                case "CleanTableware":
                    this.mapActions["CleanTableware"].act();
                    break;
                default:
                    //Do nothing ?
                    break;
            }
        }
    }
}
