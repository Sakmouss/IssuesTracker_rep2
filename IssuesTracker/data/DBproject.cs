//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IssuesTracker.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DBproject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DBproject()
        {
            this.DBissues = new HashSet<DBissue>();
        }
    
        public int IdprojectId { get; set; }
        public string projectName { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> targetEndDate { get; set; }
        public Nullable<System.DateTime> actualEndDate { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DBissue> DBissues { get; set; }
    }
}
