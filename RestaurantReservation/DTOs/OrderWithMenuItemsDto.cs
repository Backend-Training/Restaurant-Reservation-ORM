namespace RestaurantReservation.DTOs;

public class OrderWithMenuItemsDto
{
    public int OrderId { get; set; }
    public List<MenuItemDto> MenuItems { get; set; }
}