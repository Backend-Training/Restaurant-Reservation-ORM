// List All Managers Demo

using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.Services;

var context = new RestaurantReservationDbContext();
var repo = new EfRepository<Employee>(context);

var employeeService = new EmployeeService(repo);
var listAllManagers = await employeeService.ListAllManagers();
foreach (var manager in listAllManagers)
{
    Console.WriteLine(manager.FirstName);
}