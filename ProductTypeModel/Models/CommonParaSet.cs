using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CommonParaSet
    {
        public string ApplicationName { get; set; }
        public string ProductType { get; set; }
        public string ProductStation { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public string CurrentTemperature { get; set; }
        public string Memo { get; set; }
        public string OpPerson { get; set; }
        public string OpDate { get; set; }
        public int Id_Key { get; set; }

    }
}
