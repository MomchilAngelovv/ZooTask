using System;
using Zoo.Web.Common;

namespace Zoo.Web.Data.Models
{
    public abstract class Animal
    {
        public int Health { get; set; }
        public bool IsAlive { get; set; }

        public Animal()
        {
            Health = Constants.InitialAnimalHealthValue;
            IsAlive = true;
        }

        public void Feed()
        {
            var randomHealthValue = new Random().Next(10, 25);

            this.Health += randomHealthValue;

            if (this.Health > 100)
            {
                this.Health = 100;
            }
        }

        public abstract string Information();
    }
}
