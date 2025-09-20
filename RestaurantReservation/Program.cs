// Query Reservation Details View

using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Db.Models.Views;
using RestaurantReservation.Repositories;
using RestaurantReservation.Services;

var context = new RestaurantReservationDbContext();
var repoReservationDetails = new EfRepository<ReservationDetail>(context);


var reservationDetailsService = new ReservationDetailsService(repoReservationDetails);
var reservations = await reservationDetailsService.QueryReservationDetails();

foreach(var reservation in reservations){
    // Print
    Console.WriteLine(reservation.CustomerEmail);
}
