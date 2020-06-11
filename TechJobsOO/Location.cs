using System;
namespace TechJobsOO
{
    public class Location : JobField
    {


        public Location() : base()
        {
        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field. Done
        public Location(string value) : base(value)
        {
        }
        


        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Value == location.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id);
        }
    }
}
