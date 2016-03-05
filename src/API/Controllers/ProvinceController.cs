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
        [HttpGet("{id}",Name ="Province", Order = 1)]
        public IActionResult GetByID(long id)
        {
            Province pi = provinces.Find(id);
            if (pi == null && pi.InUse == false)
                return HttpNotFound();

            return new ObjectResult(pi);
        }

        /// <summary>
        /// 按照省份代码检索省份
        /// </summary>
        /// <param name="code">省份代码</param>
        /// <returns>省份对象</returns>
        /*
        [HttpGet("{code}")]
        public IActionResult GetByCode(string code)
        {
            Province pi = provinces.Find(code);
            if (pi == null && pi.InUse == false)
                return HttpNotFound();

            return new ObjectResult(pi);
        }
        /*
/// <summary>
/// 按照省份名称检索省份
/// </summary>
/// <param name="name">省份名称</param>
/// <returns>省份对象</returns>
[HttpGet("{name}"),ActionName("GetProvinceForName")]
public IActionResult GetByName(string name)
{
    Province pi = provinces.FindByName(name);

    if (pi == null && pi.InUse == false)
        return HttpNotFound();

    return new ObjectResult(pi);
}

/// <summary>
/// 添加省份
/// </summary>
/// <param name="newProvince"></param>
/// <returns></returns>
[HttpPost]
public IActionResult Create([FromBody]Province newProvince)
{
    if (newProvince == null)
        return HttpBadRequest();

    provinces.Add(newProvince);

    return CreatedAtRoute("GetProvince", new { Controller="Province", id=newProvince.ID}, newProvince);
}

// PUT api/values/5
[HttpPut("{id}")]
public void Put(int id, [FromBody]string value)
{
}

// DELETE api/values/5
[HttpDelete("{id}")]
public void Delete(int id)
{
}*/
    }
}
