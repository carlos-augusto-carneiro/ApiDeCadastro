using ApiDeCadastro.Models.Entitys;
using ApiDeCadastro.Models.Interface;
using AutoMapper;
using MediatR;

namespace ApiDeCadastro.Aplication.UseCase.UserCase.UpdateUser;

public sealed class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
{
    private readonly IMapper _mapper;
    private readonly IUser _user;

    public UpdateUserHandler(IMapper mapper, IUser user)
    {
        _mapper = mapper;
        _user = user;
    }

    public Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
    {
        var validarRequest = _mapper.Map<User>(request);
        _user.Update(validarRequest.Id,validarRequest);
        var validarResponse = _mapper.Map<UpdateUserResponse>(validarRequest);

        return Task.FromResult(validarResponse);
    }
}
