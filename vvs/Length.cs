using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vvs
{
    public class Length
    {
        private double value;
        private string type;

        public Length(double value, string type)
        {
            this.value = value;
            this.type = type;
        }

       
        public string Verbose()
        {
            return String.Format("{0} {1}", this.value, this.type);
        }
    }
}
