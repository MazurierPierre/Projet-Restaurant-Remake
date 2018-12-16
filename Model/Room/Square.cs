using System.Collections.Generic;

namespace Model.Room
{
    public class Square
    {
        public int number { get; set; }
        public List<Row> rowList { get; set; }

        public Square(int number, List<Row> rowList)
        {
            this.number = number;
            this.rowList = rowList;
        }
    }
}
