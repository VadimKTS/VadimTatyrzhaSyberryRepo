namespace PasswordGenerator.Data.Repositiries.Interfaces
{
    public interface IRepositoryService<T>
    {        
        Task<IList<T>> GetAllAsync();   // or IEnumerable
    }
}
