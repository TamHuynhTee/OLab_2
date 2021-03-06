//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OLab_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            this.Projects = new HashSet<Project>();
        }
    
        public string MaTV { get; set; }
        public string TenTV { get; set; }
        [System.ComponentModel.Browsable(false)]
        public System.DateTime NgaySinh { get; set; }
        public string HocVan { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string MaDA { get; set; }
        [System.ComponentModel.Browsable(false)]
        public Nullable<decimal> LuongThuong { get; set; }
        public string ChucVu { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string MaCV { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string GioiTinh { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string Email { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string Phone { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string Password { get; set; }
        public string NoiDung { get; set; }

        [System.ComponentModel.Browsable(false)]
        public virtual Job Job { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<Project> Projects { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual Project Project { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual SalaryPosition SalaryPosition { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual SalaryLevel SalaryLevel { get; set; }
    }
}
