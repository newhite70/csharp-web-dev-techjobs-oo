﻿using System;
using System.Threading.Tasks.Dataflow;

namespace TechJobsOO
{
    public class Employer : JobField
    {
        public Employer() : base ()
        {
        }

        public Employer(string value) : base(value)
        {
        }
       

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id);
        }
    }
}
