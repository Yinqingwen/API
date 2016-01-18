using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CityRepository : ICityRepository
    {
        public APIContext apicontext { get; set; }

        public CityRepository()
        {
            apicontext = new APIContext();
        }

        public void Add(City city)
        {
            apicontext.Citys.Add(city);
            apicontext.SaveChanges();
        }

        public void Update(City city)
        {
            City ncity = Find(city.ID);
            if (ncity != null)
            {
                ncity.ID = city.ID;
                ncity.CityCode = city.CityCode;
                ncity.CityName = city.CityName;
                ncity.InUse = city.InUse;
                ncity.LastUpdateDate = DateTime.Now;
                ncity.Remark1 = city.Remark1;
                ncity.Remark2 = city.Remark2;
                ncity.Remark3 = city.Remark3;
                apicontext.SaveChanges();
            }
        }

        public IEnumerable<City> GetAll()
        {
            return apicontext.Citys.Where(item => item.InUse != false) .ToList();
        }

        public City Find(long id)
        {
            City city = apicontext.Citys.Where(b => b.ID == id).First();
            return city;
        }

        public void Remove(long id)
        {
            //获取城市对象
            City city = Find(id);
            if (city != null)
            {
                city.InUse = false;
                city.LastUpdateDate = DateTime.Now;
                apicontext.SaveChanges();
            }
        }
    }
}
