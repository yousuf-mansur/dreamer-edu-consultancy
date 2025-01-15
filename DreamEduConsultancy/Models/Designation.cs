using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DreamEduConsultancy.Models;

public partial class Designation
{
    public int DesignationId { get; set; }

    public string DesignationName { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<Counselor> Counselors { get; set; } = new List<Counselor>();
}
