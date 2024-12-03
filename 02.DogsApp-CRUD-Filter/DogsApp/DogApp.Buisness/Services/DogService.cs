using DogsApp.Buisness.Contracts;
using DogsApp.Infrastructure.Data;
using DogsApp.Infrastructure.Data.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsApp.Buisness.Services
{
    public class DogService: IDogService
    {
        private readonly ApplicationDbContext _context;

        public DogService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(string name, int age, string breed, string? picture)
        {
            Dog item = new Dog
            {
                Name = name,
                Age = age,
                Breed = breed,
                Picture = picture,
            };
            _context.Dogs.Add(item);
            return _context.SaveChanges() !=0;
        }
    }
}
