using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class StudentDocument
{
    public int StudentDocumentId { get; set; }

    public int StudentId { get; set; }

    public int DocumentId { get; set; }

    public DateOnly SubmissionDate { get; set; }

    public string DocumentStatus { get; set; } = null!;

    public virtual Document Document { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
