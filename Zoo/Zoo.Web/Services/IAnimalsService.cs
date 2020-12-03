using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.Web.Data.Models;

namespace Zoo.Web.Services
{
    public interface IAnimalsService
    {
        void FeedAnimals();
        IEnumerable<Animal> GetAll();
        int GetAliveAnimalsCount();
    }
}
