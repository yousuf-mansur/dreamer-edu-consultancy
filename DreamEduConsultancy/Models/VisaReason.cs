using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class VisaReason
{
    public int VisaReasonId { get; set; }

    public string VisaReasonName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<ApplicationReason> ApplicationReasons { get; set; } = new List<ApplicationReason>();
}
