﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data;

public class TodoItem
{
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
}
