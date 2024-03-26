using ApiDeCadastro.Models.Entitys;
using AutoMapper;

namespace ApiDeCadastro.Aplication.UseCase.UserCase.UpdateUser;

public sealed class UpdateUserMap : Profile
{
    public UpdateUserMap()
    {
        CreateMap<UpdateUserRequest, User>();
        CreateMap<User, UpdateUserResponse>();
    }
}
