namespace PetShop.Service.Interfaces
{
    public interface IBaseService<T> where T : class   
    {
        Task<T> Get(int id);
        IQueryable<T> GetAll();
        Task<T> Save(T entity);
        Task<T> Delete(int id);
        void Add(T entity);
    }
}
