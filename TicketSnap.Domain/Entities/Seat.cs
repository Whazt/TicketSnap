using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSnap.Domain.Enums;

namespace TicketSnap.Domain.Entities
{
    public class Seat
    {
        public int Id { get; set; }
        public string Row { get; set; } = string.Empty;
        public int Number { get; set; }
        public decimal Price { get; set; }
        public DateTime? LockedUntil { get; set; }
        public Guid? ReservedByUser { get; set; }
        public SeatStatus Status { get; set; } = SeatStatus.Available;
    }
}
