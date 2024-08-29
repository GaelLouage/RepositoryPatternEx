namespace RepositoryPatternEx.Helpers
{
    public static class DataHelper
    {
        public static void DataHandler<T>(T item, List<T> data, Action action)
        {
            if (data is null)
            {
                throw new ArgumentNullException("No data found!");
            }
            if (data.Contains(item) is false)
            {
                action();
            }
        }
    }
}
