using System;

namespace QuestionFour
{
    public class AccessControl : IPrototype
    {
        public Access Access { get; set; }
        public string userlevel { get; set; }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public AccessControl Clone()
        {
            AccessControl copy = (AccessControl) MemberwiseClone();
            return copy;
        }
    }
}