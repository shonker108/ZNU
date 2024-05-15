using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Singleton<T> where T : class
    {
        private static T? instance_;
        protected Singleton() { }
        private static T CreateInstance()
        {
            /* System.Reflection.ConstructorInfo cInfo = typeof(T).GetConstructor(
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null,
                new Type[0],
                new System.Reflection.ParameterModifier[0])!;
            return (T)cInfo.Invoke(null); */

            return (T)Activator.CreateInstance(typeof(T));
        }
        public static T Instance
        {
            get
            {
                if (instance_ == null)
                    instance_ = CreateInstance();
                return instance_;
            }
        }
    }

}
