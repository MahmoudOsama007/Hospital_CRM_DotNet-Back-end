namespace Test1_Blue_Api.Repo.Base
{
    public interface IRepo<T> where T : class
    {
         T FindById(int id);

        Task<IEnumerable<T>> FindAll();




    }
}
