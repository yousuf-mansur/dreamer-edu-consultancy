﻿using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class Gender
{
    public int GenderId { get; set; }

    public string GenderName { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
