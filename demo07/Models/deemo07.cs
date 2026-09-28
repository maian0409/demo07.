using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace demo07.Models
{
  
    public class deemo07
    {
        public int Id { get; set; }

        [DisplayName("Tài khoản")]
        [Required(ErrorMessage = "Tài khoản không được để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tài khoản dài 3-20 ký tự")]
        public string Name { get; set; }

        [DisplayName("Mật khẩu")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có 8 ký tự")]
        public string Password { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Điện Thoại")]
        [Required(ErrorMessage = "Điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Điện thoại chưa đúng định dạng")]
        public string Phone { get; set; }
    }
}