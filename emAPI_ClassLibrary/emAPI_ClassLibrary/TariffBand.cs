
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * TariffBand.cs - 
 * Code source: Handwritten
 */
		

using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents the pricing structure of a tariff.  All tariffs must have at least one tariff band.  Tariffs with only one band
    /// are 'unbanded', ie the unit rate of the energy does not change.
    /// </summary>
    public class TariffBand
    {
        /// <summary>
        /// Unique id of the band
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// The upper kWh limit of the band.  If this is -1 then there is no upper limit.
        /// </summary>
        [Range(-1, 9999999999)]
        public int UpperkWhLimit { get; set; }

        /// <summary>
        /// The lower kWh limit of the band.
        /// </summary>
        [Range(0, 9999999999)]
        public int LowerkWhLimit { get; set; }

        /// <summary>
        /// The unit rate (p/kWh) for consumption that falls into this band.
        /// </summary>
        [Range(0, 9999999999)]
        public double UnitRate { get; set; }
    }
}
