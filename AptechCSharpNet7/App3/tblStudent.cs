//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App3
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblStudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblStudent()
        {
            this.tblExams = new HashSet<tblExam>();
            this.tblClasses = new HashSet<tblClass>();
        }
    
        public string stuId { get; set; }
        public string stuPass { get; set; }
        public string stuName { get; set; }
        public string stuGender { get; set; }
        public string stuAddress { get; set; }
        public string stuPhone { get; set; }
        public string stuEmail { get; set; }
        public Nullable<System.DateTime> stuDob { get; set; }
        public string status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblExam> tblExams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClass> tblClasses { get; set; }
    }
}