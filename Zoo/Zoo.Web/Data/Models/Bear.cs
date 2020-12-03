using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Common;

namespace Zoo.Web.Data.Models
{
    public class Bear : Animal
    {
        public override string Information()
        {
            return $"{Constants.BearAnimalType} => Current health: {this.Health}/100 => Is alive: {this.IsAlive}";
        }
    }
}
