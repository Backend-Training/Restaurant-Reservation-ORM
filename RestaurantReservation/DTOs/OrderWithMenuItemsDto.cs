namespace RestaurantReservation.DTOs;

public record OrderWithMenuItemsDto(
    int OrderId, 
    List<MenuItemDto> MenuItems);