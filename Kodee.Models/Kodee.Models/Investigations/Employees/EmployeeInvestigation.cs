using System;
using System.ComponentModel.DataAnnotations;

namespace Kodee.Models.Investigations.Employees
{
    public class EmployeeInvestigation
    {
        [Key]
        public long ID { get; set; }

        public long? EmployeeID { get; set; }

        public DateTimeOffset? End { get; set; }

        public string InvestigationType { get; set; } = "";

        [Required]
        public long LicenseTypeID { get; set; }

        public string Name { get; set; } = "";

        [Required]
        public DateTimeOffset Start { get; set; }

        public bool Active { get; set; } = true;

        [StringLength(255)]
        public string AssignedTo { get; set; } = "";

        [StringLength(450)]
        public string AssignedToUserID { get; set; } = "";

        [StringLength(35)]
        public string NigcClassification { get; set; } = ""; 

        public bool OmitNOR { get; set; } = false;

        public bool OmitNOLD { get; set; } = false;
    }
}
