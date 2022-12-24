﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndLinq;
internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Gender { get; set; }
    public DateTime Dob { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender}, {nameof(Dob)}={Dob.ToString("dd/MM/yyyy")}}}";
    }
}
