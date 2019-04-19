using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model.DataModel
{
    /// <summary>
    /// 通知
    /// </summary>
    public class Inform
    {
        /// <summary>
        /// 通知ID
        /// </summary>
        [Key]
        public int InformID { get; set; }

        /// <summary>
        /// 通知内容
        /// </summary>
        public string InformContent { get; set; }

        /// <summary>
        /// 通知发布时间
        /// </summary>
        public string InformDate { get; set; }


    }
}
