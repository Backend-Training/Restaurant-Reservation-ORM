using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.Services;

public class CustomerService
{
    
    private readonly IRepository<Reservation> _efRepository;

    public CustomerService(IRepository<Reservation> efRepository)
    {
        _efRepository = efRepository;
    }

    public async Task<List<Reservation>> GetReservationsByCustomer(int customerId)
    {
        return await _efRepository
            .Entities()
            .Where(r => r.CustomerId == customerId)
            .ToListAsync();

    }
}