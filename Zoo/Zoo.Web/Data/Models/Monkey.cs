using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Common;

namespace Zoo.Web.Data.Models
{
    public class Monkey : Animal
    {
        public override string Information()
        {
            return $"{Constants.MonkeyAnimalType} => Current health: {this.Health}/100 => Is alive: {this.IsAlive}";
        }
    }
}
