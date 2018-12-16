using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Kitchen.Cooking.Ingredients;

namespace Model.Kitchen.Wash.Machines
{
    public class DishwasherMachine : WashingKitchenTools
    {
        public DishwasherMachine() : base(10, 30)
        {
        }

        public override void addToWash(QueueKitchenTools qkt)
        {
            Boolean tmp = false;
            while (tmp == false)
            {
                foreach (KitchenTool tool in qkt.kitchenToolsList)
                {
                    if (!this.itemToWashList.Any()) { this.itemToWashList.Add(tool); } //premier passage
                    if (this.itemToWashList.Count <= 10) //10
                    {
                        this.itemToWashList.Add(tool);
                        //retirer de la queue 
                        qkt.kitchenToolsList.Remove(tool);
                    }
                    else //isFull
                    {
                        return;
                    }
                    if (!qkt.kitchenToolsList.Any()) { tmp = true; } //Si la queue est vide
                    break;
                }
            }
        }
    }
}