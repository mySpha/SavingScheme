using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingScheme.Domain.Entities
{
    public class Contribution
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        [Required]
        public Member Member { get; set; }
        public Membership Membership { get; set; }
    }
}
