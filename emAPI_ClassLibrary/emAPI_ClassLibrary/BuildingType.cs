
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * BuildingType.cs - 
 * Code source: Handwritten
 */
		

using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Describes the type of building the property is.
    /// </summary>
    public class BuildingType
    {
        /// <summary>
        /// Unique id of the building type
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        
        /// <summary>
        /// Description of the building, eg house, flat.
        /// </summary>
        [Required]
        [StringLength(1000,MinimumLength=1)]
        public string Description { get; set; }
    }
}
