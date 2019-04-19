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
    /// 回复
    /// </summary>
    public class reply
    {
        /// <summary>
        /// 回复ID
        /// </summary>
        [Key]
        public int replyID { get; set; }

        /// <summary>
        /// 回复内容
        /// </summary>
        public string replyContent { get; set; }

        /// <summary>
        /// 回复时间
        /// </summary>
        public string replyTime { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 评论ID
        /// </summary>
        public int CommentID { get; set; }

    }
}
