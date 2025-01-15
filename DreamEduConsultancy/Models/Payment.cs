using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int ApplicationId { get; set; }

    public DateOnly PaymentDate { get; set; }

    public decimal PaymentAmount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public virtual Application Application { get; set; } = null!;
}
