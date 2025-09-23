using System;
using System.Collections.Generic;

namespace Academy.Models;

public partial class Group
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public byte? Direction { get; set; }

    public byte? Weekdays { get; set; }

    public TimeOnly? StartTime { get; set; }

    public virtual Direction? DirectionNavigation { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
