﻿using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {

        public PositionType() : base()
        {
        }

        public PositionType(string value) : base(value)
        {
        }
        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
        


        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id);
        }
    }
}
