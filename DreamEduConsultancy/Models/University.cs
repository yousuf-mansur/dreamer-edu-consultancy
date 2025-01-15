﻿using System;
using System.Collections.Generic;

namespace DreamEduConsultancy.Models;

public partial class University
{
    public int UniversityId { get; set; }

    public string UniversityName { get; set; } = null!;

    public int CountryId { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<UniversityCourse> UniversityCourses { get; set; } = new List<UniversityCourse>();
}