using DyreVaernet2._0.IRepo;
using DyreVaernet2._0.Model;

namespace DyreVaernet2._0.Service
{
    public class BookingService
    {
        private IBookingRepo _bookingRepo;

        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }
        public List<Booking> GetAll()
        {
            return _bookingRepo.GetAll();
        }
        public Booking GetByID(int id)
        {
            return _bookingRepo.GetByID(id);
        }
        public void CreateBooking(Booking booking)
        {
            _bookingRepo.CreateBooking(booking);
        }
        public void RemoveBooking(int id)
        {
            _bookingRepo.RemoveBooking(id);
        }
        public void UpdateBooking(int id, string[] time, string comment)
        {
            _bookingRepo.UpdateBooking(id, time, comment);
        }



    }
}
