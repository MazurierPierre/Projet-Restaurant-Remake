using System;
using System.Collections.Generic;
using Model.Room.Element;


namespace Model.Room
{
    public class Table
    {
        public int chairAmount { get; set; }
        public int tableNumber { get; set; }
        public string state { get; set; }
        public Boolean isReserved { get; set; }
        public List<Bread> breadList { get; set; }
        public List<Jug> jugList { get; set; }
        public List<Plate> plateList { get; set; }
        public Tablecloth tablecloth { get; set; }
        public List<Napkin> napkinList { get; set; }
        public List<Glass> glassList { get; set; }
        public List<Card> cardList { get; set; }
        public Table(int chairAmount, int tableNumber, string state, bool isReserved, List<Bread> breadList = null, List<Jug> jugList = null, List<Plate> plateList = null, Tablecloth tablecloth = null, List<Napkin> napkinList = null, List<Glass> glassList = null, List<Card> cardList = null)
        {
            this.chairAmount = chairAmount;
            this.tableNumber = tableNumber;
            this.state = state;
            this.isReserved = isReserved;
            this.breadList = breadList;
            this.jugList = jugList;
            this.plateList = plateList;
            this.tablecloth = tablecloth;
            this.napkinList = napkinList;
            this.glassList = glassList;
            this.cardList = cardList;
        }

    }
}
