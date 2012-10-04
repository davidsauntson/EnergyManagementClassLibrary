
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * BenchmarkProperty.cs - 
 * Code source: Handwritten
 */
		

using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Describes benchmark performance (typical and best practice) for a property type.
    /// </summary>
    public class BenchmarkProperty
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// Floor area in m2
        /// </summary>
        [Required]
        [Range(0,99999999)]
        public int FloorArea { get; set; }

        /// <summary>
        /// Annual kWh - good practice
        /// </summary>
        [Required]
        [Range(0,9999999999)]
        public int BenchmarkkWhGood { get; set; }

        /// <summary>
        /// Annual kWh - typical practice
        /// </summary>
        [Required]
        [Range(0, 9999999999)]
        public int BenchmarkkWhTypical { get; set; }

        /// <summary>
        /// Annual kg CO2 - good practice
        /// </summary>
        [Required]
        [Range(0, 9999999999)]
        public int BenchmarkCO2Good { get; set; }

        /// <summary>
        /// Annual kg CO2 - typical practice
        /// </summary>
        [Required]
        [Range(0, 9999999999)]
        public int BenchmarkCO2Typical { get; set; }

        /// <summary>
        /// Average annual kWh for this type of property, calculated from all properties of this type in the database
        /// </summary>
        public double typeAveragekWh { get; set; }

        /// <summary>
        /// best (ie lowest) annual kWh for this type of property, calculated from all properties of this type in the database
        /// </summary>
        public double typeBestkWh { get; set; }

        /// <summary>
        /// Best practice annual kWh figure for a property of this type
        /// </summary>
        public double BenchmarkkWhGoodNormalised { get; set; }

        /// <summary>
        /// Typical practice annual kWh figure for a property of this type
        /// </summary>
        public double BenchmarkkWhTypicalNormalised { get; set; }

        /// <summary>
        /// One to one relationship with property type
        /// </summary>
        public virtual PropertyType PropertyType { get; set; }
    }
}
