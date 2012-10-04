
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * PropertyTypes.cs - 
 * Code source: Handwritten
 */
		

using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Describes the type of the property to which is it attached.  Used to determine which 
    /// BenchmarkProperty applies to a property of this type.
    /// </summary>
    public class PropertyType
    {
        /// <summary>
        /// Unique id of the property type
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// Reference code for the property type.
        /// </summary>
        [Required]
        [StringLength(50, MinimumLength=1)]
        public string Code { get; set; }

        /// <summary>
        /// Description string of the property type.
        /// </summary>
        [Required]
        [StringLength(500, MinimumLength=1)]
        public string Description { get; set; }

        /// <summary>
        /// Describes the building eg house, flat etc
        /// </summary>
        [Required]
        public BuildingType Building { get; set; }

        /// <summary>
        /// Describes how the property is heated
        /// </summary>
        [Required]
        public HeatingType Heating { get; set; }

        /// <summary>
        /// Describes the material of the walls of the property
        /// </summary>
        [Required]
        public WallType Walls { get; set; }
    }
}
