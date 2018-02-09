using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace Models
{
    public class User
    {
        public int  UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string Privilege { get; set; }
        public int Id_Key { get; set; }
    }
}
