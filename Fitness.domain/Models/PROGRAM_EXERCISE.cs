using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Domain.Models
{
    public class PROGRAM_EXERCISE
    {
        public int ID_PROGRAM_EXERCISE { get; set; }
        public int ID_PROGRAM { get; set; }
        public int ID_EXERCISE { get; set; }
        public byte DELETED { get; set; }
    }
}
