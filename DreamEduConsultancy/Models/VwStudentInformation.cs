using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class VwStudentInformation
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Nid { get; set; }

    public string? PassportNumber { get; set; }

    public DateOnly? PassportExpiryDate { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string LastStudyLevel { get; set; } = null!;

    public decimal LastAcademicMarks { get; set; }

    public string Gender { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string University { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Intake { get; set; } = null!;

    public DateOnly ApplicationDate { get; set; }

    public string ApplicationStatus { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }
}
