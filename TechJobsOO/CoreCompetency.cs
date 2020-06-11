﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        // TODO: Change the fields to auto-implemented properties. DONE

        public CoreCompetency() : base()
        {
        }

        public CoreCompetency(string value) :base(value)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id);
        }
    }
}

