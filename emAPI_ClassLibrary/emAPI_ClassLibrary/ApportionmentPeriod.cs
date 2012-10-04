
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * ApportionmentPeriod.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// The five available periods for apportionment.
    /// </summary>
    public enum AppotionmentPeriod
    {
        Daily = 1,
        Weekly,
        Monthly,
        Quarterly,
        Annually
    }
}
