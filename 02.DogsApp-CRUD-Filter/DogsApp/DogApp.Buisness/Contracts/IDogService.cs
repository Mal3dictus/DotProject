using DogsApp.Infrastructure.Data.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsApp.Buisness.Contracts
{
    public interface IDogService
    {
        bool Create(string name, int age, string breed, string picture);
        bool UpdateDog(int dogId, string name, int age, string breed, string picture);
        bool DeleteDog(int dogId);
        List<Dog> GetDogs();
        Dog GetDogById(int dogId);
        List<Dog> GetDogs(string searchStringBreed, string searchStringName);



    }
}
