using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Domain.Models
{
    public class USER
    {
        public int ID_USER { get; set; }
        public string USERNAME { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string MOBILE_PHONE { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public int ID_LOGIN_TYPE { get; set; }
        public int? HEIGHT { get; set; }
        public int? WEIGHT { get;set; }
        public string ADRESS { get; set; }
        public string? USER_PHOTO { get; set; }
        public byte DELETED { get; set; }
    }
}
