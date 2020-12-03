using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Data.Models;

namespace Zoo.Web.Data
{
    public class InMemoryZooDb
    {
        private ICollection<Animal> animals;

        public InMemoryZooDb()
        {
            this.animals = new List<Animal>();

            for (int i = 0; i < 10; i++)
            {
                var monkey = new Monkey();
                var gireffe = new Giraffe();
                var bear = new Bear();

                this.animals.Add(monkey);
                this.animals.Add(gireffe);
                this.animals.Add(bear);
            }
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return this.animals.OrderBy(a => a.GetType().Name);
        }

        public IEnumerable<Animal> GetMonkeys()
        {
            return this.animals.Where(a => a.GetType().Name == "Monkey").ToList();
        }

        public IEnumerable<Animal> GetGiraffes()
        {
            return this.animals.Where(a => a.GetType().Name == "Giraffe").ToList();
        }

        public IEnumerable<Animal> GetBears()
        {
            return this.animals.Where(a => a.GetType().Name == "Bear").ToList();
        }
    }
}
