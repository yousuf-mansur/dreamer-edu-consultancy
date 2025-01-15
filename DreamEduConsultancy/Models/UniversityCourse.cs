using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class UniversityCourse
{
    public int UniversityCourseId { get; set; }

    public int UniversityId { get; set; }

    public int CourseId { get; set; }

    public decimal? UniversityCourseFee { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual University University { get; set; } = null!;
}
