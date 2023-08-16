using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Domain.Models
{
    public class EXERCISE
    {
        public int ID_EXERCISE { get; set; }
        public string NAME { get; set; }
        public string URL { get; set; }
        public string DESCRIPTION { get; set; }
        public int? DURATION { get; set; }
        public int? REPEAT_NUMBER { get; set; }
        public byte DELETED { get; set; }

    }
}
