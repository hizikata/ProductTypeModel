using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductMatchSpecify
    {
        public string ProductType { get; set; }
        public string LD_Spec { get; set; }
        public string APD_Spec { get; set; }
        public string PD_Spec { get; set; }
        public string Isolator_Spec { get; set; }
        public string ZeroFilter_Spec { get; set; }
        public string FortyFiveFilter_Spec { get; set; }
        public int Id_Key { get; set; }
    }
}
