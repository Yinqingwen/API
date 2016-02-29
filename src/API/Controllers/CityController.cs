using API.Models;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        /// <summary>
        /// 城市列表接口
        /// </summary>
        [FromServices]
        public ICityRepository Cityitems { get; set; }

        /// <summary>
        /// 获取全部城市列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<City> GetAll()
        {
            return Cityitems.GetAll();
        }

        /// <summary>
        /// 按照ID获取城市内容
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}",Name = "GetCity")]
        public IActionResult GetById(long id)
        {
            var item = Cityitems.Find(id);
            if (item == null)
                return HttpNotFound();
            return new ObjectResult(item);
        }

        /// <summary>
        /// 增加城市
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] City city)
        {
            if (city == null)
                return HttpBadRequest();
            Cityitems.Add(city);
            return CreatedAtRoute("GetCity",new { Controller = "City", id = city.ID}, city);
        }

        /// <summary>
        /// 更新城市信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] City city)
        {
            if (city == null || city.ID != id)
                return HttpBadRequest();
            var item = Cityitems.Find(id);
            if (item == null)
                return HttpNotFound();
            Cityitems.Update(city);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Cityitems.Remove(id);
            return new NoContentResult();
        }
    }
}
