using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Finals.Models;

namespace Finals.Models
{
    public class SchoolYearModel
    {
        [Key]
        public string SchoolYearId { get; set; } = Guid.NewGuid().ToString(); // EF Core PK

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!; // e.g., "2024-2025"

        // Status Management (simplified)
        public SchoolYearStatus Status { get; set; } = SchoolYearStatus.Draft;

        // Date Range (school year, not phases)
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        public ICollection<SemesterModel> Semesters { get; set; } = null!;

        public bool IsOpen => Status == SchoolYearStatus.Active;
        public bool IsCurrent { get; set; }
        public bool IsRegistrationOpen { get; set; }
    }

    public enum SchoolYearStatus
    {
        Draft,      // Not yet active
        Active,     // Ongoing
        Locked,     // No edits allowed
        Archived    // Read-only
    }

    //public enum SYPhase
    //{
    //    Ongoing, Concluded, Preparatory
    //}
}