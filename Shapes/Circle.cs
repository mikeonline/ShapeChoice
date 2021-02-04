using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : ShapeBase
    {
        public override decimal Area => (decimal)(((double)width / 2) * ((double)height / 2) * Math.PI);
    }
}
