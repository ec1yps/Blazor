using System;
using System.Collections.Generic;

namespace Academy.Models;

public partial class Discipline
{
    public short DisciplineId { get; set; }

    public string? DisciplineName { get; set; }

    public byte NumberOfLessons { get; set; }
}
