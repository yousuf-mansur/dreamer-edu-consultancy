using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DreamEduConsultancy.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
    [JsonIgnore]

    public virtual ICollection<University> Universities { get; set; } = new List<University>();
}
