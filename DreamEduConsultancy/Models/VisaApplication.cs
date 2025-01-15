using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class VisaApplication
{
    public int VisaApplicationId { get; set; }

    public int ApplicationId { get; set; }

    public string VisaType { get; set; } = null!;

    public DateOnly SubmissionDate { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly? DecisionDate { get; set; }

    public virtual Application Application { get; set; } = null!;
}
