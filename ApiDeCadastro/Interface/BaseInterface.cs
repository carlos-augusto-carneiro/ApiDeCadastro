using ApiDeCadastro.Models;

namespace ApiDeCadastro.Interface
{
    public interface BaseInterface<T> where T : BaseClass
    {
        public void Add(T t);
        public void Update(Guid Id, T t);
        public Task<List<T>> List();
        public T Search(Guid Id);
        public void Deleted(Guid Id);

    }
}
