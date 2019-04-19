using Blog.EFMigrations;
using Blog.IService.interfaceML;
using Blog.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.SanagementService
{
    public class UserInfoService : DataManipulation<UserInfo>, IUserInfo
    {
        public void UserInfoAdd()
        {
            
        }
    }
}
