using Blog.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.IService.interfaceML
{
   public interface IArticles
    {
        /// <summary>
        /// 首页文章显示
        /// </summary>
        /// <returns></returns>
        IEnumerable<Article> ArticlesSortTime(out int Count);

      

    }
}
