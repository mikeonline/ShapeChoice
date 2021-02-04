using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : ShapeBase
    {
        public override decimal Area => this.width * this.height;
    }
}
