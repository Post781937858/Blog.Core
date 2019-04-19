using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.IService.interfaceML;
using Blog.EFMigrations;
using Blog.Model.DataModel;

namespace Blog.SanagementService
{
    public class ArticlesService : DataManipulation<Article>, IArticles
    {

        /// <summary>
        /// 首页文章分页
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Article> ArticlesSortTime(out int Count)
        {
            Count = PageCounts(10);
            return Find(1, 10, "CompileTime desc", null);
        }






    }
}
