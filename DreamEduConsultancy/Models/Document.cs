using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Document
{
    public int DocumentId { get; set; }

    public string DocumentName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<StudentDocument> StudentDocuments { get; set; } = new List<StudentDocument>();
}
