//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrmMain
{
    using System;
    using System.Collections.Generic;
    
    public partial class tclass_status_detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tclass_status_detail()
        {
            this.tclass_schedule = new HashSet<tclass_schedule>();
        }
    
        public int class_status_id { get; set; }
        public string class_status_discribe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tclass_schedule> tclass_schedule { get; set; }
    }
}
