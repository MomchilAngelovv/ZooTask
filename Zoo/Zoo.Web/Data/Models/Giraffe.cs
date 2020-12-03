using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Common;

namespace Zoo.Web.Data.Models
{
    public class Giraffe : Animal
    {
        public override void Hunger(int hungerRate)
        {
            if (this.IsAlive)
            {
                if (this.Health < Constants.GiraffeMinHealthValue)
                {
                    this.IsAlive = false;
                }

                this.Health = Math.Max(0, this.Health - hungerRate);
            }
        }

        public override string Information()
        {
            return $"{Constants.GiraffeAnimalType} => Current health: {this.Health}/100 => Is alive: {this.IsAlive}";
        }
    }
}
