using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;
using RestaurantReservation.Repositories;

namespace RestaurantReservation.Services;

public class EmployeeService
{
    private readonly IRepository<Employee> _efRepository;

    public EmployeeService(IRepository<Employee> efRepository)
    {
        _efRepository = efRepository;
    }

    public async Task<List<Employee>> ListAllManagers()
    {
        return await _efRepository.Entities()
            .Where(e => e.Position == "Manager")
            .ToListAsync();
    }
}