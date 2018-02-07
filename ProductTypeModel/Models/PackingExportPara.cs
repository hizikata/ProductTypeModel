using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PackingExportPara
    {
        public string ProductType { get; set; }
        public int StartRowIndex { get; set; }
        public int EndColIndex { get; set; }
        public string ExportText { get; set; }
        public string SetRowType { get; set; }
        public int IsNeedPrintPackingLabel { get; set; }
        public int IsExportAboutHW { get; set; }
        public string HwSnColNames { get; set; }
        public string HwVopColNames { get; set; }
        public string HwVbrColNames { get; set; }
        public string FillDataContent { get; set; }
        public int Id_Key { get; set; }
    }
}
