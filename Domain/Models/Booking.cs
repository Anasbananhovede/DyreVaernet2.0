using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Booking
    {
    public int Id { get; set; }
    public int AnimalId { get; set; }
    public string VisitorName { get; set; }
    public string Email { get; set; }
    public DateTime VisitDate { get; set; }
    }
}
