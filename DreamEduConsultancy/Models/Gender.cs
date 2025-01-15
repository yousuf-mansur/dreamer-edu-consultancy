using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DreamEduConsultancy.Models;

public partial class Gender
{
    public int GenderId { get; set; }

    public string GenderName { get; set; } = null!;
    [JsonIgnore]

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
