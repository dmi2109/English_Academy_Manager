using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EnglishAcademyManager_DAL.Entities
{
    public partial class EnglishAcademyDbContext : DbContext
    {
        public EnglishAcademyDbContext()
            : base("name=EnglishAcademyDbContext")
        {
        }

        public virtual DbSet<AcademicResults> AcademicResults { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<ScheduleDetails> ScheduleDetails { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcademicResults>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AcademicResults>()
                .Property(e => e.course_id)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.account_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.employee_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.teacher_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Attendance>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Attendance>()
                .Property(e => e.class_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Classes>()
                .Property(e => e.class_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Classes>()
                .Property(e => e.course_id)
                .IsUnicode(false);

            modelBuilder.Entity<Classes>()
                .Property(e => e.teacher_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Classes>()
                .HasMany(e => e.Attendance)
                .WithRequired(e => e.Classes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Classes>()
                .HasMany(e => e.ScheduleDetails)
                .WithRequired(e => e.Classes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.course_id)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.level)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.AcademicResults)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Registration)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.employee_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Receipt)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.receipt_id)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.employee_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.registration_id)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.course_id)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<ScheduleDetails>()
                .Property(e => e.schedule_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ScheduleDetails>()
                .Property(e => e.class_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.student_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.AcademicResults)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Attendance)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Receipt)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Registration)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teachers>()
                .Property(e => e.teacher_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Teachers>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Teachers>()
                .HasMany(e => e.Classes)
                .WithRequired(e => e.Teachers)
                .WillCascadeOnDelete(false);
        }
    }
}
