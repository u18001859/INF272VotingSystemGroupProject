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
    
    public partial class ProvincialResult
    {
        public int ProvincialResultsID { get; set; }
        public Nullable<int> ElectionID { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public Nullable<int> PartyID { get; set; }
        public int ProvincialResultsTotalVotes { get; set; }
    
        public virtual Election Election { get; set; }
        public virtual Party Party { get; set; }
        public virtual Province Province { get; set; }
    }
}
