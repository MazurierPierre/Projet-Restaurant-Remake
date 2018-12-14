using Controller.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Kitchen
{
    public class KitchenClerck : Actor
    {
            public KitchenClerck(string name) : base(name)
            {
                this.mapActions.Add("BringMealToCounter", new BringMealToCounter());
                this.mapActions.Add("ChopVegetables", new ChopVegetables());
                this.mapActions.Add("CheckStocks", new CheckStocks());
                this.mapActions.Add("FillStocks", new FillStocks());
                this.mapActions.Add("RemoveFromStocks", new RemoveFromStocks());
            }

            //Intéragir avec les stocks
            public override void action(String choice)
            {
                switch (choice)
                {
                    case "BringMealToCounter":
                        this.lockAction = true;
                        this.mapActions["BringMealToCounter"].act();
                        this.lockAction = false;
                        break;
                    case "ChopVegetables":
                        this.lockAction = true;
                        this.mapActions["ChopVegetables"].act();
                        this.lockAction = false;
                        break;
                    case "CheckStocks":
                    this.lockAction = true;
                    this.mapActions["CheckStocks"].act();
                        break;
                    case "FillStocks":
                        this.mapActions["FillStocks"].act();
                        break;
                    case "RemoveFromStocks":
                        this.mapActions["RemoveFromStocks"].act();
                        break;
                    default:
                        //Do nothing ?
                    break;
                }
            }

        }
    }
