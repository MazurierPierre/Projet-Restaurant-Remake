using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Room
{
    public class BookingForm
    {
        public string name { get; set; }
        public Table table { get; set; }
        public DateTime hour { get; set; }

        public BookingForm(string name, Table table, DateTime hour)
        {
            this.name = name;
            this.table = table;
            this.hour = hour;
        }

        public void saveBookingForm(BookingForm bookingForm)
        {
            BookingList.bookingList.Add(bookingForm);
        }
    }
}
