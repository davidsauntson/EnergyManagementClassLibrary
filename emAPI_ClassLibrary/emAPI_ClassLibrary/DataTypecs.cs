
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * DataTypes.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents the type of data requested
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// Returns kWh amount(s)
        /// </summary>
        Energy = 1,

        /// <summary>
        /// Returns £ amount(s)
        /// </summary>
        Cost = 2,
    }
}
