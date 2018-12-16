using System;
using Controller.Common;
using Model.Room;
using Model.Room.Element;

namespace Controller.Room
{
    public class ClerkRoom : Common.Actor
    {
        public ClerkRoom(string name) : base(name)
        {
            this.name = name;

            // This is the clerk's roles
            this.mapActions.Add("BringBread", new BringBread()); // Can bring the bread
            this.mapActions.Add("BringJug", new BringJug()); // Can bring the Jug

            // But it can take also the waiter's role
            this.mapActions.Add("Serve", new Serve()); // Can serve the client
            this.mapActions.Add("CleanTable", new CleanTable()); // Can clean the table

        }
        public void Action(String choice, Table table, Waiter waiter = null, EnumRoom.BreadType breadType = EnumRoom.BreadType.White, EnumRoom.JugType jugType = EnumRoom.JugType.Tap)
        {
            switch (choice)
            {
                case "BringBread":
                    BringBread bringBread = (BringBread)this.mapActions["BringBread"];
                    bringBread.act(table, breadType);
                    break;
                case "BringJug":
                    BringJug bringJug = (BringJug)this.mapActions["BringJug"];
                    bringJug.act(table, jugType);
                    break;
                /* case "Serve":
                     //this.mapActions["Serve"].act();
                     break; */
                case "CleanTable":
                    CleanTable cleanTable = (CleanTable)this.mapActions["CleanTable"];
                    cleanTable.act(table, waiter);
                    break;
                default:
                    break;
            }
        }
    }
}
