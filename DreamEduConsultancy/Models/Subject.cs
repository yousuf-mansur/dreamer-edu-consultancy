using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
