using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace login.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public int RuleId { get; set; }
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(250, ErrorMessage = "نمیتوانید بیشتر از {1} کاراکتر داشته باشید")]

        public string UserName { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(250, ErrorMessage = "نمیتوانید بیشتر از {1} کاراکتر داشته باشید")]
        public string Password { get; set; }
        
        [ForeignKey(name: "RuleId")]
        public Rule Rule { get; set; }
    }
}