using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    /// <summary>
    /// 站点类
    /// </summary>
    public class Site
    {
        /// <summary>
        /// 站点ID
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// 所在城市索引ID
        /// </summary>
        [Required]
        public long CityID { get; set; }

        /// <summary>
        /// 站点编码，三位编码为城市代码，最后一位城市所有站点的流水顺序号
        /// </summary>
        [Required]
        [MaxLength(6)]
        public string SiteCode { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string SiteName { get; set; }

        /// <summary>
        /// 站点所在地址
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// 站点所在地邮政编码
        /// </summary>
        [Required]
        public string PostCode { get; set; }

        /// <summary>
        /// 站点联系电话列表
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 站点联系手机列表
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 站点所在经度
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// 站点所在纬度
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// 站点创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 站点信息最后修改时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// 此站点是否在使用
        /// </summary>
        public bool InUse { get; set; }

        /// <summary>
        /// 备注信息1
        /// </summary>
        public string Remake1 { get; set; }

        /// <summary>
        /// 备注信息2
        /// </summary>
        public string Remake2 { get; set; }

        /// <summary>
        /// 备注信息3
        /// </summary>
        public string Remake3 { get; set; }
    }
}
