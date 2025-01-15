using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DreamEduConsultancy.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public string? Description { get; set; }
    [JsonIgnore]

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    [JsonIgnore]

    public virtual ICollection<UniversityCourse> UniversityCourses { get; set; } = new List<UniversityCourse>();
}
