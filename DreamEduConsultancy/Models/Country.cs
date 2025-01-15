using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual ICollection<University> Universities { get; set; } = new List<University>();
}
