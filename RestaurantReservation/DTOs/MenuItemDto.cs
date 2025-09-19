namespace RestaurantReservation.DTOs;

public record MenuItemDto(
    string Name, 
    int Quantity, 
    decimal Price);