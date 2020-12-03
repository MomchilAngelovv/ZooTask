using System.Collections.Generic;
using Zoo.Web.Data.Models;

namespace Zoo.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<Animal> Animals { get; set; }
    }
}
