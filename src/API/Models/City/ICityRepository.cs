using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public interface ICityRepository
    {
        /// <summary>
        /// 增加一个城市
        /// </summary>
        /// <param name="city">城市实体数据类</param>
        void Add(City city);

        /// <summary>
        /// 获取全部城市列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<City> GetAll();

        /// <summary>
        /// 获得单个城市信息
        /// </summary>
        /// <param name="id">城市索引码</param>
        /// <returns></returns>
        City Find(long id);

        /// <summary>
        /// 删除一个城市，并非实际删除，而是在数据库中停用
        /// </summary>
        /// <param name="cityname">城市名称</param>
        /// <returns></returns>
        void Remove(long id);

        /// <summary>
        /// 更新城市信息
        /// </summary>
        /// <param name="city"></param>
        void Update(City city);
    }
}
