//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RainbowSchooldatabaseMgt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> ClassID { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public string Gender { get; set; }
        public Nullable<int> SubjectID { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
