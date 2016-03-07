using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    /// <summary>
    /// 城市数据库 City DataBase
    /// </summary>
    public class City
    {
        /// <summary>
        /// ID
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// 省份代码，国标为3位，按照国家统计局标准制定，http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/
        /// </summary>
        [Required]
        [MaxLength(3)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 城市代码，加站点编号为运单编号的前三位，字符类型
        /// </summary>
        [Required]
        [MaxLength(6)]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称，字符类型
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string CityName { get; set; }

        /// <summary>
        /// 数据创建时间，DataTime类型
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 数据最后修改时间,DateTime类型
        /// </summary>
        public DateTime LastUpdateDate { get; set; }

        /// <summary>
        /// 该数据项是否在用
        /// </summary>
        public bool InUse { get; set; }

        /// <summary>
        /// 备注字段1
        /// </summary>
        public string Remark1 { get; set; }

        /// <summary>
        /// 备注字段2
        /// </summary>
        public string Remark2 { get; set; }

        /// <summary>
        /// 备注字段3
        /// </summary>
        public string Remark3 { get; set; }
    }
}
