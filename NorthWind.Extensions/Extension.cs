using System;
using System.Linq;
using System.Reflection;

namespace NorthWind.Extensions
{
    public static class Extension
    {
        public static T Changer<T>(this object source)
        {
            T target = Activator.CreateInstance<T>();
            Type root = source.GetType();

            PropertyInfo[] rootProps = root.GetProperties();
            PropertyInfo[] targetProps = typeof(T).GetProperties();

            foreach (PropertyInfo pi in rootProps)
            {
                object value = pi.GetValue(source);
                PropertyInfo tp = targetProps.FirstOrDefault(x => x.Name == pi.Name);
                tp?.SetValue(target, value);
            }

            return target;
        }
    }
}
