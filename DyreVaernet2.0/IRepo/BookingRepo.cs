using DyreVaernet2._0.Model;

namespace DyreVaernet2._0.IRepo
{
    public class BookingRepo : IBookingRepo
    {
        List<Booking> _bookings = new List<Booking>();
        public BookingCollectionRepo()
        {
           
        }

        public List<Booking> GetAll()
        {
            return _bookings;
        }

        public Booking GetByID(int id)
        {
            foreach (Booking booking in _bookings)
            {
                if (booking.BookingID == id)
                {
                    return booking;
                }
            }
            return null;
        }
        public void CreateBooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        public void RemoveBooking(int id)
        {
            _bookings.RemoveAll(booking => booking.BookingID == id);
        }

        public void UpdateBooking(int id, string[] time, string comment)
        {
            foreach (Booking booking in _bookings)
            {
                if (booking.BookingID == id)
                {
                    booking.Time = time;
                    booking.Comment = comment;
                }
            }
        }


    }
}
