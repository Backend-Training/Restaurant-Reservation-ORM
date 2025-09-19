using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.Services;

public class CustomerService
{
    
    private readonly IRepository<Reservation> _efReservationsRepository;

    public CustomerService(IRepository<Reservation> efRepository)
    {
        _efReservationsRepository = efRepository;
    }

    public async Task<List<Reservation>> GetReservationsByCustomer(int customerId)
    {
        return await _efReservationsRepository
            .Entities()
            .Where(r => r.CustomerId == customerId)
            .ToListAsync();

    }
}