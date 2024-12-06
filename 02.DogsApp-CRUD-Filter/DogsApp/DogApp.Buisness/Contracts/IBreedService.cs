using DogsApp.Infrastructure.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsApp.Buisness.Contracts
{
    public interface IBreedService
    {
        List<Breed> GetBreeds();
        Breed GetBreedById(int breedid);
        List<Dog> GetDogByBreed(int breedId);
    }
}
