using Model.Kitchen.Cooking.Ingredients;
using Model.Kitchen.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Kitchen.Wash.Machines
{
    public abstract class WashingKitchenTools : WashMachine
    {
        public List<KitchenTool> itemToWashList { get; set; }
        protected WashingKitchenTools(int washTime, int maxCapacity)
        {

        }
         public void addToWash(QueueKitchenTools qkt)
         {
             Boolean tmp = false;
             while (tmp == false)
             {
                 foreach (KitchenTool tool in qkt.kitchenToolsList)
                 {
                     if (!this.itemToWashList.Any()) { this.itemToWashList.Add(tool); } //premier passage
                     if (this.itemToWashList.Count <= this.maxCapacity)
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

         //supprime les élements pour réimplémenter plus tard
         public void endWash()
         {
            this.itemToWashList.Clear();
         }

         public override void wash()
         {
             this.isRunning = true;
             if (!this.itemToWashList.Any()) { return; } //Liste vide ou moins d'élements que prévu ==> Arrêt machine (même si durée ne change pas)
             foreach (KitchenTool tw in itemToWashList)
             {
                 tw.KitchenToolsType = EnumKitchen.KitchenToolsType.OK;
             }
             endWash();
             this.isRunning = false;
         }
     }
}

