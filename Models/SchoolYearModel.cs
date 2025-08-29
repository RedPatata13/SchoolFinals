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
        public string SchoolYearId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!; 


        public SchoolYearStatus Status { get; set; } = SchoolYearStatus.Draft;
        public SchoolYearType SchoolYearType { get; set; } = SchoolYearType.NotSet;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        public ICollection<TermModel> Terms { get; set; } = null!;
        public ICollection<SchoolYearRegistration> SchoolYearEntrees { get; set; } = null!;

        public bool IsOpen => Status == SchoolYearStatus.Active;
        public bool IsCurrent { get; set; }
        public bool IsRegistrationOpen { get; set; }
    }

    public enum SchoolYearStatus
    {
        Draft,
        Active, 
        Locked, 
        Archived    
    }

    public enum SchoolYearType
    {
       NotSet,
       Current,
       Previous,
       Upcoming,
       Archived
    }

    //public enum SYPhase
    //{
    //    Ongoing, Concluded, Preparatory
    //}
}