namespace RepositoryPatternEx.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T item, List<T> data);
        List<T> GetDataByCustomRule(Func<T, bool> rule, List<T> data);
        T GetSingleDataByCustomRule(Func<T, bool> rule, List<T> data);
        void Remove(T item, List<T> data);
        void Update(T item, List<T> data, Func<T, bool> rule);
    }
}