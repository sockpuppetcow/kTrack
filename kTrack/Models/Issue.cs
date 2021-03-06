using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace kTrack.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Display(Name = "Project")]
        public int ProjectRefId { get; set; }
        [ForeignKey("ProjectRefId")]
        public virtual Project Project { get; set; }
        public string AuthorId { get; set; }
        [ForeignKey("AuthorId")]        
        public virtual IdentityUser Author { get; set; }
        public String Title { get; set; }
        public String Body { get; set; }
        public List<Label> Labels { get; set; }
    }
}