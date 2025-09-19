using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.Services;

public class EmployeeService
{
    private readonly IRepository<Employee> _efEmployeeRepository;
    private readonly IRepository<Order> _efOrderRepository;
    public EmployeeService(IRepository<Employee> efEmployeeRepository, IRepository<Order> efOrderRepository)
    {
        _efEmployeeRepository = efEmployeeRepository;
        _efOrderRepository = efOrderRepository;
    }

    public async Task<List<Employee>> ListAllManagers()
    {
        return await _efEmployeeRepository.Entities()
            .Where(e => e.Position == "Manager")
            .ToListAsync();
    }

    public async Task<decimal> CalculateAverageOrderAmount(int employeeId)
    {
        return await _efOrderRepository.Entities()
            .Where(o => o.EmployeeId == employeeId)
            .AverageAsync(o => o.TotalAmount);
        
    }
}