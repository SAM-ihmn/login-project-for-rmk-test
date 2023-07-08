using System.ComponentModel.DataAnnotations;
using System.Data;

namespace login.Models
{
    public class Rule
    {
        [Key]
        public int RuleId { get; set; }
        [Display(Name ="عنوان نقش")]
        [Required]
        public string RuleTitle { get; set; }
        
        public virtual List<User> Users { get; set; }
    }
}
