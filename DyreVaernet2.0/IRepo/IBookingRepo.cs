using DyreVaernet2._0.Model;

namespace DyreVaernet2._0.IRepo
{
    public interface IBookingRepo
    {
       public List<Booking> GetAll();
        public Booking GetByID(int id);
        public void CreateBooking(Booking booking);
        public void RemoveBooking(int id);
        public void UpdateBooking(int id, string[] time, string comment);


    }
}
