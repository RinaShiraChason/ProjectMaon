using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace exampleProject.Models
{
    public partial class newMaonContext : DbContext
    {
        public newMaonContext()
        {
        }

        public newMaonContext(DbContextOptions<newMaonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityUpdate> ActivityUpdate { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<DayCare> DayCare { get; set; }
        public virtual DbSet<Kids> Kids { get; set; }
        public virtual DbSet<KidsAttendance> KidsAttendance { get; set; }
        public virtual DbSet<Parents> Parents { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PlacementOfATeacher> PlacementOfATeacher { get; set; }
        public virtual DbSet<TeacherAndManager> TeacherAndManager { get; set; }
        public virtual DbSet<TypeClass> TypeClass { get; set; }
        public virtual DbSet<TypeEmployee> TypeEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FKUPS69\\SQLEXPRESS;Database=newMaon;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityUpdate>(entity =>
            {
                entity.HasKey(e => e.IdActivityUpdate);

                entity.ToTable("Activity_Update");

                entity.Property(e => e.IdActivityUpdate).HasColumnName("id_Activity_Update");

                entity.Property(e => e.Calendar)
                    .IsRequired()
                    .HasColumnName("calendar")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.DailyActivity)
                    .IsRequired()
                    .HasColumnName("Daily_Activity")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LostSabbath)
                    .IsRequired()
                    .HasColumnName("lost_sabbath")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.WeeklyColumn)
                    .IsRequired()
                    .HasColumnName("weekly_column")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ActivityUpdate)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Activity___class__6B24EA82");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.ActivityUpdate)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Activity___teach__6C190EBB");
            });

            modelBuilder.Entity<Classes>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("classes");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.KindOfClassId).HasColumnName("kindOfClass_id");
            });

            modelBuilder.Entity<DayCare>(entity =>
            {
                entity.HasKey(e => e.IdDayCare);

                entity.ToTable("day_care");

                entity.Property(e => e.IdDayCare).HasColumnName("id_day_care");

                entity.Property(e => e.AboutDayCare)
                    .IsRequired()
                    .HasColumnName("about_day_care")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DressDayCare)
                    .IsRequired()
                    .HasColumnName("dress_day_care")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NameDayCare)
                    .IsRequired()
                    .HasColumnName("name_day_care")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumClasses).HasColumnName("num_classes");
            });

            modelBuilder.Entity<Kids>(entity =>
            {
                entity.HasKey(e => e.TzKids);

                entity.ToTable("kids");

                entity.Property(e => e.TzKids).HasColumnName("tz_kids");

                entity.Property(e => e.AgeKids)
                    .IsRequired()
                    .HasColumnName("age_kids")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AttendanceId).HasColumnName("attendance_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.DateBorn)
                    .HasColumnName("date_born")
                    .HasColumnType("date");

                entity.Property(e => e.NameKids)
                    .IsRequired()
                    .HasColumnName("name_kids")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParentsId).HasColumnName("parents_id");

                entity.HasOne(d => d.Attendance)
                    .WithMany(p => p.Kids)
                    .HasForeignKey(d => d.AttendanceId)
                    .HasConstraintName("FK__kids__attendance__628FA481");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Kids)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__kids__class_id__60A75C0F");

                entity.HasOne(d => d.Parents)
                    .WithMany(p => p.Kids)
                    .HasForeignKey(d => d.ParentsId)
                    .HasConstraintName("FK__kids__parents_id__619B8048");
            });

            modelBuilder.Entity<KidsAttendance>(entity =>
            {
                entity.HasKey(e => e.AttendanceId);

                entity.ToTable("kids_attendance");

                entity.Property(e => e.AttendanceId).HasColumnName("attendance_id");

                entity.Property(e => e.Check).HasColumnName("check_");

                entity.Property(e => e.CurrentDate)
                    .HasColumnName("currentDate")
                    .HasColumnType("date");

                entity.Property(e => e.KidId).HasColumnName("kid_id");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");
            });

            modelBuilder.Entity<Parents>(entity =>
            {
                entity.ToTable("parents");

                entity.Property(e => e.ParentsId).HasColumnName("parents_id");

                entity.Property(e => e.ParentsTz).HasColumnName("parents_tz");

                entity.Property(e => e.PersonTz).HasColumnName("person_tz");

                entity.HasOne(d => d.PersonTzNavigation)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.PersonTz)
                    .HasConstraintName("FK__parents__person___5DCAEF64");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PersonTz);

                entity.ToTable("person");

                entity.Property(e => e.PersonTz).HasColumnName("person_tz");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasColumnName("adress")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasColumnName("person_name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNamber1)
                    .IsRequired()
                    .HasColumnName("phone_namber1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNamber2)
                    .IsRequired()
                    .HasColumnName("phone_namber2")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlacementOfATeacher>(entity =>
            {
                entity.HasKey(e => e.IdPlacementOfATeacher);

                entity.ToTable("placement_of_a_teacher");

                entity.Property(e => e.IdPlacementOfATeacher).HasColumnName("id_placement_of_a_teacher");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.DateShifts)
                    .HasColumnName("date_shifts")
                    .HasColumnType("date");

                entity.Property(e => e.Shifts)
                    .IsRequired()
                    .HasColumnName("shifts")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PlacementOfATeacher)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__placement__class__6754599E");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.PlacementOfATeacher)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__placement__teach__68487DD7");
            });

            modelBuilder.Entity<TeacherAndManager>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.ToTable("teacherAndManager");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.PersonTz).HasColumnName("person_tz");

                entity.Property(e => e.TeacherTz).HasColumnName("teacher_tz");

                entity.HasOne(d => d.PersonTzNavigation)
                    .WithMany(p => p.TeacherAndManager)
                    .HasForeignKey(d => d.PersonTz)
                    .HasConstraintName("FK__teacherAn__perso__5629CD9C");
            });

            modelBuilder.Entity<TypeClass>(entity =>
            {
                entity.HasKey(e => e.IdTypeClass);

                entity.ToTable("type_class");

                entity.Property(e => e.IdTypeClass).HasColumnName("id_type_class");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.TypeClassName)
                    .IsRequired()
                    .HasColumnName("type_class_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TypeClass)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__type_clas__class__5165187F");
            });

            modelBuilder.Entity<TypeEmployee>(entity =>
            {
                entity.HasKey(e => e.IdTypeEmp);

                entity.ToTable("type_employee");

                entity.Property(e => e.IdTypeEmp).HasColumnName("id_type_emp");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.TypeEmpName)
                    .IsRequired()
                    .HasColumnName("type_emp_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TypeEmployee)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__type_empl__teach__59063A47");
            });
        }
    }
}
