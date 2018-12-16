﻿using System;
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

            this.mapAct.Add("BringMenu", new BringMenu()); // Can bring the card
            this.mapAct.Add("TakeOrder", new TakeOrder()); // Can take the order
            this.mapAct.Add("PlaceClient", new PlaceClient()); // Can place the client

        }

        public void Action(String choice, Table table = null, Card card = null, Client client = null, List<Menu> menus = null)
        {
            switch (choice)
            {
                case "BringMenu": //Arg Table Card
                    BringMenu bringMenu = (BringMenu)this.mapAct["BringMenu"];
                    bringMenu.voidAct(table, card);
                    break;
                case "TakeOrder": //Arg Client, List<Menu> 
                    TakeOrder takeOrder = (TakeOrder)this.mapAct["TakeOrder"];
                    takeOrder.voidAct(client, menus);
                    break;
                case "PlaceClient": // Arg Client Table
                    PlaceClient placeClient = (PlaceClient)this.mapAct["PlaceClient"];
                    placeClient.voidAct(client, table);
                    break;
                default:
                    break;
            }
        }
    }
}
