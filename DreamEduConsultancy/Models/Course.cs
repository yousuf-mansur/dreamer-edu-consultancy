using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<UniversityCourse> UniversityCourses { get; set; } = new List<UniversityCourse>();
}
