using System.Linq;

namespace BinnenFA54Project.Main
{
    static class Utilities
    {

        /// <summary>
        /// Extension method for comparing multiple values.
        /// Works the same as in SQL: "WHERE column_name IN (1, 2, 3, 4)".
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static bool In<T>(this T obj, params T[] args)
        {
            return args.Contains(obj);
        }

    }
}
