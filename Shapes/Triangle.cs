using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : ShapeBase, IShape
    {
        public override decimal Area => (width * height) / 2;
    }
}
