using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class StudentUpdateLog
{
    public int LogId { get; set; }

    public int StudentId { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
