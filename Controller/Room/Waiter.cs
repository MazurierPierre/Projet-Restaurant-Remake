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
            this.mapAct.Add("Serve", new Serve()); // Can serve the client
            this.mapAct.Add("CleanTable", new CleanTable()); // Can clean the table

            // But it can take also the clerk's role,
            this.mapAct.Add("BringBread", new BringBread()); // Can bring the bread
            this.mapAct.Add("BringJug", new BringJug()); // Can bring the Jug
        }

        public void Action(String choice, Table table, EnumRoom.BreadType breadType = EnumRoom.BreadType.White, EnumRoom.JugType jugType = EnumRoom.JugType.Tap)
        {
            switch (choice)
            {
                case "BringBread":
                    BringBread bringBread = (BringBread)this.mapAct["BringBread"];
                    bringBread.voidAct(table, breadType);
                    break;
                case "BringJug":
                    BringJug bringJug = (BringJug)this.mapAct["BringJug"];
                    bringJug.voidAct(table, jugType);
                    break;
                /* case "Serve":
                     //this.mapAct["Serve"].voidAct();
                     break; */
                case "CleanTable":
                    CleanTable cleanTable = (CleanTable)this.mapAct["CleanTable"];
                    cleanTable.voidAct(table);
                    break;
                default:
                    break;
            }
        }
    }
}

