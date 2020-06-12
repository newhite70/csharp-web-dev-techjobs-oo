using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }

        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            if (string.IsNullOrEmpty(value) == true)
            {
                Value = "Data not available";
                //Value = value;
            }
            else if (value == null)
            {
                Value = "Data not available";
            }
            else
            {
                Value = value;
            }
        }


        public override string ToString()
        {
            return Value;
        }
    }
}
