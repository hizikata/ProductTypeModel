using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;


namespace BLL
{
    public class PackingExportParaService
    {
        DAL.PackingExportParaService PacExportParaSer = new DAL.PackingExportParaService();
        public int UpdataDB(PackingExportPara packingExportPara,string tableName)
        {
            return PacExportParaSer.UpdateDB(packingExportPara, tableName);
        }
    }
}
