using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    private DateTime _registrationDate;

    [Required]
    public DateTime RegistrationDate
    {
        get => _registrationDate;
        set => _registrationDate = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    }
}
