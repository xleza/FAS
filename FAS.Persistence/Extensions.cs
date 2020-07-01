using System.Linq;

namespace FAS.Persistence
{
    public static class Extensions
    {
        public static string GetSqlProperties<T>()
            => string.Join(" , ", typeof(T).GetProperties().Select(x => x.Name));
    }
}
