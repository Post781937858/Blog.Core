using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model.DataModel
{
    /// <summary>
    /// 用户类型
    /// </summary>
    public class UserType
    {
        /// <summary>
        /// 类型ID
        /// </summary>
        [Key]
        public int UserTypeID { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        [Required]
        public string UserName { get; set; }
    }
}
