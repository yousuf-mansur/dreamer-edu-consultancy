using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DreamEduConsultancy.Models;

public partial class Application
{
    public int ApplicationId { get; set; }

    public int StudentId { get; set; }

    public int CountryId { get; set; }

    public int IntakeId { get; set; }

    public int UniversityId { get; set; }

    public int SubjectId { get; set; }

    public int ApplicationStatusId { get; set; }

    public DateOnly ApplicationDate { get; set; }
    [JsonIgnore]

    public virtual ICollection<ApplicationReason> ApplicationReasons { get; set; } = new List<ApplicationReason>();


    public virtual ApplicationStatus ApplicationStatus { get; set; } = null!;
    [JsonIgnore]

    public virtual ICollection<ApplicationUpdateLog> ApplicationUpdateLogs { get; set; } = new List<ApplicationUpdateLog>();
    

    public virtual Country Country { get; set; } = null!;

    public virtual Intake Intake { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual University University { get; set; } = null!;
    [JsonIgnore]

    public virtual ICollection<VisaApplication> VisaApplications { get; set; } = new List<VisaApplication>();
}
