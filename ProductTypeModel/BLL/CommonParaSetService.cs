using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class CommonParaSetService
    {
        DAL.CommonParaSetService ComParaSetSer = new DAL.CommonParaSetService();
        public int UpdateDB(CommonParaSet commonParaSet,string tableName)
        {
            return ComParaSetSer.UpdateDB(commonParaSet, tableName);
        }
    }
}
