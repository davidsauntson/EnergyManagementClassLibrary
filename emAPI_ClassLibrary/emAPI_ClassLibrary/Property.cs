
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * Property.cs - 
 * Code source: Handwritten
 */
		

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Describes a property and all associated attributes.
    /// </summary>
    public class Property
    {
        /// <summary>
        /// Unique property id
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// Title of property
        /// </summary>
        [Required(ErrorMessage="Required")]
        [StringLength(100,MinimumLength=1)]
        public string Name { get; set; }

        /// <summary>
        /// Postcode must be valid format
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"(?i)[A-Z]{1,2}[\d][\dA-Z]? ?[\d]{1}[A-Z]{2}", ErrorMessage = "Must be a valid postcode")]
        ///regex source: http://webarchive.nationalarchives.gov.uk/+/http://www.cabinetoffice.gov.uk/media/291370/bs7666-v2-0-xsd-PostCodeType.htm
        ///Taken from BS7666: Address (UK)
        public string Postcode { get; set; }
        
        /// <summary>
        /// Floor area in m2.  Optional - if left as 0 area of the benchmark property will be used
        /// </summary>
        [Range(0,99999999)]
        public int FloorArea { get; set; }

        /// <summary>
        /// Number of bedrooms (currently unused)
        /// </summary>
        [Range(0, 99999999)]
        public int NumbBedrooms { get; set; }

        /// <summary>
        /// Total annual kWh consumed at the property for the year preceeding the most recent meter reading of all meters.
        /// </summary>
        public double AnnualkWh { get; set; }

        /// <summary>
        /// Total annual CO2 emissions of property in kg, for the year preceesing the most recent meter reading of all meters.
        /// </summary>
        public double AnnualCO2kg { get; set; }

        /// <summary>
        /// Total annual cost in £ of energy consumed at the property, for the year preceeding the most recent invoice.
        /// </summary>
        public double AnnualCost { get; set; }

        /// <summary>
        /// The current annual total kWh divided by the floor area of the property.  If floor area is not known, the floor area of the
        /// benchmark property is used.
        /// </summary>
        public double AreaNormalisedAnnualkWh { get; set; }

        /// <summary>
        /// Describes the construction of the property and how it is heated.
        /// </summary>
        public virtual PropertyType PropertyType { get; set; }

        /// <summary>
        /// One to many relationship with Meter objects
        /// </summary>
        public virtual ICollection<Meter> Meters { get; set; }
    }
}
