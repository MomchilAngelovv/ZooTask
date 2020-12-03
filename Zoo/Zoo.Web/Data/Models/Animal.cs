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
            Health = Constants.MaxAnimalHealthValue;
            IsAlive = true;
        }

        public void Feed()
        {
            //MaxValue value in Random.Next() is EXCLUDING so this is why I put Constants.FeedMaxValue + 1
            var randomHealthValue = new Random().Next(Constants.FeedMinValue, Constants.FeedMaxValue + 1);

            this.Health += randomHealthValue;

            if (this.Health > Constants.MaxAnimalHealthValue)
            {
                this.Health = Constants.MaxAnimalHealthValue;
            }
        }

        public abstract void Hunger(int hungerRate);
        public string Information()
        {
            return $"{this.GetType().Name} => Current health: {this.Health}/{Constants.MaxAnimalHealthValue} => Is alive: {this.IsAlive}";
        }
    }
}
