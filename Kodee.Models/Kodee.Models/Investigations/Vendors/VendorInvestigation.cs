using System;
using System.ComponentModel.DataAnnotations;

namespace Kodee.Models.Investigations.Vendors
{
    public class VendorInvestigation
    {
        [Key]
        public long Id { get; set; }

        public long? EmployeeId { get; set; }

        public DateTimeOffset? End { get; set; }

        public string InvestigationType { get; set; } = "";

        [Required]
        public long LicenseTypeId { get; set; }

        public string Name { get; set; } = "";

        [Required]
        public DateTimeOffset Start { get; set; } = DateTimeOffset.UtcNow;

        public bool Active { get; set; } = true;

        [StringLength(255)]
        public string AssignedTo { get; set; } = "";

        [StringLength(450)]
        public string AssignedToUserId { get; set; } = "";

        [Required]
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        [StringLength(70)]
        public string CreatedBy { get; set; } = "";

        public long? VendorId { get; set; }

        [Required]
        public int ApplicantType { get; set; }
    }
}
