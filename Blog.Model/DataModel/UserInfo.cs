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
    /// 用户
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]
        public int UserID { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// 图像路径
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 微信图像Url
        /// </summary>
        public string WeChatImgUrl { get; set; }

        /// <summary>
        /// QQUrl
        /// </summary>
        public string QQImgUrl { get; set; }

        /// <summary>
        /// 微博Url
        /// </summary>
        public string Microblog { get; set; }

        /// <summary>
        /// GitUrl
        /// </summary>
        public string GitUrl { get; set; }

        /// <summary>
        /// 用户类型ID
        /// </summary>
        public int UserTypeID { get; set; }

    }
}
