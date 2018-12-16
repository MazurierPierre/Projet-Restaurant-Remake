using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.Common;
using Model.Room;

namespace Controller.Room
{
    public class Client : Common.Actor
    {
        public int number { get; set; } // The number of the client in the group
        public string behavior { get; set; } // The behavior for the eat() method
        public int tableNumber { get; set; }

        public Client(string name, int number, int tableNumber, string behavior = "relaxed") : base(name)
        {
            this.number = number;
            this.name = name;
            this.tableNumber = 0;


            // This the OrderAction behavior
            this.mapActions.Add("Order", new OrderAction()); // Can order to the Waiter
            this.mapActions.Add("Pay", new Pay()); // Can pay
            this.mapActions.Add("Eat", new Eat());
        }

        public void Action(String choice, Card card = null, Client client = null, Table table = null)
        {
            switch (choice)
            {
                case "Eat":
                    Eat eat = (Eat)this.mapActions["Eat"];
                    eat.act(client);
                    break;
                case "OrderAction":
                    OrderAction orderAction = (OrderAction)this.mapActions["OrderAction"];
                    orderAction.act(card);
                    break;
                case "Pay":
                    Pay pay = (Pay)this.mapActions["Pay"];
                    pay.act(client, table);
                    break;
                default:
                    break;
            }
        }


        public void setTableNumber(int number) // Attribute a table number
        {
            this.tableNumber = number;
        }
    }
}
