
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DAVID SAUNTSON 12993011                                               *
 * MSc Software Engineering - Final Year Project                         *
 *                                                                       *
 * Energy Management API & Software                                      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * 
 * User.cs - 
 * Code source: Handwritten
 */
		

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace emAPI.ClassLibrary
{
    /// <summary>
    /// Represents the user.
    /// emAPI will store whatever string is passed into the 'Password' attribute.
    /// Plaintext passwords should not be stored in the database - consider a salty hash instead.
    /// </summary>
    public class User
    {

        /// <summary>
        /// Unique id for this user
        /// </summary>
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        /// <summary>
        /// Username must be unique (test with usernameIsUnique(string username).
        /// </summary>
        [Required(ErrorMessage="Required")]
        [StringLength(50, MinimumLength=5, ErrorMessage="Length must be between 5 and 50 characters")]
        public string Username { get; set; }

        /// <summary>
        /// Email must be valid email format
        /// </summary>
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage="Must be a valid email address")]
        ///regex expression source: http://www.regular-expressions.info/email.html
        ///adaptation to standard rfc2822 
        [Required(ErrorMessage = "Required")]
        public string Email  { get; set; }

        /// <summary>
        /// Do not store plaintext password in the database
        /// </summary>
        [Required(ErrorMessage = "Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Forename { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Surname { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
