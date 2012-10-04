
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * Meter.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using emAPI.ClassLibrary;


namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents a meter.  Super of GasMeter and ElectricityMeter.
    /// </summary>
    public class Meter
    {
        /// <summary>
        /// Unique id of the meter
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }
     
        /// <summary>
        /// Serial number for the meter, used as the title for the meter.
        /// </summary>
        [Required(ErrorMessage="Required")]
        [StringLength(50, MinimumLength=1)]
        public string SerialNo { get; set; }

        /// <summary>
        /// Fixed double that converts kWh into kg of CO2.  Varies from fuel to fuel.
        /// Values stored as static doubles in emAPI.EMConverter.
        /// </summary>
        [ScaffoldColumn(false)]
        public double KWhtoCO2ConversionFactor { get; set; }

        /// <summary>
        /// The number of digits on the meter.  Required to assess consumption when the meter has 'ticked over'
        /// (ie when a reading is less than a previous reading).
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [Range(0, 12, ErrorMessage="Must be between 0 and 12")]
        public int NumbDigits { get; set; }

        /// <summary>
        /// The fuel of the meter.
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public string Fuel { get; set; }

        /// <summary>
        /// The start date of the meter
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// One to many relationship with invoice object.
        /// </summary>
        public virtual ICollection<Invoice> Invoices { get; set; }

        /// <summary>
        /// One to many relationship with notes.
        /// </summary>
        public virtual ICollection<Annotation> Notes { get; set; }

        /// <summary>
        /// One to many relationship with tariffs.
        /// </summary>
        public virtual ICollection<Tariff> Tariffs { get; set; }

        /// <summary>
        /// One to many relationship with meter readings.
        /// </summary>
        public virtual ICollection<MeterReading> Register { get; set; }
    }
}
