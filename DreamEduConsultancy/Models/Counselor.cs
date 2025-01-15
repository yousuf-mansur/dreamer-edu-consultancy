using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Counselor
{
    public int CounselorId { get; set; }

    public string CounselorFname { get; set; } = null!;

    public string CounselorLname { get; set; } = null!;

    public int DesignationId { get; set; }

    public string CounselorFullName { get; set; } = null!;

    public virtual ICollection<CounselorStudent> CounselorStudents { get; set; } = new List<CounselorStudent>();

    public virtual Designation Designation { get; set; } = null!;
}
