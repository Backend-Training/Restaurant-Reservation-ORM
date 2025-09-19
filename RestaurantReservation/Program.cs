// List Orders With Their Menu Items Related To Reservation

using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.Services;

var context = new RestaurantReservationDbContext();
var repo = new EfRepository<Order>(context);
var reservationId = 3;

var reservationService = new ReservationService(repo);
var orders = await reservationService.ListOrdersAndMenuItems(reservationId);

foreach (var orderDtos in orders)
{
    Console.WriteLine(orderDtos);
    foreach (var item in orderDtos.MenuItems)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("--------------------------------------------");
}
