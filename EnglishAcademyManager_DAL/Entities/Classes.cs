namespace EnglishAcademyManager_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Classes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Classes()
        {
            Attendance = new HashSet<Attendance>();
            ScheduleDetails = new HashSet<ScheduleDetails>();
        }

        [Key]
        [StringLength(10)]
        public string class_id { get; set; }

        [Required]
        [StringLength(10)]
        public string course_id { get; set; }

        [Required]
        [StringLength(10)]
        public string teacher_id { get; set; }

        [StringLength(50)]
        public string class_name { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendance { get; set; }

        public virtual Course Course { get; set; }

        public virtual Teachers Teachers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduleDetails> ScheduleDetails { get; set; }
    }
}
