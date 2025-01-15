using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class ApplicationStatus
{
    public int ApplicationStatusId { get; set; }

    public string ApplicationStatusName { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
