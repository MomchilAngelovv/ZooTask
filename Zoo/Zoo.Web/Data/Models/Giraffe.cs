using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Common;

namespace Zoo.Web.Data.Models
{
    public class Giraffe : Animal
    {
        public override string Information()
        {
            return $"{Constants.GiraffeAnimalType} => Current health: {this.Health}/100 => Is alive: {this.IsAlive}";
        }
    }
}
