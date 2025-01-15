using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Designation
{
    public int DesignationId { get; set; }

    public string DesignationName { get; set; } = null!;

    public virtual ICollection<Counselor> Counselors { get; set; } = new List<Counselor>();
}
