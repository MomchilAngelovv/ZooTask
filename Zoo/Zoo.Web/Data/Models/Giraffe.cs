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
            if (this.IsAlive && this.Health < Constants.GiraffeMinHealthValue)
            {
                this.IsAlive = false;
                this.Health = 0;
            }

            this.Health = Math.Max(0, this.Health - hungerRate);
        }
    }
}
