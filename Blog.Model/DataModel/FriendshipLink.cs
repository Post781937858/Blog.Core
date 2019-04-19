using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model.DataModel
{
    /// <summary>
    /// 友情链接
    /// </summary>
    public class FriendshipLink
    {
        /// <summary>
        /// 链接ID
        /// </summary>
        [Key]
        public int FriendshipLinkID { get; set; }

        /// <summary>
        /// 链接名称
        /// </summary>
        public string FriendshipLinkName { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        public string FriendshipLinkURL { get; set; }

        /// <summary>
        /// 网站图标URL
        /// </summary>
        public string FriendshipLinkimgURL { get; set; }

        /// <summary>
        /// 网站简介
        /// </summary>
        public string LinkSynopsis { get; set; }




    }
}
