using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Models
{
    public class ProvinceRepository : IProvinceRepository
    {
        /// <summary>
        /// 数据上下文对象
        /// </summary>
        public APIContext apicontext { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public ProvinceRepository()
        {
            apicontext = new APIContext();
        }

        /// <summary>
        /// 添加省份
        /// </summary>
        /// <param name="province">省份对象</param>
        public void Add(Province province)
        {   
            //将创建时间设为当前时间
            province.CreateDate = DateTime.Now;
            //将最后修改时间设为当前时间
            province.LastUpdateDate = DateTime.Now;
            //将使用状态设为TRUE
            province.InUse = true;

            //数据库表中增加记录
            apicontext.Provinces.Add(province);
            //数据库保存
            apicontext.SaveChanges();
        }

        /// <summary>
        /// 按照省份Code查找省份
        /// </summary>
        /// <param name="code">省份代码</param>
        /// <returns>省份对象</returns>
        public Province Find(string code)
        {
            Province province = apicontext.Provinces.Where(item => item.ProvinceCode == code).Where(item => item.InUse == true).FirstOrDefault();
            return province;
        }

        /// <summary>
        /// 按照省份ID查找省份
        /// </summary>
        /// <param name="id">省份ID</param>
        /// <returns>省份对象</returns>
        public Province Find(long id)
        {
            Province province = apicontext.Provinces.Where(item => item.ID == id).Where(item => item.InUse == true).FirstOrDefault();
            return province;
        }

        /// <summary>
        /// 按照省份名字查找省份
        /// </summary>
        /// <param name="name">省份名称</param>
        /// <returns>省份对象</returns>
        public Province FindByName(string name)
        {
            Province province = apicontext.Provinces.Where(item => item.ProvinceName == name).Where(item => item.InUse == true).FirstOrDefault();
            return province;
        }

        /// <summary>
        /// 获取全部省份列表
        /// </summary>
        /// <returns>省份列表</returns>
        public IEnumerable<Province> GetAll()
        {
            return apicontext.Provinces.Where(item => item.InUse == true).ToList();
        }

        /// <summary>
        /// 删除省份
        /// </summary>
        /// <param name="id">省份ID</param>
        public void Remove(long id)
        {
            Province province = Find(id);
            if (province != null)
            {
                province.InUse = false;
                province.LastUpdateDate = DateTime.Now;
                apicontext.SaveChanges();
            }
        }

        /// <summary>
        /// 更新省份
        /// </summary>
        /// <param name="id">省份ID</param>
        public void Update(Province province)
        {
            Province oldProvince = Find(province.ID);
            if (oldProvince != null)
            {
                //ID
                oldProvince.ID = province.ID;
                //省份code
                oldProvince.ProvinceCode = province.ProvinceCode;
                //省份名称
                oldProvince.ProvinceName = province.ProvinceName;
                //备注字段
                oldProvince.ReMake1 = province.ReMake1;
                oldProvince.ReMake2 = province.ReMake2;
                oldProvince.ReMake3 = province.ReMake3;
                //最后修改时间
                oldProvince.LastUpdateDate = DateTime.Now;
                apicontext.SaveChanges();
            }
        }
    }
}
