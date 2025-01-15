using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Scholarship
{
    public int ScholarshipId { get; set; }

    public string ScholarshipName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public virtual ICollection<StudentScholarship> StudentScholarships { get; set; } = new List<StudentScholarship>();
}
