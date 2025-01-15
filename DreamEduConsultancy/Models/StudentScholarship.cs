using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class StudentScholarship
{
    public int StudentScholarshipId { get; set; }

    public int StudentId { get; set; }

    public int ScholarshipId { get; set; }

    public DateOnly AwardDate { get; set; }

    public virtual Scholarship Scholarship { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
