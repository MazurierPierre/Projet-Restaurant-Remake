using System.Collections.Generic;
using Model.Room.Element;

namespace Model.Room
{
    public class InitRoomModel
    {
        private static InitRoomModel instance = null;
        private static readonly object padLock = new object();
        private InitRoomModel()
        {
            Init();
        }

        public static InitRoomModel Instance
        {
            get{
                lock (padLock)
                {
                    if (Instance == null)
                        instance = new InitRoomModel();
                    return instance;
                } 
            }
        }


        //Create Lists :
        public List<Table> tableList { get; set; } = new List<Table>{};
        public List<Square> squareList { get; set; } = new List<Square>{};
        public List<Row> rowList { get; set; } = new List<Row>{};
        public List<Room> roomList { get; set; } = new List<Room>{};
        public List<PaymentTerminal> paymentTerminalsList { get; set; } = new List<PaymentTerminal>{};
        public List<Order> orderList { get; set; } = new List<Order>{};
        public List<Drink> drinkList { get; set; } = new List<Drink>{};
        public List<Card> cardList { get; set; } = new List<Card>{};
        public static List<BookingForm> bookingList { get; set; } = new List<BookingForm>();
        public List<Tablecloth> tableclothList { get; set; } = new List<Tablecloth>{};

        // List of differents type of plates
        public List<Plate> smallPlateList { get; set; } = new List<Plate>{};
        public List<Plate> flatPlateList { get; set; } = new List<Plate>{};
        public List<Plate> dessertPlateList { get; set; } = new List<Plate>{};
        public List<Plate> soupPlateList { get; set; } = new List<Plate>{};


        public List<Napkin> napkinList { get; set; } = new List<Napkin>{};
        public List<Jug> jugList { get; set; } = new List<Jug>{};

        // List of differents type of glass 
        public List<Glass> waterGlassList { get; set; } = new List<Glass>{};
        public List<Glass> wineGlassList { get; set; } = new List<Glass>{};
        public List<Glass> fluteGlassList { get; set; } = new List<Glass>{};

        public List<Bread> breadList { get; set; } = new List<Bread>{};



        public void Init()
        {
            //Initialize Elements
            InitBread();
            InitGlass();
            InitJug();
            InitNapkin();
            InitPlate();
            InitTablecloth();

            //Initialize objects
            InitDrink();
            InitCard();
            InitPaymentTerminal();
            InitRoom();

        }

