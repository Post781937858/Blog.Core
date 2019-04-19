using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EFMigrations.interfaceBase
{
    public interface IDataBase<T> where T : class
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        void Add(T model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        void delete(T model);

        /// <summary>
        /// 条件查询加排序
        /// </summary>
        /// <param name="exp"></param>
        /// <param name="orderby"></param>
        IQueryable<T> Find(Expression<Func<T, bool>> exp = null, string orderby = "");

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        IQueryable<T> Filter(Expression<Func<T, bool>> exp = null);

        /// <summary>
        /// 分页查询排序
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="orderby"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        IQueryable<T> Find(int pageindex, int pagesize, string orderby = "", Expression<Func<T, bool>> exp = null);

        /// <summary>
        /// 分页总数
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        int PageCounts(int pagesize);
        
    }
}
