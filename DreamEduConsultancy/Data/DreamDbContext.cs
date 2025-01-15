using System;
using System.Collections.Generic;
using DreamEduConsultancy.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamEduConsultancy.Data;

public partial class DreamDbContext : DbContext
{
    public DreamDbContext()
    {
    }

    public DreamDbContext(DbContextOptions<DreamDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Application> Applications =>Set<Application>();

    public virtual DbSet<ApplicationReason> ApplicationReasons => Set<ApplicationReason>();

    public virtual DbSet<ApplicationStatus> ApplicationStatuses => Set<ApplicationStatus>();

    public virtual DbSet<ApplicationUpdateLog> ApplicationUpdateLogs =>Set<ApplicationUpdateLog>();

    public virtual DbSet<Counselor> Counselors => Set<Counselor>();

    public virtual DbSet<CounselorStudent> CounselorStudents =>Set<CounselorStudent>();

    public virtual DbSet<Country> Countries => Set<Country>();

    public virtual DbSet<Course> Courses =>Set<Course>();

    public virtual DbSet<Designation> Designations => Set<Designation>();

    public virtual DbSet<Document> Documents =>Set<Document>();

    public virtual DbSet<Gender> Genders => Set<Gender>();

    public virtual DbSet<Intake> Intakes => Set<Intake>();

    public virtual DbSet<Payment> Payments =>Set<Payment>();

    public virtual DbSet<Scholarship> Scholarships => Set<Scholarship>();

    public virtual DbSet<Student> Students => Set<Student>();   

    public virtual DbSet<StudentCourse> StudentCourses => Set<StudentCourse>();

    public virtual DbSet<StudentDocument> StudentDocuments => Set<StudentDocument>();

    public virtual DbSet<StudentScholarship> StudentScholarships => Set<StudentScholarship>();

    public virtual DbSet<StudentUpdateLog> StudentUpdateLogs => Set<StudentUpdateLog>();

    public virtual DbSet<Subject> Subjects => Set<Subject>();

    public virtual DbSet<University> Universities => Set<University>();

    public virtual DbSet<UniversityCourse> UniversityCourses => Set<UniversityCourse>();

    public virtual DbSet<VisaApplication> VisaApplications => Set<VisaApplication>();

    public virtual DbSet<VisaReason> VisaReasons => Set<VisaReason>();

    public virtual DbSet<VwStudentInformation> VwStudentInformations => Set<VwStudentInformation>();    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DreamCon");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__applicat__79FDB1CFE2F65E13");

            entity.ToTable("application", tb =>
                {
                    tb.HasTrigger("trApplicationRecord");
                    tb.HasTrigger("trApplicationStatus");
                });

            entity.HasIndex(e => new { e.StudentId, e.UniversityId, e.SubjectId }, "UQ_studentApplication").IsUnique();

            entity.HasIndex(e => e.ApplicationDate, "idx_applicationDate");

            entity.HasIndex(e => e.ApplicationId, "idx_applicationId");

            entity.Property(e => e.ApplicationId).HasColumnName("applicationId");
            entity.Property(e => e.ApplicationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("applicationDate");
            entity.Property(e => e.ApplicationStatusId).HasColumnName("applicationStatusId");
            entity.Property(e => e.CountryId).HasColumnName("countryId");
            entity.Property(e => e.IntakeId).HasColumnName("intakeId");
            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.SubjectId).HasColumnName("subjectId");
            entity.Property(e => e.UniversityId).HasColumnName("universityId");

