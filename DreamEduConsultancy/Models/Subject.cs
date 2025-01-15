using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DreamEduConsultancy.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;
    [JsonIgnore]

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
