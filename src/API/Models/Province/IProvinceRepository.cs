using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public interface IProvinceRepository
    {
        /// <summary>
        /// 添加省份
        /// </summary>
        /// <param name="province">省份对象</param>
        void Add(Province province);

        /// <summary>
        /// 获取全部省份
        /// </summary>
        /// <returns>省份列表</returns>
        IEnumerable<Province> GetAll();

        /// <summary>
        /// 通过ID检索省份
        /// </summary>
        /// <param name="ID">省份ID</param>
        /// <returns>省份对象</returns>
        Province Find(long id);

        /// <summary>
        /// 通过省份Code检索shengf
        /// </summary>
        /// <param name="code">省份Code</param>
        /// <returns>省份对象</returns>
        Province Find(string code);

        /// <summary>
        /// 通过省份名称检索省份
        /// </summary>
        /// <param name="name">省份名称</param>
        /// <returns>省份对象</returns>
        Province FindByName(string name);

        /// <summary>
        /// 删除省份
        /// </summary>
        /// <param name="id">省份ID</param>
        void Remove(long id);

        /// <summary>
        /// 更新省份
        /// </summary>
        /// <param name="id">省份对象</param>
        void Update(Province province);
    }
}
