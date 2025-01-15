using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class ApplicationUpdateLog
{
    public int LogId { get; set; }

    public int ApplicationId { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual Application Application { get; set; } = null!;
}
