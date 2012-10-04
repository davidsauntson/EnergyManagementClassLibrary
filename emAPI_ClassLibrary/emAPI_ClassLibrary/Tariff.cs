
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * Tariff.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents utility tariffs.  Each tariff must have at least one band (see TariffBand).
    /// </summary>
    public class Tariff
    {
        /// <summary>
        /// Unique id of the tariff
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// The start date of the tariff
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The value, in £, of the standing charge amount
        /// </summary>
        [Required]
        [Range(0, 999999999)]
        public double SCValue { get; set; }

        /// <summary>
        /// The frequency with which the standing charge is applied
        /// </summary>
        public virtual Period SCPeriod { get; set; }

        /// <summary>
        /// The period with which the upper and lower limits in the TariffBand objects are assessed.
        /// An example:
        ///     BandPeriod: Annually
        ///     TariffBand1: lowerlimit = 0 kWh, upperlimit = 1000kWh, Rate = 10p/kWh
        ///     TariffBand2: lowerlimit = 1001kWh, upperlimit = 0kWh, Rate = 22p/kWh
        ///     
        /// The band conditions will be assessed with respect to the BandPeriod, so if the property has consumed 1500kWh in the last year
        /// the first 1000 units will be charged at 10p and the remaining 500 at 22p.
        /// </summary>
        public virtual Period BandPeriod { get; set; }

        [Required]
        public virtual ICollection<TariffBand> Bands { get; set; }
    }
}