            entity.HasOne(d => d.ApplicationStatus).WithMany(p => p.Applications)
                .HasForeignKey(d => d.ApplicationStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__applicati__appli__59FA5E80");

            entity.HasOne(d => d.Country).WithMany(p => p.Applications)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__applicati__count__5629CD9C");

            entity.HasOne(d => d.Intake).WithMany(p => p.Applications)
                .HasForeignKey(d => d.IntakeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__applicati__intak__571DF1D5");

            entity.HasOne(d => d.Student).WithMany(p => p.Applications)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__applicati__stude__5535A963");

            entity.HasOne(d => d.Subject).WithMany(p => p.Applications)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__applicati__subje__59063A47");

            entity.HasOne(d => d.University).WithMany(p => p.Applications)
                .HasForeignKey(d => d.UniversityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__applicati__unive__5812160E");
        });

        modelBuilder.Entity<ApplicationReason>(entity =>
        {
            entity.HasKey(e => e.ApplicationReasonId).HasName("PK__applicat__49672E9BA9038270");

            entity.ToTable("applicationReason");

            entity.Property(e => e.ApplicationReasonId).HasColumnName("applicationReasonId");
            entity.Property(e => e.ApplicationId).HasColumnName("applicationId");
            entity.Property(e => e.VisaReasonId).HasColumnName("visaReasonId");

            entity.HasOne(d => d.Application).WithMany(p => p.ApplicationReasons)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__applicati__appli__74AE54BC");

            entity.HasOne(d => d.VisaReason).WithMany(p => p.ApplicationReasons)
                .HasForeignKey(d => d.VisaReasonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__applicati__visaR__75A278F5");
        });

        modelBuilder.Entity<ApplicationStatus>(entity =>
        {
            entity.HasKey(e => e.ApplicationStatusId).HasName("PK__applicat__1D6A3E7655F9E822");

            entity.ToTable("applicationStatus");

            entity.Property(e => e.ApplicationStatusId).HasColumnName("applicationStatusId");
            entity.Property(e => e.ApplicationStatusName)
                .HasMaxLength(50)
                .HasColumnName("applicationStatusName");
        });

        modelBuilder.Entity<ApplicationUpdateLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__applicat__7839F64D567396A7");

            entity.ToTable("applicationUpdateLog");

            entity.Property(e => e.LogId).HasColumnName("logId");
            entity.Property(e => e.ApplicationId).HasColumnName("applicationId");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.Application).WithMany(p => p.ApplicationUpdateLogs)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__applicati__appli__1DB06A4F");
        });

        modelBuilder.Entity<Counselor>(entity =>
        {
            entity.HasKey(e => e.CounselorId).HasName("PK__counselo__237F0883D27DC7BB");

            entity.ToTable("counselor");

            entity.HasIndex(e => new { e.CounselorFname, e.CounselorLname }, "UQ_counselorName").IsUnique();

            entity.Property(e => e.CounselorId).HasColumnName("counselorId");
            entity.Property(e => e.CounselorFname)
                .HasMaxLength(50)
                .HasColumnName("counselorFName");
            entity.Property(e => e.CounselorFullName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("counselorFullName");
            entity.Property(e => e.CounselorLname)
                .HasMaxLength(50)
                .HasColumnName("counselorLName");
            entity.Property(e => e.DesignationId).HasColumnName("designationId");

            entity.HasOne(d => d.Designation).WithMany(p => p.Counselors)
                .HasForeignKey(d => d.DesignationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__counselor__desig__3C69FB99");
        });

        modelBuilder.Entity<CounselorStudent>(entity =>
        {
            entity.HasKey(e => e.CounselorStudentId).HasName("PK__counselo__B1BC2371854703CD");

            entity.ToTable("counselorStudent");

            entity.HasIndex(e => new { e.CounselorId, e.StudentId }, "UQ_counselorStudent").IsUnique();

            entity.Property(e => e.CounselorStudentId).HasColumnName("counselorStudentId");
            entity.Property(e => e.AssignedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("assignedDate");
            entity.Property(e => e.CounselorId).HasColumnName("counselorId");
            entity.Property(e => e.StudentId).HasColumnName("studentId");

            entity.HasOne(d => d.Counselor).WithMany(p => p.CounselorStudents)
                .HasForeignKey(d => d.CounselorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__counselor__couns__6D0D32F4");

            entity.HasOne(d => d.Student).WithMany(p => p.CounselorStudents)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__counselor__stude__6E01572D");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__country__D32076BC7C66F7B8");

            entity.ToTable("country");

            entity.HasIndex(e => e.CountryId, "idx_countryId");

            entity.Property(e => e.CountryId).HasColumnName("countryId");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .HasColumnName("countryName");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__course__2AA84FD12A57843A");

            entity.ToTable("course");

            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.CourseName)
                .HasMaxLength(100)
                .HasColumnName("courseName");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK__designat__197CE32AE3606AB9");

            entity.ToTable("designation");

            entity.Property(e => e.DesignationId).HasColumnName("designationId");
            entity.Property(e => e.DesignationName)
                .HasMaxLength(150)
                .HasColumnName("designationName");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK__document__EFAAAD855AACDC45");

            entity.ToTable("document");

            entity.Property(e => e.DocumentId).HasColumnName("documentId");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.DocumentName)
                .HasMaxLength(100)
                .HasColumnName("documentName");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.GenderId).HasName("PK__gender__306E22409F5F05F1");

            entity.ToTable("gender");

            entity.Property(e => e.GenderId).HasColumnName("genderId");
            entity.Property(e => e.GenderName)
                .HasMaxLength(50)
                .HasColumnName("genderName");
        });

        modelBuilder.Entity<Intake>(entity =>
        {
            entity.HasKey(e => e.IntakeId).HasName("PK__intake__0F690089EE7FEDDE");

            entity.ToTable("intake");

            entity.Property(e => e.IntakeId).HasColumnName("intakeId");
            entity.Property(e => e.IntakeDate).HasColumnName("intakeDate");
            entity.Property(e => e.IntakeName)
                .HasMaxLength(50)
                .HasColumnName("intakeName");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__payment__A0D9EFC673C01254");

            entity.ToTable("payment");

            entity.Property(e => e.PaymentId).HasColumnName("paymentId");
            entity.Property(e => e.ApplicationId).HasColumnName("applicationId");
            entity.Property(e => e.PaymentAmount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("paymentAmount");
            entity.Property(e => e.PaymentDate).HasColumnName("paymentDate");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .HasColumnName("paymentMethod");

            entity.HasOne(d => d.Application).WithMany(p => p.Payments)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__payment__applica__5CD6CB2B");
        });

        modelBuilder.Entity<Scholarship>(entity =>
        {
            entity.HasKey(e => e.ScholarshipId).HasName("PK__scholars__B8F36A2244C7EEEE");

            entity.ToTable("scholarship");

            entity.Property(e => e.ScholarshipId).HasColumnName("scholarshipId");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.ScholarshipName)
                .HasMaxLength(100)
                .HasColumnName("scholarshipName");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__student__4D11D63C36550460");

            entity.ToTable("student", tb =>
                {
                    tb.HasTrigger("trLogStudentUpdates");
                    tb.HasTrigger("trPreventDuplicateStudents");
                    tb.HasTrigger("trRestrictDelete");
                    tb.HasTrigger("trRestrictPassportExpiry");
                    tb.HasTrigger("trSoftDelete");
                    tb.HasTrigger("trStudentRecordManage");
                });

            entity.HasIndex(e => e.Email, "UQ__student__AB6E6164AC5C8903").IsUnique();

            entity.HasIndex(e => e.Phone, "UQ__student__B43B145FB7617FDD").IsUnique();

            entity.HasIndex(e => e.Nid, "UQ__student__DF97D0F438CBAD7A").IsUnique();

            entity.HasIndex(e => e.StudentId, "idx_studentID");

            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.DateOfBirth).HasColumnName("dateOfBirth");
            entity.Property(e => e.DeletedAt).HasColumnName("deletedAt");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.GenderId).HasColumnName("genderId");
            entity.Property(e => e.LastMarks)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("lastMarks");
            entity.Property(e => e.LastStudyLevel)
                .HasMaxLength(50)
                .HasColumnName("lastStudyLevel");
            entity.Property(e => e.Nid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nid");
            entity.Property(e => e.PassExDate).HasColumnName("passExDate");
            entity.Property(e => e.PassportId)
                .HasMaxLength(50)
                .HasColumnName("passportId");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("phone");
            entity.Property(e => e.StudentFname)
                .HasMaxLength(50)
                .HasColumnName("studentFName");
            entity.Property(e => e.StudentLname)
                .HasMaxLength(50)
                .HasColumnName("studentLName");

            entity.HasOne(d => d.Gender).WithMany(p => p.Students)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__student__genderI__5070F446");
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasKey(e => e.StudentCourseId).HasName("PK__studentC__5A4F4B33E4DCF593");

            entity.ToTable("studentCourse");

            entity.HasIndex(e => new { e.StudentId, e.CourseId }, "UQ_studentCourse").IsUnique();

            entity.Property(e => e.StudentCourseId).HasColumnName("studentCourseId");
            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.Grade)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("grade");
            entity.Property(e => e.StudentId).HasColumnName("studentId");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__studentCo__cours__68487DD7");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__studentCo__stude__6754599E");
        });

        modelBuilder.Entity<StudentDocument>(entity =>
        {
            entity.HasKey(e => e.StudentDocumentId).HasName("PK__studentD__76E55BDC58375288");

            entity.ToTable("studentDocument");

            entity.HasIndex(e => new { e.StudentId, e.DocumentId }, "UQ_studentDocument").IsUnique();

            entity.Property(e => e.StudentDocumentId).HasColumnName("studentDocumentId");
            entity.Property(e => e.DocumentId).HasColumnName("documentId");
            entity.Property(e => e.DocumentStatus)
                .HasMaxLength(50)
                .HasColumnName("documentStatus");
            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.SubmissionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("submissionDate");

            entity.HasOne(d => d.Document).WithMany(p => p.StudentDocuments)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__studentDo__docum__7D439ABD");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentDocuments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__studentDo__stude__7C4F7684");
        });

        modelBuilder.Entity<StudentScholarship>(entity =>
        {
            entity.HasKey(e => e.StudentScholarshipId).HasName("PK__studentS__CBBEA6A77979D850");

            entity.ToTable("studentScholarship");

            entity.HasIndex(e => new { e.StudentId, e.ScholarshipId }, "UQ_studentScholarship").IsUnique();

            entity.Property(e => e.StudentScholarshipId).HasColumnName("studentScholarshipId");
            entity.Property(e => e.AwardDate).HasColumnName("awardDate");
            entity.Property(e => e.ScholarshipId).HasColumnName("scholarshipId");
            entity.Property(e => e.StudentId).HasColumnName("studentId");

            entity.HasOne(d => d.Scholarship).WithMany(p => p.StudentScholarships)
                .HasForeignKey(d => d.ScholarshipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__studentSc__schol__06CD04F7");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentScholarships)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__studentSc__stude__05D8E0BE");
        });

        modelBuilder.Entity<StudentUpdateLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__studentU__7839F64D2F710B0A");

            entity.ToTable("studentUpdateLog");

            entity.Property(e => e.LogId).HasColumnName("logId");
            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(100)
                .HasColumnName("updatedBy");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentUpdateLogs)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__studentUp__stude__17F790F9");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__subject__ACF9A760BCEA0091");

            entity.ToTable("subject");

            entity.Property(e => e.SubjectId).HasColumnName("subjectId");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(50)
                .HasColumnName("subjectName");
        });

        modelBuilder.Entity<University>(entity =>
        {
            entity.HasKey(e => e.UniversityId).HasName("PK__universi__F5A408802D1C7984");

            entity.ToTable("university");

            entity.HasIndex(e => new { e.UniversityName, e.CountryId }, "UQ_university").IsUnique();

            entity.Property(e => e.UniversityId).HasColumnName("universityId");
            entity.Property(e => e.CountryId).HasColumnName("countryId");
            entity.Property(e => e.UniversityName)
                .HasMaxLength(200)
                .HasColumnName("universityName");

            entity.HasOne(d => d.Country).WithMany(p => p.Universities)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__universit__count__4222D4EF");
        });

        modelBuilder.Entity<UniversityCourse>(entity =>
        {
            entity.HasKey(e => e.UniversityCourseId).HasName("PK__universi__F6A76FC811FC78AE");

            entity.ToTable("universityCourse");

            entity.HasIndex(e => new { e.UniversityId, e.CourseId }, "UQ_universityCourse").IsUnique();

            entity.Property(e => e.UniversityCourseId).HasColumnName("universityCourseId");
            entity.Property(e => e.CourseId).HasColumnName("courseId");
            entity.Property(e => e.UniversityCourseFee)
                .HasDefaultValue(0.00m)
                .HasColumnType("money")
                .HasColumnName("universityCourseFee");
            entity.Property(e => e.UniversityId).HasColumnName("universityId");

            entity.HasOne(d => d.Course).WithMany(p => p.UniversityCourses)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__universit__cours__6383C8BA");

            entity.HasOne(d => d.University).WithMany(p => p.UniversityCourses)
                .HasForeignKey(d => d.UniversityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__universit__unive__628FA481");
        });

        modelBuilder.Entity<VisaApplication>(entity =>
        {
            entity.HasKey(e => e.VisaApplicationId).HasName("PK__visaAppl__82522E1C9D232C9F");

            entity.ToTable("visaApplication");

            entity.Property(e => e.VisaApplicationId).HasColumnName("visaApplicationId");
            entity.Property(e => e.ApplicationId).HasColumnName("applicationId");
            entity.Property(e => e.DecisionDate).HasColumnName("decisionDate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.SubmissionDate).HasColumnName("submissionDate");
            entity.Property(e => e.VisaType)
                .HasMaxLength(50)
                .HasColumnName("visaType");

            entity.HasOne(d => d.Application).WithMany(p => p.VisaApplications)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__visaAppli__appli__00200768");
        });

        modelBuilder.Entity<VisaReason>(entity =>
        {
            entity.HasKey(e => e.VisaReasonId).HasName("PK__visaReas__6CE74CD39603920F");

            entity.ToTable("visaReason");

            entity.Property(e => e.VisaReasonId).HasColumnName("visaReasonId");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("createdAt");
            entity.Property(e => e.DeletedAt).HasColumnName("deletedAt");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updatedAt");
            entity.Property(e => e.VisaReasonName)
                .HasMaxLength(100)
                .HasColumnName("visaReasonName");
        });

        modelBuilder.Entity<VwStudentInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwStudentInformation");

            entity.Property(e => e.ApplicationStatus).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Intake).HasMaxLength(50);
            entity.Property(e => e.LastAcademicMarks).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastStudyLevel).HasMaxLength(50);
            entity.Property(e => e.Nid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NID");
            entity.Property(e => e.PassportNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.Subject).HasMaxLength(50);
            entity.Property(e => e.University).HasMaxLength(200);
        });
        modelBuilder.HasSequence<int>("sqNumeric")
            .IncrementsBy(10)
            .HasMin(0L)
            .HasMax(500L)
            .IsCyclic();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
