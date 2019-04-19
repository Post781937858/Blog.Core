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
    /// 评论
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// 评论ID
        /// </summary>
        [Key]
        public int CommentID { get; set; }

        /// <summary>
        /// 评论时间
        /// </summary>
        public string CommentTime { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string CommentContent { get; set; }

        /// <summary>
        /// 评论类型（文章评论/留言评论）
        /// </summary>
        public int CommentType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 文章ID
        /// </summary>
        public int ArticleID { get; set; }


    }
}
