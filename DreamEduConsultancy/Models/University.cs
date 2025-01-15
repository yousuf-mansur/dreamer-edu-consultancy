using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DreamEduConsultancy.Models;

public partial class University
{
    public int UniversityId { get; set; }

    public string UniversityName { get; set; } = null!;

    public int CountryId { get; set; }
    [JsonIgnore]

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
    

    public virtual Country Country { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<UniversityCourse> UniversityCourses { get; set; } = new List<UniversityCourse>();
}
