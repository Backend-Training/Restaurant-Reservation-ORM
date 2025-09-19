// Calculate Average Order Amount

using RestaurantReservation.Db;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;
using RestaurantReservation.Services;

var context = new RestaurantReservationDbContext();
var repoOrder = new EfRepository<Order>(context);
var repoEmployee = new EfRepository<Employee>(context);
var employeeId = 3;

var employeeService = new EmployeeService(repoEmployee,repoOrder);
var orderAmount = await employeeService.CalculateAverageOrderAmount(employeeId);

Console.WriteLine(orderAmount);
