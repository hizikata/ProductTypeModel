using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductType
    {
        //成员名不能与类名相同
        public string ProductTypeName { get; set; }
        public int TypeLength { get; set; }
        public string TypeSign { get; set; }
        public string ApdSign { get; set; }
        public string TypeCatalog { get; set; }
        public string SnSign { get; set; }
        public string TeCaculateMethod { get; set; }
        public string PackingType { get; set; }
        public int IsSmsrSpotTest { get; set; }
        public int IsImd2SpotTest { get; set; }
        public int TypeVisible { get; set; }
        public string MaterialId { get; set; }
        public string ProductTypeCommon { get; set; }
        public int CheckSnSubLength { get; set; }
        public string YearSign { get; set; }
        public string AlignType { get; set; }
        public int IsUploadHwData { get; set; }
        public int IsChangeToRedoData { get; set; }
        public string HousingLaserSign { get; set; }
        public string ThOneTestType { get; set; }
        public string TransmitRate { get; set; }
    }
}
