using Microsoft.EntityFrameworkCore;
using Test1_Blue_Api.Data;
using Test1_Blue_Api.Repo.Base;

namespace Test1_Blue_Api.Repo
{
    public class MainRepo<T> : IRepo<T> where T : class
    {
        public MainRepo(AppDbContext Context) 
        {
            _Context = Context;
        
        }

        private readonly AppDbContext _Context;

        public T FindById(int id)
        {
            return _Context.Set<T>().Find(id);
        }

        public async Task<IEnumerable<T>> FindAll()
        {
            return await _Context.Set<T>().ToListAsync();
        }
    }
}
