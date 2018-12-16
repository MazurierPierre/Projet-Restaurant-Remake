using System;
using System.Collections.Generic;
using Controller.Common;
using Model.Kitchen.Cooking;
using Model.Room;

namespace Controller.Room
{
    public class HeadWaiter : Common.Actor
    {
        public Square square { get; set; }

        public HeadWaiter(string name, Square square) : base(name)
        {
            this.name = name;
            this.square = square;

            this.mapActions.Add("BringMenu", new BringMenu()); // Can bring the card
            this.mapActions.Add("TakeOrder", new TakeOrder()); // Can take the order
            this.mapActions.Add("PlaceClient", new PlaceClient()); // Can place the client

        }

        public void Action(String choice, Table table = null, Client client = null, List<Menu> menus = null)
        {
            switch (choice)
            {
                case "BringMenu": //Arg Table Card
                    BringMenu bringMenu = (BringMenu)this.mapActions["BringMenu"];
                    bringMenu.act(table);
                    break;
                case "TakeOrder": //Arg Client, List<Menu> 
                    TakeOrder takeOrder = (TakeOrder)this.mapActions["TakeOrder"];
                    takeOrder.act(client, menus);
                    break;
                case "PlaceClient": // Arg Client Table
                    PlaceClient placeClient = (PlaceClient)this.mapActions["PlaceClient"];
                    placeClient.act(client, table);
                    break;
                default:
                    break;
            }
        }
    }
}
