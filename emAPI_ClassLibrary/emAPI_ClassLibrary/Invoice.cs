
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * Invoice.cs - 
 * Code source: Handwritten
 */
		

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents a utility invoice
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Unique id of the invoice
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// Present reading on the invoice (currently unused)
        /// </summary>
        public int PresentRead { get; set; }

        /// <summary>
        /// Previous reading on the invoice (currently unused)
        /// </summary>
        public int PreviousRead { get; set; }
        
        /// <summary>
        /// Amount of energy invoiced for
        /// </summary>
        [Required(ErrorMessage="Required")]
        public int KWh { get; set; }

        /// <summary>
        /// The cost, in £, of the standing charge on this invoice
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public double StandingCharge { get; set; }

        /// <summary>
        /// The cost, in £, of the kWh billed for on this invoice
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public double ConsumptionCharge { get; set; }

        /// <summary>
        /// Total cost of any other charges, in £, on this invoice.  This is not considered during valitation.
        /// </summary>
        [Required(ErrorMessage = "Required")]
        [DefaultValue(0.00)]
        public double OtherCharge { get; set; }

        /// <summary>
        /// False until the invoice has been checked.  Reset when the invoice is edited.
        /// </summary>
        public bool Checked { get; set; }

        /// <summary>
        /// Result of consumption validation.  False until validation has happened (use bool Checked to determine
        /// if the invoice has beeb validated yet).
        /// </summary>
        public bool ConsumptionIsValid { get; set; }

        /// <summary>
        /// Result of cost validation.  False until validation has happened (use bool Checked to determine
        /// if the invoice has been validated yet).
        /// </summary>
        public bool CostIsValid { get; set; }

        /// <summary>
        /// The date of the invoice.
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public DateTime BillDate { get; set; }

        /// <summary>
        /// The start date of the period of consumption the invoice is for.
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of the period of consumption the invoice is for.
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The variance, in £, between the cost calculated from kWh and tariff data during validation and the actual cost of the invoice
        /// (Invoice.StandingCharge + Invoice.ConsumptionCharge).  Negative cost variance means the invoices is cheaper than expected.
        /// </summary>
        public double CostVariance { get; set; }

        /// <summary>
        /// The variance, in kWh, between the consumption calculated from meter readings and the start and end date on the invoice.
        /// Negative consumption variance means the kWh on the invoice is less than expected.
        /// </summary>
        public double KWhVariance { get; set; }

        /// <summary>
        /// Triad bool showing whether there is enough data in the database to validate the cost of this invoice.  Null until 
        /// the invoice is validated, true/false once validation has been attempted.
        /// </summary>
        public bool? CostCanBeValidated { get; set; }

        /// <summary>
        /// Triad bool showing whether there is enough data in the database to validated the consumption of this invoice.  Null until
        /// the invoice is validated, true/false once validation has been attempted.
        /// </summary>
        public bool? ConsumptionCanBeValidated { get; set; }

        /// <summary>
        /// One-to-one relationship with Meter object.
        /// </summary>
        public Meter Meter { get; set;} 

    }
}
