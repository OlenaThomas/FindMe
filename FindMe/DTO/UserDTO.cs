using System.ComponentModel.DataAnnotations;

namespace FindMe.DTO
{
    public class UserDTO
    {
        [EmailAddress(ErrorMessage = "Некорректный адрес")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Длина строки должна быть от 4 до 10 символов")]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Password { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [Phone(ErrorMessage = "Некорректный номер телефона")]
        public string? PhoneNumber { get; set; }
    }
}
