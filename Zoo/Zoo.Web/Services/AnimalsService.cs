using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Data;
using Zoo.Web.Data.Models;

namespace Zoo.Web.Services
{
    public class AnimalsService : IAnimalsService
    {
        private readonly InMemoryZooDb db;

        public AnimalsService(InMemoryZooDb db)
        {
            this.db = db;
        }

        public void FeedAnimals()
        {
            foreach (var animal in this.db.GetAnimals())
            {
                animal.Feed();
            }
        }

        public IEnumerable<Animal> GetAll()
        {
            return this.db.GetAnimals();
        }
    }
}
