using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Unused
    /// </summary>
    internal class Economy7Meter : ElectricityMeter
    {
        public virtual ICollection<MeterReading> SecondaryRegister { get; set; }
    }
}
