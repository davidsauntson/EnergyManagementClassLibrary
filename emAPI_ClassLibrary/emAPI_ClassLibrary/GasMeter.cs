
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * GasMeter.cs - 
 * Code source: Handwritten
 */
		

using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents a gas meter.
    /// </summary>
    public class GasMeter : Meter
    {
        /// <summary>
        /// Fixed double that corrects for room temperature and pressure.  Value stored as a static double in
        /// EMConverter of emAPI library.  EMConverter.gasCorrectionFactor.
        /// </summary>
        [ScaffoldColumn(false)]
        public double CorrectionFactor { get; set; }

        /// <summary>
        /// Fixed double that represents the energy in J of 1m3 natural gas.  Value stored as a static double in
        /// EMConverter of emAPI library.  EMConverter.gasCalorificValue.
        /// </summary>
        [ScaffoldColumn(false)]
        public double CalorificValue { get; set; }

        /// <summary>
        /// Fixed double that converts one unit on the meter into m3  Varies from meter to meter and must be determined 
        /// and assigned by the client.
        /// </summary>
        [ScaffoldColumn(false)]
        public double MeterCoefficient { get; set; }

        public GasMeter()
        {
            Fuel = "Gas";
        }
    }
}
