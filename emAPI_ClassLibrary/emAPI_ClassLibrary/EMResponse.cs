
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * EMResponse.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// All responses from the emAPI webservice are packaged into an EMRepsonse object.
    /// EMRepsonses can be deserailesed from JSON and the status attributed can be assessed to determine whether
    /// the client request was successful.
    /// </summary>
    public class EMResponse
    {
        /// <summary>
        /// Code for an OK/successful request.  HTTP code: OK
        /// </summary>
        public static int OK = 200;

        /// <summary>
        /// Code for an unsuccesful request.  HTTP code: Internal server error
        /// </summary>
        public static int Error = 500;

        /// <summary>
        /// Will contain the one of the success codes above.
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// If the request was successfull, data will contain a JSON serialisation of the object requested, or null if the
        /// method called returns void.
        /// If the request was unsuccessfull, data will contain a description of the error encountered in emAPI.
        /// </summary>
        public string data {get; set;}
    }
}
