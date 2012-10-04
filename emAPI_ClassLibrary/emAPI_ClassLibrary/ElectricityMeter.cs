
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * ElectricityMeter.cs - 
 * Code source: Handwritten
 */
		

using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents an electricity meter - child of Meter.
    /// </summary>
    public class ElectricityMeter : Meter
    {
        /// <summary>
        /// Scaling factor to convert one unit on the meter into one kWh, varies from meter to meter.
        /// Must be determined and assigned by the client.
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public double ScalingFactor { get; set; }

        public ElectricityMeter()
        {
            Fuel = "Electricity";
        }
    }
}
