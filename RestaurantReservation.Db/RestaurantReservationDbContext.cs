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
        
        modelBuilder.Entity<Table>().HasData(
            new Table { TableId = 1, RestaurantId = 1, Capacity = 4 },
            new Table { TableId = 2, RestaurantId = 2, Capacity = 6 },
            new Table { TableId = 3, RestaurantId = 3, Capacity = 2 },
            new Table { TableId = 4, RestaurantId = 4, Capacity = 4 },
            new Table { TableId = 5, RestaurantId = 5, Capacity = 8 }
        );
        
        modelBuilder.Entity<Customer>().HasData(
            new Customer { CustomerId = 1, FirstName = "Alice", LastName = "Smith", Email = "alice@example.com", PhoneNumber = "100-100-1000" },
            new Customer { CustomerId = 2, FirstName = "Bob", LastName = "Johnson", Email = "bob@example.com", PhoneNumber = "200-200-2000" },
            new Customer { CustomerId = 3, FirstName = "Charlie", LastName = "Brown", Email = "charlie@example.com", PhoneNumber = "300-300-3000" },
            new Customer { CustomerId = 4, FirstName = "Diana", LastName = "White", Email = "diana@example.com", PhoneNumber = "400-400-4000" },
            new Customer { CustomerId = 5, FirstName = "Ethan", LastName = "Green", Email = "ethan@example.com", PhoneNumber = "500-500-5000" }
        );

    }
}