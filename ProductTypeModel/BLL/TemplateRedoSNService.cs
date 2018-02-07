using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class TemplateRedoSNService
    {
        DAL.TemplateRedoSNService TempRedoSNSer = new DAL.TemplateRedoSNService();
        public int UpdateDB(TemplateRedoSN templateRedoSN,string tableName)
        {
            return TempRedoSNSer.UpdateDB(templateRedoSN, tableName);
        }
    }
}
