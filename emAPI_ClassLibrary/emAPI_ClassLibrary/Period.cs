
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * Period.cs - 
 * Code source: Handwritten
 */
		

using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents an interval of time.
    /// </summary>
    public class Period
    {   
        /// <summary>
        /// Unique id of the period
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Description of the period, eg 'Annually', 'Weekly' etc
        /// </summary>
        public string Length { get; set; }

        /// <summary>
        /// Length of the period in days
        /// </summary>
        public int NumbDays { get; set; }
    }

}
