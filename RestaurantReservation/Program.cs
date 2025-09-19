// List reservations by customer id

using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.Services;

var context = new RestaurantReservationDbContext();
var repo = new EfRepository<Reservation>(context);
var customerId = 3;

var customerService = new CustomerService(repo);
var reservations = await customerService.GetReservationsByCustomer(customerId);

foreach (var reservation in reservations)
{
    Console.WriteLine(reservation.PartySize);
}
