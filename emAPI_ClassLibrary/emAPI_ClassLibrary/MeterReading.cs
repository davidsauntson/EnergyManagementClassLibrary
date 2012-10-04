
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * MeterReading.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents a meter reading.
    /// </summary>
    public class MeterReading
    {
        /// <summary>
        /// Unique id of meter reading
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// Date the reading was taken.
        /// </summary>
        [Required(ErrorMessage="Required")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The reading from the meter.
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public int Reading { get; set; }

        /// <summary>
        /// Consumption of this meter reading, calculated automatically once the reading has been saved into a meter.
        /// </summary>
        public int Consumption { get; set; }
    }
}
