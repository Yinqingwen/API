using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using API.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class SiteController : Controller
    {
        [FromServices]
        public ISiteRepository siteitems { get; set; }

        // GET: api/site
        [HttpGet]
        public IEnumerable<Site> GetAll()
        {
            return siteitems.GetAll();
        }

        // GET api/site/5
        [HttpGet("{id}", Name = "GetSite")]
        public IActionResult GetById(int id)
        {
            var item = siteitems.Find(id);
            if (item == null)
                return HttpNotFound(); 
            return new ObjectResult(item);
        }

        // POST api/site
        [HttpPost]
        public IActionResult Create([FromBody]Site site)
        {
            if (site == null)
                return HttpBadRequest();
            siteitems.Add(site);
            return CreatedAtRoute("GetSite",new { Controller="site",id = site.ID},site);
        }

        // PUT api/site/5
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody]Site site)
        {
            if (site == null || site.ID != id)
                return HttpBadRequest();
            var item = siteitems.Find(id);
            if (item == null)
                return HttpNotFound();
            siteitems.Update(site);
            return new NoContentResult();
        }

        // DELETE api/site/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            siteitems.Remove(id);
            return new NoContentResult();
        }
    }
}
