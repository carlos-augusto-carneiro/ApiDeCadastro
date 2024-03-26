using MediatR;

namespace ApiDeCadastro.Aplication.UseCase.UserCase.UpdateUser;

public sealed record UpdateUserRequest(Guid Id,string Name, string Surname, string Email, string Username, string Password) 
    : IRequest<UpdateUserResponse>
{
}
