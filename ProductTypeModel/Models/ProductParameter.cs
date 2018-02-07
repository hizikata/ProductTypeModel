using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductParameter
    {
        
        public string ProductType { get; set; }
        public string ProductStation { get; set; }
        public string ParameterName { get; set; }
        public string ParameterMax { get; set; }
        public string ParameterMin { get; set; }
        public string ParameterMemo { get; set; }
        public string TempSign { get; set; }
        public int Id_Key { get; set; }
    }
}
