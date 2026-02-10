using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSnap.Domain.Entities;

namespace TicketSnap.Domain.Repositories
{
    public interface ISeatRepository
    {
        Task<Seat> GetSeatByIdAsync(int seatId);
        Task<IEnumerable<Seat>> GetAllAsync(int eventId);
        Task UpdateSeatAsync(Seat seat);
        Task<bool> TryLockSeatAsync(int seatId, Guid userId, DateTime expiration);

    }
}
