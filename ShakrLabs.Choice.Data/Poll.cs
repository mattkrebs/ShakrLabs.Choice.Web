//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShakrLabs.Choice.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Poll
    {
        public Poll()
        {
            this.PollItems = new HashSet<PollItem>();
        }
    
        public System.Guid PollId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<PollItem> PollItems { get; set; }
    }
}
