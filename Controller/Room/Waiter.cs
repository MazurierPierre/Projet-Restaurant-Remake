using System;
using Controller.Common;
using Model.Room;
using Model.Room.Element;

namespace Controller.Room
{
    public class Waiter : Common.Actor
    {
        public Square square { get; set; }
        public Communication communication = new Communication();
        public Waiter(string name, Square square) : base(name)
        {
            this.name = name;
            this.square = square;

            // This is the waiter's roles
            this.mapActions.Add("Serve", new Serve()); // Can serve the client
            this.mapActions.Add("CleanTable", new CleanTable()); // Can clean the table

            // But it can take also the clerk's role,
            this.mapActions.Add("BringBread", new BringBread()); // Can bring the bread
            this.mapActions.Add("BringJug", new BringJug()); // Can bring the Jug
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

