using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Map;

namespace Model.Room
{
    public class Row : Model.Map.IElements
    {
        public int number { get; set; }
        public List<Table> tableList { get; set; }

        public Row(int number, List<Table> tableList)
        {
            this.number = number;
            this.tableList = tableList;
        }
    }
}
