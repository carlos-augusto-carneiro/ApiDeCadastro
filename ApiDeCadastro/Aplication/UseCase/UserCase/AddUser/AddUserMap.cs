using ApiDeCadastro.Models.Entitys;
using AutoMapper;

namespace ApiDeCadastro.Aplication.UseCase.UserCase.AddUser
{
    public sealed class AddUserMap : Profile
    {
        public AddUserMap()
        {
            CreateMap<AddUserRequest, User>();
            CreateMap<User, AddUserResponse>();
        }
    }
}
