using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public interface IShape
    {
        string Name { get; set; }
        decimal Width { get; set; }
        decimal Height { get; set; }
        decimal Area { get; }
    }
}
