using System;
using System.Linq;
using Xunit;
using Zoo.Web.Data;
using Zoo.Web.Services;

namespace Zoo.Web.Tests
{
    public class AnimalsServiceTests
    {
        [Fact]
        public void GetAllShouldReturnAllAnimalsFromCollection()
        {
            var db = new InMemoryZooDb();
            var service = new AnimalsService(db);

            var allAnmals = service.GetAll().ToList();
            Assert.Equal(30, allAnmals.Count);
        }

        [Fact]
        public void GetMinHealthByAnimalTypeShouldPropelryReturnMinHealthValue()
        {
            var db = new InMemoryZooDb();
            var service = new AnimalsService(db);

            var bear = db.GetAnimals().First(a => a.GetType().Name == "Bear");
            bear.Health = 65;
            var bearMinHealth = service.GetMinHealthByAnimalType("Bear");
            Assert.Equal(65, bearMinHealth);
        }

        [Fact]
        public void GetAliveAnimalsCountShouldPropelryReturnCorrectValue()
        {
            var db = new InMemoryZooDb();
            var service = new AnimalsService(db);

            var bear = db.GetAnimals().First();
            bear.IsAlive = false;
            var aliveAnimalsCount = service.GetAliveAnimalsCount();
            Assert.Equal(29, aliveAnimalsCount);
        }

        [Fact]
        public void GetDeadAnimalsCountShouldPropelryReturnCorrectValue()
        {
            var db = new InMemoryZooDb();
            var service = new AnimalsService(db);

            var bear = db.GetAnimals().First();
            bear.IsAlive = false;
            var deadAnimalsCount = service.GetDeadAnimalsCount();
            Assert.Equal(1, deadAnimalsCount);
        }
    }
}