        public void InitBread(){
            for(int i = 0; i <= 40; i++){
                Bread bread = new Bread(EnumRoom.BreadType.White, EnumRoom.MaterialState.OK);
                breadList.Add(bread);
            }
        }
        public void InitGlass(){
            for(int i = 0; i <= 150; i++){
                Glass waterGlass = new Glass(EnumRoom.GlassType.Water, EnumRoom.MaterialState.OK);
                waterGlassList.Add(waterGlass);
            }
            for(int i = 0; i <= 150; i++){
                Glass wineGlass = new Glass(EnumRoom.GlassType.Wine, EnumRoom.MaterialState.OK);
                wineGlassList.Add(wineGlass);
            }
            for(int i = 0; i <= 150; i++){
                Glass fluteGlass = new Glass(EnumRoom.GlassType.Flute, EnumRoom.MaterialState.OK);
                fluteGlassList.Add(fluteGlass);
            }
        }

   
        public void InitJug(){
            for(int i = 0; i <= 40; i++){
                Jug jug = new Jug(EnumRoom.JugType.Tap, EnumRoom.MaterialState.OK);
                jugList.Add(jug);
            }
        }
        public void InitNapkin(){
            for(int i = 0; i <= 40; i++){
                Napkin napkin = new Napkin(EnumRoom.NapkinType.Napkin, EnumRoom.MaterialState.OK);
                napkinList.Add(napkin);
            }
        }
        public void InitPlate(){
            for(int i = 0; i <= 150; i++){
                Plate smallPlate = new Plate(EnumRoom.PlateType.Small, EnumRoom.MaterialState.OK);
                smallPlateList.Add(smallPlate);
            }
            for(int i = 0; i <= 150; i++){
                Plate flatPlate = new Plate(EnumRoom.PlateType.Flat, EnumRoom.MaterialState.OK);
                flatPlateList.Add(flatPlate);
            }
            for(int i = 0; i <= 150; i++){
                Plate dessertPlate = new Plate(EnumRoom.PlateType.Dessert, EnumRoom.MaterialState.OK);
                dessertPlateList.Add(dessertPlate);
            }
            for(int i = 0; i <= 30; i++){
                Plate soupPlate = new Plate(EnumRoom.PlateType.Soup, EnumRoom.MaterialState.OK);
                soupPlateList.Add(soupPlate);
            }
        }
        public void InitTablecloth(){
            for(int i = 0; i <= 40; i++){
                Tablecloth tablecloth = new Tablecloth(EnumRoom.TableclothType.Square, EnumRoom.MaterialState.OK);
                tableclothList.Add(tablecloth);
            }
        }
        public void InitDrink(){
            Drink coca = new Drink("coca", EnumRoom.DrinkType.Coca);
            Drink wine = new Drink("Wine", EnumRoom.DrinkType.Wine);
            drinkList.Add(coca);
            drinkList.Add(wine);
        }
        public void InitCard(){
            for(int i = 0; i <= 40; i++){
                //Card card = new Card(InitKitchen.menusList, drinkList);
                Card card = new Card(null, drinkList);
                cardList.Add(card);
            }
        }
        public void InitPaymentTerminal(){
            PaymentTerminal paymentTerminal1 = new PaymentTerminal(1, 0);
            PaymentTerminal paymentTerminal2 = new PaymentTerminal(2, 0);
            paymentTerminalsList.Add(paymentTerminal1);
            paymentTerminalsList.Add(paymentTerminal2);

        }
        public void InitRoom(){
            Table table1 = new Table(10, 1, "free", false);
            Table table2 = new Table(10, 2, "free", false);
            Table table3 = new Table(8, 3, "free", false);
            Table table4 = new Table(8, 4, "free", false);
            Table table5 = new Table(6, 5, "free", false);
            Table table6 = new Table(6, 6, "free", false);
            Table table7 = new Table(4, 7, "free", false);
            Table table8 = new Table(4, 8, "free", false);
            Table table9 = new Table(2, 9, "free", false);
            Table table10 = new Table(2, 10, "free", false);
            Table table11 = new Table(2, 10, "free", false);
            Table table12 = new Table(2, 10, "free", false);

            tableList.Add(table1);
            tableList.Add(table2);
            tableList.Add(table3);
            tableList.Add(table4);
            tableList.Add(table5);
            tableList.Add(table6);
            tableList.Add(table7);
            tableList.Add(table8);
            tableList.Add(table9);
            tableList.Add(table10);
            tableList.Add(table11);
            tableList.Add(table12);

            List<Table> tableInRow1 = new List<Table>{ table1, table2, table3 };
            List<Table> tableInRow2 = new List<Table> { table4, table5, table6 };
            List<Table> tableInRow3 = new List<Table>{ table7, table8,table9 };
            List<Table> tableInRow4 = new List<Table>{ table10, table11, table12 };

            Row row1 = new Row(1, tableInRow1);
            Row row2 = new Row(2, tableInRow2);
            Row row3 = new Row(3, tableInRow3);
            Row row4 = new Row(4, tableInRow4);

            rowList.Add(row1);
            rowList.Add(row2);
            rowList.Add(row3);
            rowList.Add(row4);

            List<Row> rowInSquare1 = new List<Row>{row1, row2};
            List<Row> rowInSquare2 = new List<Row>{row3, row4};
            Square square1 = new Square(1, rowInSquare1);
            Square square2 = new Square(2, rowInSquare2);

            squareList.Add(square1);
            squareList.Add(square2);

            Room room1 = new Room(1, squareList, paymentTerminalsList);
            roomList.Add(room1);
        }
    }
}
