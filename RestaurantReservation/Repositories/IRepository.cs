namespace RestaurantReservation.Repositories;

public interface IRepository<T>
{
    public void Create(T entity);
    public void Update(T entity);
    public void Delete(int id);
}