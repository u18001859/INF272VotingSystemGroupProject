//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INF272Group11Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public int StaffID { get; set; }
        public string Staff_UserName { get; set; }
        public string Staff_Password { get; set; }
        public string Staff_FirstNames { get; set; }
        public string Staff_LastName { get; set; }
        public string StaffPhoneNumber { get; set; }
        public string StaffEmail { get; set; }
        public string StaffSecurityQuestionAnswer { get; set; }
        public Nullable<int> StaffPositionID { get; set; }
        public Nullable<int> SecurityQuestionID { get; set; }
        public string GUID { get; set; }
        public System.DateTime GUIDTimeStamp { get; set; }
    
        public virtual SecurityQuestion SecurityQuestion { get; set; }
        public virtual StaffPosition StaffPosition { get; set; }
    }
}
