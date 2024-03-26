using ApiDeCadastro.Models.Entitys;
using ApiDeCadastro.Models.Interface;
using AutoMapper;
using MediatR;

namespace ApiDeCadastro.Aplication.UseCase.UserCase.AddUser
{
    public sealed class AddUserHandler : IRequestHandler<AddUserRequest, AddUserResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUser _user;

        public AddUserHandler(IMapper mapper, IUser user)
        {
            _mapper = mapper;
            _user = user;
        }

        public Task<AddUserResponse> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            var validarRequest = _mapper.Map<User>(request);
            _user.Add(validarRequest);
            var validarResponse = _mapper.Map<AddUserResponse>(validarRequest);

            return Task.FromResult(validarResponse);
        }
    }
}
