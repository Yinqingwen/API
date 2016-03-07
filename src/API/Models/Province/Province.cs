using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    /// <summary>
    /// 省份数据库
    /// </summary>
    public class Province
    {
        /// <summary>
        /// 省份ID
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [Required]
        [MaxLength(3)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime LastUpdateDate { get; set; }

        /// <summary>
        /// 是否使用中
        /// </summary>
        public bool InUse { get; set; }

        /// <summary>
        /// 备注字段1
        /// </summary>
        public string ReMake1 { get; set; }

        /// <summary>
        /// 备注字段2
        /// </summary>
        public string ReMake2 { get; set; }

        /// <summary>
        /// 备注字段3
        /// </summary>
        public string ReMake3 { get; set; }
    }
}
