
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * Annotation.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents a note that is attached to a meter
    /// </summary>
    public class Annotation
    {
        /// <summary>
        /// Unique id of the note
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        
        /// <summary>
        /// Date of the note
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// Note text
        /// </summary>
        [Required]
        [StringLength(100, MinimumLength=1)]
        public string Note { get; set; }
    }
}
