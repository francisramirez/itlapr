using itlapr.DAL.Core;
using System;

namespace itlapr.DAL.Entities
{
    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
    }
}
