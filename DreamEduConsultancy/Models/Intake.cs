using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Intake
{
    public int IntakeId { get; set; }

    public string IntakeName { get; set; } = null!;

    public DateOnly IntakeDate { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
