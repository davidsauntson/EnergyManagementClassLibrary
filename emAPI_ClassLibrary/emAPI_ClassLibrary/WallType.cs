
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * WallType.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Describes the type of wall at the property
    /// </summary>
    public class WallType
    {
        /// <summary>
        /// Unique id of the wall type
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// Description of the wall type.
        /// </summary>
        [Required]
        [StringLength(1000, MinimumLength = 1)]
        public string Description { get; set; }
    }
}