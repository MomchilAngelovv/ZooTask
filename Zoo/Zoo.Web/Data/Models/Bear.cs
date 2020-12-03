using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Common;

namespace Zoo.Web.Data.Models
{
    public class Bear : Animal
    {
        public override void Hunger(int hungerRate)
        {
            if (this.IsAlive)
            {
                this.Health = Math.Max(0, this.Health - hungerRate);

                if (this.Health < 60)
                {
                    this.IsAlive = false;
                }
            }
        }

        public override string Information()
        {
            return $"{Constants.BearAnimalType} => Current health: {this.Health}/100 => Is alive: {this.IsAlive}";
        }
    }
}
