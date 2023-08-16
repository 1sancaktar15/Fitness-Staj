using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Domain.Models
{
    public class USER_EXERCISE
    {
        public int ID_USER_EXERCISE { get; set; }
        public int ID_USER { get; set; }
        public int ID_EXERCISE { get; set; }
        public DateTime DATE { get; set; }
        public byte DELETED { get; set; }
    }
}
