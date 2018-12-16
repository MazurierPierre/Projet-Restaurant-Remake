using System;
using Controller.Common;
using Model.Room;

namespace Controller.Room
{
    public class Butler : Common.Actor
    {
        public Butler(string name) : base(name)
        {
            this.name = name;
            this.mapActions.Add("VerifyReservation", new VerifyReservation()); // Can Verify the reservation's list
            this.mapActions.Add("AssignTable", new AssignTable()); // Can assign a client to a table

        }
        public void Action(String choice, Client client, Table table = null)
        {
            switch (choice)
            {
                case "VerifyReservation":
                    //this.mapActions["VerifyReservation"].act();
                    VerifyReservation verifyReservation = (VerifyReservation)this.mapActions["VerifyReservation"];
                    verifyReservation.act(client);
                    break;
                case "AssignTable":
                    AssignTable assignTable = (AssignTable)this.mapActions["AssignTable"];
                    assignTable.act(client, table);
                    break;
                default:
                    break;
            }
        }
    }
}
