//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fees_proj
{
    using System;
    using System.Collections.Generic;
    
    public partial class dormitory_bank_account_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dormitory_bank_account_table()
        {
            this.bank_currency_table = new HashSet<bank_currency_table>();
        }
    
        public int id { get; set; }
        public int dormitory_id { get; set; }
        public string bank_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bank_currency_table> bank_currency_table { get; set; }
        public virtual dormitories_table dormitories_table { get; set; }
    }
}
