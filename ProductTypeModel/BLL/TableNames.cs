using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TableNames
    {
        //以下表格位于LightMasterMes
        string ProductType = "Para_ProductType";
        string ProductStation="Para_ProductStation";
        string ProductParameter="Para_ProductParameter";
        string CommonParaSet="Config_CommonParaSet";        
        string TemplateRedoSN="Redo_TemplateRedoSN";
        string PackingExportPara="config_PackingExportPara";
        //以下表格位于NBOSA
        string ProductMatchSpecify = "Ma_ProductMatchSpecify";
        string MaterialOrderParameter="Material_OrderParameter";
        //设置索引器
        public string this[string content]
        {
            get
            {
                switch (content)
                {
                    case "ProductType":return ProductType;
                    case "ProductStation":return ProductStation;
                    case "ProductParameter":return ProductParameter;
                    case "CommonParaSet":return CommonParaSet;
                    case "ProductMatchSpecify":return ProductMatchSpecify ;
                    case "TempalteRedoSN":return TemplateRedoSN;
                    case "PackingExportPara":return PackingExportPara;
                    case "MaterialOrderParameter":return MaterialOrderParameter;
                    default:return null;
                }
            }
        }
    }
}
