using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API.Models.province
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

        [Required]
        [MaxLength(6)]
        public string ProvinceCode { get; set; }

        public string ProvinceName { get; set; }
    }
}
