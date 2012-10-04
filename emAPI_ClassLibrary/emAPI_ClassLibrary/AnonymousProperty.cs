
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * AnonymousProperty.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Describes the performance and property type of a property in a single object, disconnected from any user object.
    /// Anonymous properties are not stored in the database.  Details of an anoymous property object are transferred from 
    /// exisitng property objects and not determined by the client application.
    /// </summary>
    public class AnonymousProperty
    {
        /// <summary>
        /// Unique id of the anonymous property
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Postcode of the anonymous property
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// Floor area in m2.  Optional - if unknown area of the benchmark property will be used
        /// </summary>
        public int FloorArea { get; set; }

        /// <summary>
        /// Number of bedrooms in the anonymous property
        /// </summary>
        public int NumbBedrooms { get; set; }

        /// <summary>
        /// Total annual kWh consumed at the property for the year preceeding the most recent meter reading of all meters
        /// </summary>
        public double AnnualkWh { get; set; }

        /// <summary>
        /// Total annual CO2 emissions of property in kg, for the year preceesing the most recent meter reading of all meters.
        /// </summary>
        public double AnnualCost { get; set; }

        /// <summary>
        /// The current annual total kWh divided by the floor area of the property.  If floor area is not known, the floor area of the
        /// benchmark property is used
        /// </summary>
        public double AreaNormalisedAnnualkWh { get; set; }

        /// <summary>
        /// Describes the wall type
        /// </summary>
        public string Walls { get; set; }

        /// <summary>
        /// Describes the building type
        /// </summary>
        public string Buiding { get; set; }

        /// <summary>
        /// Describes how the property is heated
        /// </summary>
        public string Heating { get; set; }

        /// <summary>
        /// True if the property belongs to the indicated user.
        /// </summary>
        public bool isUsers { get; set; }
    }
}
