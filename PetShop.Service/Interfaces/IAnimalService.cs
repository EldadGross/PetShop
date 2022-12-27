using PetShop.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Service.Interfaces
{
    public interface IAnimalService <T> : IBaseService<T> where T : class
    {
        Task<IEnumerable<T>> GetTwoPopulareAnimals();
        Task<IEnumerable<T>> GetAnimalsCategory(int id);
    }
}
