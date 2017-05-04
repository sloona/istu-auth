using System.ComponentModel.DataAnnotations;

namespace Istu.Elma.Web.Auth.Models
{
    public class AuthModel
    {
        [Display(Name = "ФИО")]
        [Required(ErrorMessage = "Введите фамилию, имя, отчество")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Введите почтовый адрес")]
        //[EmailAddress(ErrorMessage = "Почтовый адрес неправильный")]
        public string Email { get; set; }
    }
}