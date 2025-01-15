using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class CounselorStudent
{
    public int CounselorStudentId { get; set; }

    public int CounselorId { get; set; }

    public int StudentId { get; set; }

    public DateOnly AssignedDate { get; set; }

    public virtual Counselor Counselor { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
