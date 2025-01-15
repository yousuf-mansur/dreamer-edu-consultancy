using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DreamEduConsultancy.Models;

public partial class ApplicationStatus
{
    public int ApplicationStatusId { get; set; }

    public string ApplicationStatusName { get; set; } = null!;
    [JsonIgnore]

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
