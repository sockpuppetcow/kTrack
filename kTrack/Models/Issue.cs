using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace kTrack.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public Project ProjectRef { get; set; }
        public virtual UserProfile Author { get; set; }
        public String Title { get; set; }
        public String Body { get; set; }
        public Label[] Labels { get; set; }
    }
}