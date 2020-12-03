using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Common;

namespace Zoo.Web.Data.Models
{
    public class Monkey : Animal
    {
        public override void Hunger(int hungerRate)
        {
            if (this.IsAlive)
            {
                this.Health -= hungerRate;

                if (this.Health < Constants.MonkeyMinHealthValue)
                {
                    this.IsAlive = false;
                    this.Health = 0;
                }
            }
        }
    }
}
