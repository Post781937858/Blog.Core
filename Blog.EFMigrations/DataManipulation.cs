using Blog.EFMigrations.interfaceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EFMigrations
{
    public class DataManipulation<T> : IDataBase<T> where T : class
    {
        BlogDBContext dbContext = new BlogDBContext();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        public void Add(T model)
        {
            dbContext.Set<T>().Add(model);
            SaveChanges();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        public void delete(T model)
        {
            dbContext.Set<T>().Remove(model);
            SaveChanges();
        }

        /// <summary>
        /// 条件查询加排序
        /// </summary>
        /// <param name="exp"></param>
        /// <param name="orderby"></param>
        public IQueryable<T> Find(Expression<Func<T, bool>> exp = null, string orderby = "")
        {
            return Filter(exp).OrderBy(orderby);
        }

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public IQueryable<T> Filter(Expression<Func<T, bool>> exp = null)
        {
            var dbSet = dbContext.Set<T>().AsNoTracking().AsQueryable();
            if (exp != null)
                dbSet = dbSet.Where(exp);
            return dbSet;
        }

        /// <summary>
        /// 得到分页记录
        /// </summary>
        /// <param name="pageindex">The pageindex.</param>
        /// <param name="pagesize">The pagesize.</param>
        /// <param name="orderby">排序，格式如："Id"/"Id desc"</param>
        public IQueryable<T> Find(int pageindex, int pagesize, string orderby, Expression<Func<T, bool>> exp)
        {
            if (pageindex < 1) pageindex = 1;
            var dbSet = Filter(exp);
            if (!string.IsNullOrEmpty(orderby))
                dbSet = dbSet.OrderBy(orderby).Skip(pagesize * (pageindex - 1)).Take(pagesize);
            return dbSet;
        }

        /// <summary>
        /// 保存
        /// </summary>
        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        /// <summary>
        /// 分页总数
        /// </summary>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public int PageCounts(int pagesize)
        {
            var countlist = dbContext.Set<T>().Count();
            return countlist % pagesize == 0 ? countlist / pagesize : countlist / pagesize + 1;
        }
    }
}
