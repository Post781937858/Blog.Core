using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model.DataModel
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        [Key]
        public int ArticleID { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 文章内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 编辑时间
        /// </summary>
        public string CompileTime { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 浏览量
        /// </summary>
        public double BrowseNume { get; set; }

        /// <summary>
        /// 文章类型ID
        /// </summary>
        public int ArticleTypeID { get; set; }

        /// <summary>
        /// 封面URL
        /// </summary>
        public string CoverURL { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Synopsis { get; set; }
        





    }
}
