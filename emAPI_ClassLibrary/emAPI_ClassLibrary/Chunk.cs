
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * Chunk.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Used to represent an amount for a period of time.  Can be kWh consumed between two dates, or cost incurred between two dates.
    /// Graphs are created from collections of Chunks.
    /// </summary>
    public struct Chunk
    {
        /// <summary>
        /// Start date of the period relevant to the amount
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End date of the period relevant to the amount
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The amount that 'occured' between the start and end dates.
        /// </summary>
        public double Amount { get; set; }
    }
}
