using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class SiteRepository : ISiteRepository
    {
        public APIContext apicontext { get; set; }

        public SiteRepository()
        {
            apicontext = new APIContext();
        }

        public void Add(Site site)
        {
            apicontext.Sites.Add(site);
            apicontext.SaveChanges();
        }

        public IEnumerable<Site> GetAll()
        {
            return apicontext.Sites.Where(Item => Item.InUse == true).ToList();
        }

        public Site Find(long id)
        {
            Site site = apicontext.Sites.Where(item => item.ID == id).Where(item => item.InUse == true).FirstOrDefault();
            return site;
        }

        public void Remove(long id)
        {
            Site site = Find(id);
            if (site != null)
            {
                site.InUse = false;
                site.LastUpdateTime = DateTime.Now;
                apicontext.SaveChanges();
            }
        }

        public void Update(Site newsite)
        {
            Site site = Find(newsite.ID);
            if (site != null)
            {
                site.ID = newsite.ID;
                site.CityID = newsite.CityID;
                site.Address = newsite.Address;
                site.Latitude = newsite.Latitude;
                site.Longitude = newsite.Longitude;
                site.MobileNumber = newsite.MobileNumber;
                site.PhoneNumber = newsite.PhoneNumber;
                site.PostCode = newsite.PostCode;
                site.SiteCode = newsite.SiteCode;
                site.SiteName = newsite.SiteName;
                site.Remake1 = newsite.Remake1;
                site.Remake2 = newsite.Remake2;
                site.Remake3 = newsite.Remake3;
                site.CreateTime = newsite.CreateTime;
                site.InUse = true;
                site.LastUpdateTime = DateTime.Now;
                apicontext.SaveChanges();
            }
        }
    }
}
