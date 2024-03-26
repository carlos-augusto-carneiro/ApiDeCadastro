using ApiDeCadastro.Models.Entitys;
using ApiDeCadastro.Models.Interface;

namespace ApiDeCadastro.Context.Repository;

public class UserRepository : BaseRepository<User>, IUser
{
    public UserRepository(DbUser context) : base(context)
    {
    }
}
