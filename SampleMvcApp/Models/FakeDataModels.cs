using System.ComponentModel.DataAnnotations;

namespace SampleMvcApp.Models
{
    /// <summary>
    /// A Fake Data Model for the test
    /// </summary>
    public class FakeDataModels
    {
        /// <summary>
        /// Gets or sets a short descriptive text about the record.
        /// The Blurb text is commonly used for tooltips.
        /// </summary>
        /// <value>
        /// The short informational text about the record.
        /// </value>
        [Display(Name = "Blurb"), Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text), StringLength(200)]
        [RegularExpression(@"^[a-zA-Z0-9 ]+$", ErrorMessage = "{0} may only contain; letters, numbers, and spaces may be used.")]
        public string Blurb { get; set; }

        /// <summary>
        /// Gets or sets the Description text about the record.
        /// </summary>
        /// <value>
        /// The Description text is a more detailed explanation about the current record.
        /// The Description text is intended to be used in conjunction with the on-line help and documentation.
        /// </value>
        [Display(Name = "Description"), Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "{0} may only contain; letters or spaces may be used.")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the passcode.
        /// </summary>
        /// <value>
        /// The passcode.
        /// </value>
        [Display(Name = "Secret Passcode"), Required(ErrorMessage = "{0} is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "{0} may only contain numbers")]
        public int Passcode { get; set; }


        /// <summary>
        /// Gets or sets the Name of the current record.
        /// </summary>
        /// <value>
        /// The Name of the current record.
        /// </value>
        [Display(Name = "Name"), Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text), StringLength(200)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "{0} may only contain letters")]
        public string Name { get; set; }
    }
}