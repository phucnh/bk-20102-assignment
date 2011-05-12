using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XLTN
{
    public interface WindowFunction
    {
        uint Wide { get; set; }

        float[] CalculateData();
    }
}
