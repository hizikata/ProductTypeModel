using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;


namespace BLL
{
    public class UserSevice
    {
        DAL.UserService userSer=new DAL. UserService();
        public bool IsExist(string LoginId,string LoginPwd)
        {
            return userSer.IsUserExist(LoginId, LoginPwd);
        }
        public User GetModel(string LoginId)
        {
            return userSer.GetModle(LoginId);
        }
    }
}
