using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentFname { get; set; } = null!;

    public string StudentLname { get; set; } = null!;

    public string? Nid { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? PassportId { get; set; }

    public DateOnly? PassExDate { get; set; }

    public string LastStudyLevel { get; set; } = null!;

    public decimal LastMarks { get; set; }

    public int GenderId { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual ICollection<CounselorStudent> CounselorStudents { get; set; } = new List<CounselorStudent>();

    public virtual Gender Gender { get; set; } = null!;

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<StudentDocument> StudentDocuments { get; set; } = new List<StudentDocument>();

    public virtual ICollection<StudentScholarship> StudentScholarships { get; set; } = new List<StudentScholarship>();

    public virtual ICollection<StudentUpdateLog> StudentUpdateLogs { get; set; } = new List<StudentUpdateLog>();
}
