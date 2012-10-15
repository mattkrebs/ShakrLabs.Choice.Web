using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakrLabs.Choice.Web.Models
{
    public class ChoiceModel
    {

        
        public IEnumerable<HttpPostedFileBase> files { get; set; }
        public int Category { get; set; }
        public IEnumerable<String> urls { get; set; }
        public Guid PollID { get; set; }

      
    }
}