using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Domain.Models
{
    public class PROGRAM
    {
        public int ID_PROGRAM { get; set; }
        public string NAME { get; set; }
        public string BANNER_PHOTO { get; set; }
        public string DESCRIPTION { get; set; }
        public byte DELETED { get; set; }

    }
}
