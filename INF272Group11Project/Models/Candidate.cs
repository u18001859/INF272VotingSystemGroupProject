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
    
    public partial class Candidate
    {
        public int Candidate_ID { get; set; }
        public string CandidateFirstNames { get; set; }
        public string CandidateLastName { get; set; }
        public Nullable<int> CandidatePosition_ID { get; set; }
        public Nullable<int> PartyID { get; set; }
        public Nullable<int> ProvinceID { get; set; }
    
        public virtual CandidatePosition CandidatePosition { get; set; }
        public virtual Party Party { get; set; }
        public virtual Province Province { get; set; }
    }
}
