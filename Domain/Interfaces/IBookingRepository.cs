using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    // Interface der definerer metoder til håndtering af booking
    public interface IBookingRepository
    {
        // Henter alle bookingerne fra systemet
        List<Booking> GetAll();

        //Tilføjer en ny booking til systemet
        void Add(Booking booking);
    }
}
