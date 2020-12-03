using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zoo.Web.Data;

namespace Zoo.Web.Tests
{
    public class InMemoryZooDbTests
    {
        [Fact]
        public void ShouldInitializeCollectionProperly()
        {
            var db = new InMemoryZooDb();

            var monkeys = db.GetAnimals().Where(a => a.GetType().Name == "Monkey");
            var giraffes = db.GetAnimals().Where(a => a.GetType().Name == "Giraffe");
            var bears = db.GetAnimals().Where(a => a.GetType().Name == "Bear");

            Assert.Equal(10, monkeys.Count());
            Assert.Equal(10, giraffes.Count());
            Assert.Equal(10, bears.Count());

            foreach (var animal in db.GetAnimals())
            {
                Assert.Equal(100, animal.Health);
            }
        }
    }
}
