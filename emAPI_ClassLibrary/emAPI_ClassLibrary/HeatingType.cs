
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * HeatingType.cs - 
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
    /// Describes how the property is heated
    /// </summary>
    public class HeatingType
    {
        /// <summary>
        /// Unique id of heating type
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// Description eg 'Electrically'
        /// </summary>
        [Required]
        [StringLength(999, MinimumLength = 1)]
        public string Description { get; set; }

    }


}
