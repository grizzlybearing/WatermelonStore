using System.ComponentModel.DataAnnotations;
public class UserDto
{
	public int Id { get; set; }
	[EmailAddress]
	public string Email { get; set; }
	[Required]
	public string Password { get; set; }
}