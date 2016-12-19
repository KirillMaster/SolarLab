
namespace DataAccessLayer.Models
{

    /// <summary>
    /// базовая модель для всех Entity
    /// </summary>
    /// <typeparam name="T">тип первичного ключа</typeparam>
   public abstract class BaseEntity<T>
    {
       public T Id { get; set; }

    }
}
