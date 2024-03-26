namespace ApiDeCadastro.Aplication.UseCase.UserCase.UpdateUser;

public sealed record UpdateUserResponse
{
    public string Name { get; set; } = default!;
    public string Surname { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Username { get; set; } = default!;
}
