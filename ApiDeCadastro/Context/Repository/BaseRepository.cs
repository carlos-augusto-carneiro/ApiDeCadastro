using ApiDeCadastro.Models.Entitys;
using ApiDeCadastro.Models.Interface;

namespace ApiDeCadastro.Context.Repository;

public class BaseRepository<T> : BaseInterface<T> where T : BaseClass
{
    private readonly DbUser _context;

    public BaseRepository(DbUser context)
    {
        _context = context;
    }

    public void Add(T t)
    {
        _context.Set<T>().Add(t);
        _context.SaveChanges();
    }

    public void Deleted(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> List()
    {
        throw new NotImplementedException();
    }

    public T Search(Guid Id)
    {
        throw new NotImplementedException();
    }

    public void Update(Guid Id, T t)
    {
        throw new NotImplementedException();
    }
}
