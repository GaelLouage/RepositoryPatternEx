using RepositoryPatternEx.Helpers;
using RepositoryPatternEx.Repositories.Interfaces;

namespace RepositoryPatternEx.Repositories.Classes
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public List<T> GetDataByCustomRule(Func<T, bool> rule, List<T> data)
        {
            return data.Where(rule).ToList();
        }
        public T GetSingleDataByCustomRule(Func<T, bool> rule, List<T> data)
        {
            var first = data.FirstOrDefault(rule);
            if(first is null)
            {
                return default(T);
            }
            return first;
        }
        public void Add(T item, List<T> data)
        {
            DataHelper.DataHandler(item, data, () =>
            {
                data.Add(item);
            });
        }

        public void Remove(T item, List<T> data)
        {
            DataHelper.DataHandler(item, data, () =>
            {
                data.Remove(item);
            });

        }
        public void Update(T item, List<T> data, Func<T, bool> rule)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (rule(data[i]))
                {
                    var props = typeof(T).GetProperties();
                    foreach (var prop in props)
                    {
                        if (prop.CanWrite)
                        {
                            prop.SetValue(data[i], prop.GetValue(item));
                        }
                    }
                }
            }
        }
    }
}
