using System;
using Controller.Common;

namespace Controller.Room
{
    public class Butler : Common.Actor
    {
        public Butler(string name) : base(name)
        {
            this.name = name;
            this.mapAct.Add("VerifyReservation", new VerifyReservation()); // Can Verify the reservation's list
            this.mapAct.Add("AssignTable", new AssignTable()); // Can assign a client to a table

        }
        public void Action(String choice, Client client, Table table = null)
        {
            switch (choice)
            {
                case "VerifyReservation":
                    VerifyReservation verifyReservation = (VerifyReservation)this.mapAct["VerifyReservation"];
                    verifyReservation.voidAct(client);
                    break;
                case "AssignTable":
                    AssignTable assignTable = (AssignTable)this.mapAct["AssignTable"];
                    assignTable.voidAct(client, table);
                    break;
                default:
                    break;
            }
        }
    }
}
