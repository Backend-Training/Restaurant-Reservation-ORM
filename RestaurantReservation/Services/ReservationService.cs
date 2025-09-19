using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using RestaurantReservation.DTOs;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.Services;

public class ReservationService
{
    private readonly IRepository<Order> _efOrderRepository;

    public ReservationService(IRepository<Order> efRepository)
    {
        _efOrderRepository = efRepository;
    }
    
    public async Task<List<OrderWithMenuItemsDto>> ListOrdersAndMenuItems(int reservationId)
    {
        var orders = await _efOrderRepository.Entities()
            .Where(o => o.ReservationId == reservationId)
            .Include(o => o.OrderItems)
            .ThenInclude(oi => oi.MenuItem)
            .ToListAsync();

        var result = orders.Select(o => new OrderWithMenuItemsDto(
            o.OrderId,
            o.OrderItems.Select(oi => new MenuItemDto(
                oi.MenuItem.Name,
                oi.Quantity,
                oi.MenuItem.Price
            )).ToList()
        )).ToList();

        return result;
    }
    
    

}