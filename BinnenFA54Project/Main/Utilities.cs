using System;
using System.Linq;

namespace BinnenFA54Project.Main
{
    /// <summary>
    /// A Static that We can also call this class as Helper class which we create all the methods that will be 
    /// easily to access and make it easier for us writting code.
    /// We mainly using this class to write Extention Methods so any object can access them.
    /// </summary>
    public static class Utilities
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




        /// <summary>
        /// Converter for nullable types.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDest"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static TDest? ConvertTo<TSource, TDest>(this TSource? source)
            where TDest : struct
            where TSource : struct
        {
            if (source == null)
            {
                return null;
            }
            return (TDest) Convert.ChangeType(source.Value, typeof(TDest));
        }

    }
}
