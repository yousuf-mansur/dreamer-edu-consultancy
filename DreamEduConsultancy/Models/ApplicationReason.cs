using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class ApplicationReason
{
    public int ApplicationReasonId { get; set; }

    public int ApplicationId { get; set; }

    public int VisaReasonId { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual VisaReason VisaReason { get; set; } = null!;
}
