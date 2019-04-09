using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities.Models
{
    public interface IRepository
    {
        IEnumerable<City> Cities { get;}
        void AddCity(City newCity);
    }
    public class MemoryCityRepository : IRepository
    {

        private List<City> _cities = new List<City>
        {
            new City {Name="北京",Country="中国",Population=18900000},
            new City {Name="广州",Country="中国",Population=15900000},
            new City {Name="上海",Country="中国",Population=14500000},
            new City {Name="武汉",Country="中国",Population=56000000}
        };

        public IEnumerable<City> Cities => _cities;

        public void AddCity(City newCity)
        {
            _cities.Add(newCity);
        }
    }
}
