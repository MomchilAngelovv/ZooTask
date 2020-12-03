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

            for (int i = 0; i < 9; i++)
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
    }
}
