using Controller.Common;
using Model.Kitchen.Cooking.Ingredients;
using Model.Kitchen.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Kitchen
{
    public class KitchenClerck : Actor
    {
        // Méthodes EXCLUSIVES au KC
        CheckStocks checkstocks = new CheckStocks();
        FillStocks fillStocks = new FillStocks();
        RemoveFromStocks removeFromStocks = new RemoveFromStocks();

        public KitchenClerck(string name) : base(name)
        {
            this.mapActions.Add("BringMealToCounter", new BringMealToCounter());
            this.mapActions.Add("ChopVegetables", new ChopVegetables());
        }

        //Intéragir avec les stocks
        public override void action(String choice)
        {
            switch (choice)
            {
                case "BringMealToCounter":
                    this.mapActions["BringMealToCounter"].act();
                    break;
                case "ChopVegetables":
                    this.mapActions["ChopVegetables"].act();
                    break;
            }
        }

        public void actionStorage(String choice, Storage stor, int number, Ingredient ing)
        {
            switch (choice)
            {
                case "CheckStocks":
                    checkstocks.act(stor);
                    break;
                case "FillStocks":
                    fillStocks.act(stor,number, ing);
                    break;
                case "RemoveFromStocks":
                    removeFromStocks.act(stor, number, ing);
                    break;
            }

        }
    }
    }
