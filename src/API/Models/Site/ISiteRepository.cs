using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public interface ISiteRepository
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="site"></param>
        void Add(Site site);

        /// <summary>
        /// 获取全部站点
        /// </summary>
        /// <returns></returns>
        IEnumerable<Site> GetAll();

        /// <summary>
        /// 按照ID查找站点信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Site Find(long id);

        /// <summary>
        /// 按照ID删除站点信息
        /// </summary>
        /// <param name="id"></param>
        void Remove(long id);

        /// <summary>
        /// 按照ID修改站点信息
        /// </summary>
        /// <param name="id"></param>
        void Update(Site site);
    }
}
