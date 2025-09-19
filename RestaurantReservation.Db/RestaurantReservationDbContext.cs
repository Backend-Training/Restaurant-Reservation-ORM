using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Models;

namespace RestaurantReservation.Db;

public class RestaurantReservationDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Table> Tables { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=DESKTOP-7N1E1DT;Database=RestaurantReservationCore;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurant>().HasData(
            new Restaurant { RestaurantId = 1, Name = "Sunrise Diner", Address = "123 Main St", PhoneNumber = "111-111-1111", OpeningHours = "08:00-22:00" },
            new Restaurant { RestaurantId = 2, Name = "Ocean Grill", Address = "456 Ocean Ave", PhoneNumber = "222-222-2222", OpeningHours = "10:00-23:00" },
            new Restaurant { RestaurantId = 3, Name = "Mountain Cafe", Address = "789 Hill Rd", PhoneNumber = "333-333-3333", OpeningHours = "07:00-21:00" },
            new Restaurant { RestaurantId = 4, Name = "City Bistro", Address = "321 Center St", PhoneNumber = "444-444-4444", OpeningHours = "09:00-22:00" },
            new Restaurant { RestaurantId = 5, Name = "Garden Eatery", Address = "654 Park Ln", PhoneNumber = "555-555-5555", OpeningHours = "08:00-20:00" }
        );
    }
}