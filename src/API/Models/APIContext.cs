using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace API.Models
{
    public class APIContext : DbContext
    {
        /// <summary>
        /// 城市数据表
        /// </summary>
        public DbSet<City> Citys { get; set; }

        /// <summary>
        /// 站点数据表
        /// </summary>
        public DbSet<Site> Sites { get; set; }

        /// <summary>
        /// 省份数据表
        /// </summary>
        public DbSet<Province> Provinces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=tcp:ar8upiuxoe.database.chinacloudapi.cn,1433;Database=LIMS;User ID=Yinqingwen@ar8upiuxoe;Password=Panda19690219;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
