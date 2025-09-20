using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Views;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.Services;

public class ReservationDetailsService
{
     
    private readonly IRepository<ReservationDetail> _efReservationsDetailsRepository;

    public ReservationDetailsService(IRepository<ReservationDetail> efReservationsDetailsRepository)
    {
        _efReservationsDetailsRepository = efReservationsDetailsRepository;
    }

    public async Task<List<ReservationDetail>> QueryReservationDetails()
    {
        return await _efReservationsDetailsRepository.Entities().ToListAsync();
    }
}