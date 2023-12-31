﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Kodee.Models.Investigations.Employees
{
    public class EmployeeInvestigation
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
        public DateTimeOffset Start { get; set; }

        public bool Active { get; set; } = true;

        [StringLength(255)]
        public string AssignedTo { get; set; } = "";

        [StringLength(450)]
        public string AssignedToUserId { get; set; } = "";

        [StringLength(35)]
        public string NigcClassification { get; set; } = "";

        public bool OmitNOR { get; set; } = false;

        public bool OmitNOLD { get; set; } = false;
    }
}
