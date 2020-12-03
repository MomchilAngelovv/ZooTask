using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Common;
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
            var aliveAnimalsCount = this.GetDeadAnimalsCount();

            var animalsToFeed = this.db
                .GetAnimals()
                .Where(a => a.IsAlive)
                .OrderByDescending(a => a.Health)
                .Take((int)(Math.Floor((30 - aliveAnimalsCount) * 0.9)))
                .ToList();

            foreach (var animal in animalsToFeed)
            {
                animal.Feed();
            }
        }

        public int GetAliveAnimalsCount()
        {
            return this.db.GetAnimals().Count(a => a.IsAlive);
        }

        public int GetDeadAnimalsCount()
        {
            return this.db.GetAnimals().Count(a => !a.IsAlive);
        }

        public IEnumerable<Animal> GetAll()
        {
            return this.db.GetAnimals();
        }

        public void Hunger()
        {
            var animalHunterRate = new Random().Next(15, 35);

            foreach (var monkey in this.db.GetMonkeys())
            {
                monkey.Hunger(animalHunterRate);
            }

            animalHunterRate = new Random().Next(15, 35);

            foreach (var giraffe in this.db.GetGiraffes())
            {
                giraffe.Hunger(animalHunterRate);
            }

            animalHunterRate = new Random().Next(15, 35);

            foreach (var bear in this.db.GetBears())
            {
                bear.Hunger(animalHunterRate);
            }
        }

        public int GetMinHealthByAnimalType(string animalType)
        {
            var animalsFromType = animalType switch
            {
                Constants.MonkeyAnimalType => this.db.GetMonkeys(),
                Constants.GiraffeAnimalType => this.db.GetGiraffes(),
                Constants.BearAnimalType => this.db.GetBears(),
                _ => null
            };

            var animalWithMinimumHealth = animalsFromType
                .Where(a => a.IsAlive)
                .OrderBy(a => a.Health)
                .FirstOrDefault();

            if (animalWithMinimumHealth == null)
            {
                return 0;
            }

            return animalWithMinimumHealth.Health;
        }
    }
}
