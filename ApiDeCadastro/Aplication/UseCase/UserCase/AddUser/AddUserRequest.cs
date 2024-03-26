using MediatR;

namespace ApiDeCadastro.Aplication.UseCase.UserCase.AddUser;

public sealed record AddUserRequest(string Name, string Surname, string Email, string Username, string Password) : IRequest<AddUserResponse>
{
}
