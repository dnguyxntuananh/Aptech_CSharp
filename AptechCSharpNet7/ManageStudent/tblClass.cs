//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManageStudent
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblClass()
        {
            this.tblStudents = new HashSet<tblStudent>();
        }
    
        public string classId { get; set; }
        public string className { get; set; }
        public string deptId { get; set; }
        public Nullable<int> totId { get; set; }
        public string couId { get; set; }
        public string status { get; set; }
    
        public virtual tblCourse tblCourse { get; set; }
        public virtual tblDept tblDept { get; set; }
        public virtual tblTot tblTot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStudent> tblStudents { get; set; }
    }
}
