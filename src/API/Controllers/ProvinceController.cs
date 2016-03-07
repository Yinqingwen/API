using API.Models;
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ProvinceController : Controller
    {
        /// <summary>
        /// 省份接口列表
        /// </summary>
        [FromServices]
        public IProvinceRepository provinces { get; set; }


        /// <summary>
        /// 获取全部省份列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Province> GetAll()
        {
            return provinces.GetAll();
        }

        /// <summary>
        /// 按照ID检索省份
        /// </summary>
        /// <param name="id">省份ID</param>
        /// <returns>省份对象</returns>
        [HttpGet("{id}")]
        public IActionResult GetByID(long id)
        {
            Province pi = provinces.Find(id);
            if (pi == null)
                return HttpNotFound();
            else if (pi.InUse == false)
                return HttpNotFound();

            return new ObjectResult(pi);
        }

        /// <summary>
        /// 按照省份代码检索省份
        /// </summary>
        /// <param name="code">省份代码</param>
        /// <returns>省份对象</returns>
        [HttpGet("code/{code}")]
        public IActionResult GetByCode(string code)
        {
            Province pi = provinces.Find(code);
            if (pi == null)
                return HttpNotFound();
            else if (pi.InUse == false)
                return HttpNotFound();

            return new ObjectResult(pi);
        }

        /// <summary>
        /// 按照省份名称检索省份
        /// </summary>
        /// <param name="name">省份名称</param>
        /// <returns>省份对象</returns>
        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            Province pi = provinces.FindByName(name);

            if (pi == null)
                return HttpNotFound();
            else if (pi.InUse == false)
                return HttpNotFound();

            return new ObjectResult(pi);
        }

        /// <summary>
        /// 添加省份
        /// </summary>
        /// <param name="newProvince">省份对象</param>
        /// <returns>添加完的省份对象</returns>
        [HttpPost]
        public IActionResult Create([FromBody] Province newProvince)
        {
            if (newProvince == null)
                return HttpBadRequest();

            provinces.Add(newProvince);

            return CreatedAtRoute("GetProvince", new { Controller = "Province", id = newProvince.ID }, newProvince);
        }

        /// <summary>
        /// 更新省份
        /// </summary>
        /// <param name="id">省份对象ID</param>
        /// <param name="province">省份对象</param>
        /// <returns>暂时未定</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Province province)
        {
            if (province == null || province.ID != id)
                return HttpBadRequest();

            Province oldprovince = provinces.Find(id);
            if (oldprovince == null)
                return HttpNotFound();

            provinces.Update(province);
            return new NoContentResult();
        }

        /// <summary>
        /// 删除省份
        /// </summary>
        /// <param name="id">省份对象ID</param>
        /// <returns>暂时未定刘振通是个大SB</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            provinces.Remove(id);

            return new NoContentResult();
        }
    }
}
