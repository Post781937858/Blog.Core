using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model.DataModel
{
    /// <summary>
    /// 文章类型
    /// </summary>
    public class ArticleType
    {
        /// <summary>
        /// 文章类型ID
        /// </summary>
        [Key]
        public int ArticleTypeID { get; set; }

        /// <summary>
        /// 文章类型名称
        /// </summary>
        [Required]
        public string ArticleTypeName { get; set; }

    }
}
