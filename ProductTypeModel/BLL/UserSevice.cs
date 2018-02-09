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
        public bool IsExist(string userId,string password)
        {
            return userSer.IsUserExist(userId,password);
        }
        public User GetModel(string userId)
        {
            return userSer.GetModle(userId);
        }
    }
}
