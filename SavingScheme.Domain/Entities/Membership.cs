using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingScheme.Domain.Entities
{
    public class Membership
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public decimal MinContribution { get; set; }
        public decimal MaxContribution { get; set; }
        public List<Member>? Members { get; set; }
        public List<Contribution>? Contributions { get; set; }
        public DateTime OpenningDate { get; set; }
        public DateTime ClosingDate { get; set; }
    }
}
