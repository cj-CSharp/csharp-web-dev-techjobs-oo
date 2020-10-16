using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            if(obj == this)
            {
                return true;
            }
            if(obj == null)
            {
                return false;
            }
            if(obj.GetType() != this.GetType())
            {
                return false;
            }

            PositionType p = obj as PositionType;
            return p.Id == Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
