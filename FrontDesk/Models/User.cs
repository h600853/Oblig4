﻿using System;
using System.Collections.Generic;

namespace FrontDesk.Models;

public partial class User
{
    public int id { get; set; }

    public string username { get; set; } = null!;

    public string password { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
